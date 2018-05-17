using LicenseClientManager.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace LicenseClientManager
{
    public partial class MainForm : Form
    {
        static Dictionary<string, string> argumentDictionary;
        const string secret = "adf98da6fgd8a98fd7gads8fw"; //"21A421B6-AA97-40AE-985E-9DED2BA8224F";

        public MainForm()
        {
            InitializeComponent();
        }

        public void ProcessArguments(string[] args)
        {
            argumentDictionary = ProgramHelper.GetArgumentPair(args.ToList());

            ValidateArguments();

            titelLabel.Text = argumentDictionary["programname"];
            Text = argumentDictionary["programname"];
            webSiteUrl.Text = argumentDictionary["activationurl"];
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

            if ((argumentDictionary.ContainsKey("mode") && argumentDictionary["mode"] == "silent") && !argumentDictionary.ContainsKey("activationkey"))
            {
                MessageBox.Show("Activation key missing for silent activation.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit((int)ExitCode.InvalidParameters);
            }

            argumentDictionary.Add("machinename", Environment.MachineName);
        }

        internal void Open(bool showDialog)
        {
            if (showDialog)
            {
                Visible = true;
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
                this.TopMost = true;
                this.TopMost = false;
                this.Focus();
            }
            else
            {
                Visible = false;
            }
            Opacity = showDialog ? 100 : 0;
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

            bool showDialog = true;

            if (argumentDictionary.ContainsKey("mode"))
                showDialog = argumentDictionary["mode"] == "dialog";

            Open(showDialog);

            string rtf = Resources.terms_and_conditions_template;
            termsConditionsBox.Rtf = rtf;
            activationKeyTextbox.Text = argumentDictionary.ContainsKey("activationkey") ? argumentDictionary["activationkey"] : ""; // RegistryHelper.GetActivationKeyFromRegistryIfPresent();
            activationKeyTextbox.Enabled = string.IsNullOrEmpty(activationKeyTextbox.Text);
            licenseActivationOfflineTab.Enabled = string.IsNullOrEmpty(activationKeyTextbox.Text);

            if (showDialog == false)
            {
                OnlineActivate(showDialog);
            }
        }

        private void offlineActivationButton_Click(object sender, EventArgs e)
        {
            if (ValidActivationKey())
            {
                offlineActivationKeyTextbox.Text = WebHelper.GetActivationKey(activationKeyTextbox.Text, argumentDictionary["machinename"], argumentDictionary["version"]);
                licenseActivationTabControl.SelectedTab = licenseActivationOfflineTab;
            }
            else
            {
                licenseActivationTabControl.SelectedTab = licenseActivationOnlineTab;
            }
        }

        private bool ValidActivationKey()
        {
            if (string.IsNullOrEmpty(activationKeyTextbox.Text))
            {
                MessageBox.Show("Enter a valid activation key", "Activation Key Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (!ValidActivationKey())
                {
                    licenseActivationTabControl.SelectedTab = licenseActivationOnlineTab;
                }
            }
        }

        private void onlineActivationButton_Click(object sender, EventArgs e)
        {
            OnlineActivate(true);
        }

        private void OnlineActivate(bool showDialog)
        {
            try
            {
                Enabled = false;
                Cursor = Cursors.WaitCursor;
                KeyValuePair<HttpStatusCode, string> result = WebHelper.PostData(activationKeyTextbox.Text, argumentDictionary["machinename"], argumentDictionary["version"], argumentDictionary["activationurl"]);
                Cursor = Cursors.Default;

                if (result.Key == HttpStatusCode.OK)
                {

                    File.WriteAllText(argumentDictionary["licensefile"], WebHelper.Base64Decode(result.Value.Replace("\"", "")));

                    if (showDialog)
                    {
                        MessageBox.Show("Thank you, your product has now been licensed", "Post Data Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (argumentDictionary.ContainsKey("statusfile"))
                        {
                            File.WriteAllText(argumentDictionary["statusfile"], $"{(int)result.Key}{Environment.NewLine}the product has now been licensed");
                        }
                    }
                    Application.Exit();
                }
                else
                {
                    if (showDialog)
                    {
                        MessageBox.Show(result.Value, "Post Data Result", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (argumentDictionary.ContainsKey("statusfile")) {
                            File.WriteAllText(argumentDictionary["statusfile"], $"{(int)result.Key}{Environment.NewLine}{result.Value}");
                        }
                        Application.Exit();
                    }
                }
                Enabled = true;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                Enabled = true;
                if (showDialog)
                {
                    MessageBox.Show(ex.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (argumentDictionary.ContainsKey("statusfile")) {
                        File.WriteAllText(argumentDictionary["statusfile"], $"9999{Environment.NewLine}{ex.Message}");
                    }
                    Application.Exit();
                }
            }
        }

        private void offlineCopyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(offlineActivationKeyTextbox.Text);
        }

        private void offlineSaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Activation Key info|*.inf";
            saveFileDialog.Title = "Save Activation Key Information";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, offlineActivationKeyTextbox.Text);
                MessageBox.Show("The file has been saved", "Save License Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void offlineActivateResponseNow_Click(object sender, EventArgs e)
        {
            File.WriteAllText($"{argumentDictionary["licensefile"]}", activationResponseDataTextbox.Text);
            MessageBox.Show("Thank you - your product has now been licensed", "Save License Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}