using LicenseClientManager.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void ProcessArguments(string[] args, bool ignoreShift)
        {
            string commandLineString = string.Join(" ", args);
            argumentDictionary = ProgramHelper.GetArguments(commandLineString);

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
            string rtf = Resources.terms_and_conditions_template;
            termsConditionsBox.Rtf = rtf;
        }
    }
}
