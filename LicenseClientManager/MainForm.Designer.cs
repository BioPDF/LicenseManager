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
            this.licensingTab = new System.Windows.Forms.TabPage();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.termsConditionsTextbox = new System.Windows.Forms.TextBox();
            this.AcceptTermsConditionsCheckbox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.topPanel.SuspendLayout();
            this.guideTabControl.SuspendLayout();
            this.termsConditionsTab.SuspendLayout();
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
            this.guideTabControl.Controls.Add(this.termsConditionsTab);
            this.guideTabControl.Controls.Add(this.licensingTab);
            this.guideTabControl.Location = new System.Drawing.Point(12, 46);
            this.guideTabControl.Name = "guideTabControl";
            this.guideTabControl.SelectedIndex = 0;
            this.guideTabControl.Size = new System.Drawing.Size(730, 495);
            this.guideTabControl.TabIndex = 3;
            // 
            // termsConditionsTab
            // 
            this.termsConditionsTab.BackColor = System.Drawing.SystemColors.Control;
            this.termsConditionsTab.Controls.Add(this.AcceptTermsConditionsCheckbox);
            this.termsConditionsTab.Controls.Add(this.termsConditionsTextbox);
            this.termsConditionsTab.Controls.Add(this.label1);
            this.termsConditionsTab.Location = new System.Drawing.Point(4, 27);
            this.termsConditionsTab.Name = "termsConditionsTab";
            this.termsConditionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.termsConditionsTab.Size = new System.Drawing.Size(722, 464);
            this.termsConditionsTab.TabIndex = 0;
            // 
            // licensingTab
            // 
            this.licensingTab.Location = new System.Drawing.Point(4, 27);
            this.licensingTab.Name = "licensingTab";
            this.licensingTab.Padding = new System.Windows.Forms.Padding(3);
            this.licensingTab.Size = new System.Drawing.Size(722, 464);
            this.licensingTab.TabIndex = 1;
            this.licensingTab.UseVisualStyleBackColor = true;
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
            // termsConditionsTextbox
            // 
            this.termsConditionsTextbox.BackColor = System.Drawing.Color.White;
            this.termsConditionsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.termsConditionsTextbox.Location = new System.Drawing.Point(18, 42);
            this.termsConditionsTextbox.Multiline = true;
            this.termsConditionsTextbox.Name = "termsConditionsTextbox";
            this.termsConditionsTextbox.ReadOnly = true;
            this.termsConditionsTextbox.Size = new System.Drawing.Size(685, 381);
            this.termsConditionsTextbox.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 24);
            this.panel1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(753, 569);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.guideTabControl.ResumeLayout(false);
            this.termsConditionsTab.ResumeLayout(false);
            this.termsConditionsTab.PerformLayout();
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
        private System.Windows.Forms.TextBox termsConditionsTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

