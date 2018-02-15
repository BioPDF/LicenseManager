namespace LicenseClientManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logo = new System.Windows.Forms.PictureBox();
            this.titelLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.guideTabControl = new System.Windows.Forms.TabControl();
            this.termsConditionsTab = new System.Windows.Forms.TabPage();
            this.termsConditionsBox = new System.Windows.Forms.RichTextBox();
            this.AcceptTermsConditionsCheckbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.licensingTab = new System.Windows.Forms.TabPage();
            this.licenseActivationTabControl = new System.Windows.Forms.TabControl();
            this.licenseActivationOnlineTab = new System.Windows.Forms.TabPage();
            this.onlineActivationButton = new System.Windows.Forms.Button();
            this.activationKeyTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.licenseActivationOfflineTab = new System.Windows.Forms.TabPage();
            this.offlineActivateResponseNow = new System.Windows.Forms.Button();
            this.activationResponseDataTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.offlineSaveToFileButton = new System.Windows.Forms.Button();
            this.offlineCopyToClipboardButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.offlineActivationKeyTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.licenseActivationLabel = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.blindPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.topPanel.SuspendLayout();
            this.guideTabControl.SuspendLayout();
            this.termsConditionsTab.SuspendLayout();
            this.licensingTab.SuspendLayout();
            this.licenseActivationTabControl.SuspendLayout();
            this.licenseActivationOnlineTab.SuspendLayout();
            this.licenseActivationOfflineTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = global::LicenseClientManager.Properties.Resources.License_manager48;
            this.logo.Location = new System.Drawing.Point(7, 7);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(56, 52);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // titelLabel
            // 
            this.titelLabel.AutoSize = true;
            this.titelLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelLabel.Location = new System.Drawing.Point(65, 16);
            this.titelLabel.Name = "titelLabel";
            this.titelLabel.Size = new System.Drawing.Size(273, 32);
            this.titelLabel.TabIndex = 1;
            this.titelLabel.Text = "Bullzip License Manager";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.titelLabel);
            this.topPanel.Controls.Add(this.logo);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(753, 65);
            this.topPanel.TabIndex = 2;
            // 
            // guideTabControl
            // 
            this.guideTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.guideTabControl.Controls.Add(this.licensingTab);
            this.guideTabControl.Controls.Add(this.termsConditionsTab);
            this.guideTabControl.Location = new System.Drawing.Point(12, 46);
            this.guideTabControl.Name = "guideTabControl";
            this.guideTabControl.SelectedIndex = 0;
            this.guideTabControl.Size = new System.Drawing.Size(730, 495);
            this.guideTabControl.TabIndex = 3;
            // 
            // termsConditionsTab
            // 
            this.termsConditionsTab.BackColor = System.Drawing.SystemColors.Control;
            this.termsConditionsTab.Controls.Add(this.termsConditionsBox);
            this.termsConditionsTab.Controls.Add(this.AcceptTermsConditionsCheckbox);
            this.termsConditionsTab.Controls.Add(this.label1);
            this.termsConditionsTab.Location = new System.Drawing.Point(4, 27);
            this.termsConditionsTab.Name = "termsConditionsTab";
            this.termsConditionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.termsConditionsTab.Size = new System.Drawing.Size(722, 464);
            this.termsConditionsTab.TabIndex = 0;
            // 
            // termsConditionsBox
            // 
            this.termsConditionsBox.Location = new System.Drawing.Point(19, 49);
            this.termsConditionsBox.Name = "termsConditionsBox";
            this.termsConditionsBox.ReadOnly = true;
            this.termsConditionsBox.Size = new System.Drawing.Size(685, 368);
            this.termsConditionsBox.TabIndex = 3;
            this.termsConditionsBox.Text = "";
            // 
            // AcceptTermsConditionsCheckbox
            // 
            this.AcceptTermsConditionsCheckbox.AutoSize = true;
            this.AcceptTermsConditionsCheckbox.Location = new System.Drawing.Point(18, 434);
            this.AcceptTermsConditionsCheckbox.Name = "AcceptTermsConditionsCheckbox";
            this.AcceptTermsConditionsCheckbox.Size = new System.Drawing.Size(202, 19);
            this.AcceptTermsConditionsCheckbox.TabIndex = 2;
            this.AcceptTermsConditionsCheckbox.Text = "I accept the terms and conditions";
            this.AcceptTermsConditionsCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terms && Conditions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // licensingTab
            // 
            this.licensingTab.Controls.Add(this.licenseActivationTabControl);
            this.licensingTab.Controls.Add(this.licenseActivationLabel);
            this.licensingTab.Location = new System.Drawing.Point(4, 27);
            this.licensingTab.Name = "licensingTab";
            this.licensingTab.Padding = new System.Windows.Forms.Padding(3);
            this.licensingTab.Size = new System.Drawing.Size(722, 464);
            this.licensingTab.TabIndex = 1;
            this.licensingTab.UseVisualStyleBackColor = true;
            // 
            // licenseActivationTabControl
            // 
            this.licenseActivationTabControl.Controls.Add(this.licenseActivationOnlineTab);
            this.licenseActivationTabControl.Controls.Add(this.licenseActivationOfflineTab);
            this.licenseActivationTabControl.Location = new System.Drawing.Point(19, 41);
            this.licenseActivationTabControl.Name = "licenseActivationTabControl";
            this.licenseActivationTabControl.SelectedIndex = 0;
            this.licenseActivationTabControl.Size = new System.Drawing.Size(684, 396);
            this.licenseActivationTabControl.TabIndex = 8;
            // 
            // licenseActivationOnlineTab
            // 
            this.licenseActivationOnlineTab.Controls.Add(this.onlineActivationButton);
            this.licenseActivationOnlineTab.Controls.Add(this.activationKeyTextbox);
            this.licenseActivationOnlineTab.Controls.Add(this.label2);
            this.licenseActivationOnlineTab.Location = new System.Drawing.Point(4, 24);
            this.licenseActivationOnlineTab.Name = "licenseActivationOnlineTab";
            this.licenseActivationOnlineTab.Padding = new System.Windows.Forms.Padding(3);
            this.licenseActivationOnlineTab.Size = new System.Drawing.Size(676, 368);
            this.licenseActivationOnlineTab.TabIndex = 0;
            this.licenseActivationOnlineTab.Text = "Online";
            this.licenseActivationOnlineTab.UseVisualStyleBackColor = true;
            // 
            // onlineActivationButton
            // 
            this.onlineActivationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineActivationButton.Location = new System.Drawing.Point(277, 162);
            this.onlineActivationButton.Name = "onlineActivationButton";
            this.onlineActivationButton.Size = new System.Drawing.Size(122, 35);
            this.onlineActivationButton.TabIndex = 2;
            this.onlineActivationButton.Text = "Activate Now";
            this.onlineActivationButton.UseVisualStyleBackColor = true;
            // 
            // activationKeyTextbox
            // 
            this.activationKeyTextbox.Location = new System.Drawing.Point(21, 42);
            this.activationKeyTextbox.Name = "activationKeyTextbox";
            this.activationKeyTextbox.Size = new System.Drawing.Size(632, 23);
            this.activationKeyTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter or Paste Activation Code:";
            // 
            // licenseActivationOfflineTab
            // 
            this.licenseActivationOfflineTab.Controls.Add(this.offlineActivateResponseNow);
            this.licenseActivationOfflineTab.Controls.Add(this.activationResponseDataTextbox);
            this.licenseActivationOfflineTab.Controls.Add(this.label8);
            this.licenseActivationOfflineTab.Controls.Add(this.label9);
            this.licenseActivationOfflineTab.Controls.Add(this.label7);
            this.licenseActivationOfflineTab.Controls.Add(this.label5);
            this.licenseActivationOfflineTab.Controls.Add(this.label6);
            this.licenseActivationOfflineTab.Controls.Add(this.offlineSaveToFileButton);
            this.licenseActivationOfflineTab.Controls.Add(this.offlineCopyToClipboardButton);
            this.licenseActivationOfflineTab.Controls.Add(this.label4);
            this.licenseActivationOfflineTab.Controls.Add(this.offlineActivationKeyTextbox);
            this.licenseActivationOfflineTab.Controls.Add(this.label3);
            this.licenseActivationOfflineTab.Location = new System.Drawing.Point(4, 24);
            this.licenseActivationOfflineTab.Name = "licenseActivationOfflineTab";
            this.licenseActivationOfflineTab.Padding = new System.Windows.Forms.Padding(3);
            this.licenseActivationOfflineTab.Size = new System.Drawing.Size(676, 368);
            this.licenseActivationOfflineTab.TabIndex = 1;
            this.licenseActivationOfflineTab.Text = "Offline";
            this.licenseActivationOfflineTab.UseVisualStyleBackColor = true;
            // 
            // offlineActivateResponseNow
            // 
            this.offlineActivateResponseNow.Location = new System.Drawing.Point(534, 256);
            this.offlineActivateResponseNow.Name = "offlineActivateResponseNow";
            this.offlineActivateResponseNow.Size = new System.Drawing.Size(125, 23);
            this.offlineActivateResponseNow.TabIndex = 15;
            this.offlineActivateResponseNow.Text = "Activate Now";
            this.offlineActivateResponseNow.UseVisualStyleBackColor = true;
            // 
            // activationResponseDataTextbox
            // 
            this.activationResponseDataTextbox.Location = new System.Drawing.Point(21, 256);
            this.activationResponseDataTextbox.Multiline = true;
            this.activationResponseDataTextbox.Name = "activationResponseDataTextbox";
            this.activationResponseDataTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.activationResponseDataTextbox.Size = new System.Drawing.Size(504, 90);
            this.activationResponseDataTextbox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(501, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Enter og Paste the information retrieved from the web site activation, then click" +
    " Activate Now:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Step 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(134, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "https://www.bullzip.com/activation";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(626, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Go to the following web site on a computer with internet access and Paste the inf" +
    "ormation into the activation information text box.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Step 2:";
            // 
            // offlineSaveToFileButton
            // 
            this.offlineSaveToFileButton.Location = new System.Drawing.Point(534, 83);
            this.offlineSaveToFileButton.Name = "offlineSaveToFileButton";
            this.offlineSaveToFileButton.Size = new System.Drawing.Size(125, 23);
            this.offlineSaveToFileButton.TabIndex = 8;
            this.offlineSaveToFileButton.Text = "Save to a File...";
            this.offlineSaveToFileButton.UseVisualStyleBackColor = true;
            // 
            // offlineCopyToClipboardButton
            // 
            this.offlineCopyToClipboardButton.Location = new System.Drawing.Point(534, 54);
            this.offlineCopyToClipboardButton.Name = "offlineCopyToClipboardButton";
            this.offlineCopyToClipboardButton.Size = new System.Drawing.Size(125, 23);
            this.offlineCopyToClipboardButton.TabIndex = 7;
            this.offlineCopyToClipboardButton.Text = "Copy to Clipboard";
            this.offlineCopyToClipboardButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Save the following information:";
            // 
            // offlineActivationKeyTextbox
            // 
            this.offlineActivationKeyTextbox.Location = new System.Drawing.Point(21, 54);
            this.offlineActivationKeyTextbox.Multiline = true;
            this.offlineActivationKeyTextbox.Name = "offlineActivationKeyTextbox";
            this.offlineActivationKeyTextbox.ReadOnly = true;
            this.offlineActivationKeyTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.offlineActivationKeyTextbox.Size = new System.Drawing.Size(501, 90);
            this.offlineActivationKeyTextbox.TabIndex = 4;
            this.offlineActivationKeyTextbox.Text = resources.GetString("offlineActivationKeyTextbox.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Step 1:";
            // 
            // licenseActivationLabel
            // 
            this.licenseActivationLabel.AutoSize = true;
            this.licenseActivationLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseActivationLabel.Location = new System.Drawing.Point(15, 12);
            this.licenseActivationLabel.Name = "licenseActivationLabel";
            this.licenseActivationLabel.Size = new System.Drawing.Size(128, 20);
            this.licenseActivationLabel.TabIndex = 7;
            this.licenseActivationLabel.Text = "License Activation";
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previousButton.Enabled = false;
            this.previousButton.Location = new System.Drawing.Point(558, 527);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 23);
            this.previousButton.TabIndex = 4;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Location = new System.Drawing.Point(645, 527);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // blindPanel
            // 
            this.blindPanel.Location = new System.Drawing.Point(3, 46);
            this.blindPanel.Name = "blindPanel";
            this.blindPanel.Size = new System.Drawing.Size(745, 24);
            this.blindPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(753, 569);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.blindPanel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.guideTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bullzip License Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.guideTabControl.ResumeLayout(false);
            this.termsConditionsTab.ResumeLayout(false);
            this.termsConditionsTab.PerformLayout();
            this.licensingTab.ResumeLayout(false);
            this.licensingTab.PerformLayout();
            this.licenseActivationTabControl.ResumeLayout(false);
            this.licenseActivationOnlineTab.ResumeLayout(false);
            this.licenseActivationOnlineTab.PerformLayout();
            this.licenseActivationOfflineTab.ResumeLayout(false);
            this.licenseActivationOfflineTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label titelLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TabControl guideTabControl;
        private System.Windows.Forms.TabPage termsConditionsTab;
        private System.Windows.Forms.TabPage licensingTab;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.CheckBox AcceptTermsConditionsCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel blindPanel;
        private System.Windows.Forms.Label licenseActivationLabel;
        private System.Windows.Forms.TabControl licenseActivationTabControl;
        private System.Windows.Forms.TabPage licenseActivationOnlineTab;
        private System.Windows.Forms.TabPage licenseActivationOfflineTab;
        private System.Windows.Forms.TextBox activationKeyTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button onlineActivationButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button offlineSaveToFileButton;
        private System.Windows.Forms.Button offlineCopyToClipboardButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox offlineActivationKeyTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox activationResponseDataTextbox;
        private System.Windows.Forms.Button offlineActivateResponseNow;
        private System.Windows.Forms.RichTextBox termsConditionsBox;
    }
}

