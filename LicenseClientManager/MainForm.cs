using LicenseClientManager.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LicenseClientManager
{
    public partial class MainForm : Form
    {
        static Dictionary<string, string> argumentDictionary;

        public MainForm()
        {
            InitializeComponent();
        }

        public void ProcessArguments(string[] args)
        {
            string commandLineString = string.Join(" ", args);
            argumentDictionary = ProgramHelper.GetArguments(commandLineString);

            ValidateArguments();

            try
            {
                Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, $"{Application.ProductName} - Error occurred (process)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            argumentDictionary = null;
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
                MessageBox.Show("You must accept the terms & conditions as stated in this form to be able to continue.", "Accept Terms & Conditions", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
