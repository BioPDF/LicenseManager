using LicenseClientManager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LicenseClientManager.Helpers;
using System.IO;

namespace LicenseClientManager
{
    public partial class MainForm : Form
    {
        static Dictionary<string, string> argumentDictionary;
        const string secret = "21A421B6-AA97-40AE-985E-9DED2BA8224F";

        public MainForm()
        {
            InitializeComponent();
        }

        public void ProcessArguments(string[] args)
        {
            string commandLineString = string.Join(" ", args);
            argumentDictionary = ProgramHelper.GetArguments(commandLineString);

            ValidateArguments();

            titelLabel.Text = argumentDictionary["programname"];
            Text = argumentDictionary["programname"];
            webSiteUrl.Text = argumentDictionary["activationurl"];

            try
            {
                Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"{Application.ProductName} - Error occurred (process)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //argumentDictionary = null;
        }

        private void ValidateArguments()
        {
            if (argumentDictionary.Count < 2)
            {
                MessageBox.Show("No parameters supplied for acivation. The license manager cannot continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit((int)ExitCode.NoParameters);
            }
            if (!argumentDictionary.ContainsKey("action"))
            {
                MessageBox.Show("Action parameter missing. The license manager cannot continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit((int)ExitCode.InvalidParameters);
            }
            if (!argumentDictionary.ContainsKey("version"))
            {
                MessageBox.Show("Version information missing. The license manager cannot continue.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit((int)ExitCode.InvalidParameters);
            }

            argumentDictionary.Add("machinename", Environment.MachineName);
        }

        internal void Open()
        {
            if (WindowState == FormWindowState.Minimized || Visible == false)
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
                this.TopMost = true;
                this.TopMost = false;
                this.Focus();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!AcceptTermsConditionsCheckbox.Checked)
            {
                MessageBox.Show("You must accept the Terms and Conditions as stated in this form to be able to continue.", "Accept Terms & Conditions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (guideTabControl.SelectedIndex < guideTabControl.TabCount - 1)
            {
                guideTabControl.SelectedIndex += 1;
                previousButton.Enabled = true;
            }
            if (guideTabControl.SelectedIndex == guideTabControl.TabCount - 1)
            {
                nextButton.Enabled = false;
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (licenseActivationTabControl.SelectedIndex > 0)
            {
                licenseActivationTabControl.SelectedIndex -= 1;
                previousButton.Enabled = true;
            }
            else
            {
                if (guideTabControl.SelectedIndex > 0)
                {
                    guideTabControl.SelectedIndex -= 1;
                    nextButton.Enabled = true;
                }
                if (guideTabControl.SelectedIndex == 0)
                {
                    previousButton.Enabled = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ProcessArguments(Environment.GetCommandLineArgs());

            string rtf = Resources.terms_and_conditions_template;
            termsConditionsBox.Rtf = rtf;

            activationKeyTextbox.Text = RegistryHelper.GetActivationKeyFromRegistryIfPresent();
            activationKeyTextbox.Enabled = string.IsNullOrEmpty(activationKeyTextbox.Text);
            licenseActivationOfflineTab.Enabled = string.IsNullOrEmpty(activationKeyTextbox.Text);
        }

        private void offlineActivationButton_Click(object sender, EventArgs e)
        {
            if (ValidActivationCode())
            {
                offlineActivationKeyTextbox.Text = WebHelper.GetActivationKey(activationKeyTextbox.Text, argumentDictionary["machinename"], argumentDictionary["version"]);
                licenseActivationTabControl.SelectedTab = licenseActivationOfflineTab;
            }
            else
            {
                licenseActivationTabControl.SelectedTab = licenseActivationOnlineTab;
            }
        }

        private bool ValidActivationCode()
        {
            if (string.IsNullOrEmpty(activationKeyTextbox.Text))
            {
                MessageBox.Show("Enter a valid activation code", "Activation Code Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                activationKeyTextbox.Focus();
                return false;
            }

            return true;
        }

        private void licenseActivationTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void licenseActivationTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == licenseActivationOfflineTab)
            {
                if (!ValidActivationCode())
                {
                    licenseActivationTabControl.SelectedTab = licenseActivationOnlineTab;
                }
            }
        }

        //public static string Base64Encode(string plainText)
        //{
        //    var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        //    return System.Convert.ToBase64String(plainTextBytes);
        //}

        //public static string Base64Decode(string base64EncodedData)
        //{
        //    var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        //    return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        //}

        private void onlineActivationButton_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                Cursor = Cursors.WaitCursor;
                string result = WebHelper.PostData(activationKeyTextbox.Text, argumentDictionary["version"], argumentDictionary["machinename"], argumentDictionary["activationurl"]);
                Cursor = Cursors.Default;

                if (result.Contains("Thank you"))
                {
                    MessageBox.Show("Thank you, the product is now licensed.", "Post Data Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("The activation key is not known in our database. Please provide a valide license key at try again.", "Post Data Result", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                Enabled = true;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Enabled = true;
            }
        }

        private void offlineCopyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(offlineActivationKeyTextbox.Text);
        }

        private void offlineSaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "License info|*.lic";
            saveFileDialog.Title = "Save License Information";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, offlineActivationKeyTextbox.Text);
                MessageBox.Show("The file has been saved", "Save License Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}