namespace PWLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.PageLauncher = new System.Windows.Forms.TabPage();
            this.StartPW = new MaterialSkin.Controls.MaterialButton();
            this.PageAccounts = new System.Windows.Forms.TabPage();
            this.RemoveAccount = new MaterialSkin.Controls.MaterialButton();
            this.AccountList = new MaterialSkin.Controls.MaterialListBox();
            this.AddAccount = new MaterialSkin.Controls.MaterialButton();
            this.PassInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.UserInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.PageMods = new System.Windows.Forms.TabPage();
            this.PageExtras = new System.Windows.Forms.TabPage();
            this.useMods = new MaterialSkin.Controls.MaterialCheckbox();
            this.ForceClearData = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.PageLauncher.SuspendLayout();
            this.PageAccounts.SuspendLayout();
            this.PageMods.SuspendLayout();
            this.PageExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.PageLauncher);
            this.materialTabControl1.Controls.Add(this.PageAccounts);
            this.materialTabControl1.Controls.Add(this.PageMods);
            this.materialTabControl1.Controls.Add(this.PageExtras);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // PageLauncher
            // 
            this.PageLauncher.Controls.Add(this.materialLabel1);
            this.PageLauncher.Controls.Add(this.pictureBox1);
            this.PageLauncher.Controls.Add(this.StartPW);
            this.PageLauncher.Location = new System.Drawing.Point(4, 22);
            this.PageLauncher.Name = "PageLauncher";
            this.PageLauncher.Padding = new System.Windows.Forms.Padding(3);
            this.PageLauncher.Size = new System.Drawing.Size(786, 357);
            this.PageLauncher.TabIndex = 0;
            this.PageLauncher.Text = "Launcher";
            this.PageLauncher.UseVisualStyleBackColor = true;
            // 
            // StartPW
            // 
            this.StartPW.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartPW.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.StartPW.Depth = 0;
            this.StartPW.HighEmphasis = true;
            this.StartPW.Icon = null;
            this.StartPW.Location = new System.Drawing.Point(30, 285);
            this.StartPW.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StartPW.MinimumSize = new System.Drawing.Size(250, 0);
            this.StartPW.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartPW.Name = "StartPW";
            this.StartPW.NoAccentTextColor = System.Drawing.Color.Empty;
            this.StartPW.Size = new System.Drawing.Size(250, 36);
            this.StartPW.TabIndex = 0;
            this.StartPW.Text = "Start Pixel Worlds";
            this.StartPW.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.StartPW.UseAccentColor = false;
            this.StartPW.UseVisualStyleBackColor = true;
            this.StartPW.Click += new System.EventHandler(this.StartPW_Click);
            // 
            // PageAccounts
            // 
            this.PageAccounts.Controls.Add(this.RemoveAccount);
            this.PageAccounts.Controls.Add(this.AccountList);
            this.PageAccounts.Controls.Add(this.AddAccount);
            this.PageAccounts.Controls.Add(this.PassInput);
            this.PageAccounts.Controls.Add(this.UserInput);
            this.PageAccounts.Location = new System.Drawing.Point(4, 22);
            this.PageAccounts.Name = "PageAccounts";
            this.PageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.PageAccounts.Size = new System.Drawing.Size(786, 357);
            this.PageAccounts.TabIndex = 1;
            this.PageAccounts.Text = "Accounts";
            this.PageAccounts.UseVisualStyleBackColor = true;
            // 
            // RemoveAccount
            // 
            this.RemoveAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveAccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RemoveAccount.Depth = 0;
            this.RemoveAccount.HighEmphasis = true;
            this.RemoveAccount.Icon = null;
            this.RemoveAccount.Location = new System.Drawing.Point(21, 178);
            this.RemoveAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveAccount.MinimumSize = new System.Drawing.Size(250, 0);
            this.RemoveAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveAccount.Name = "RemoveAccount";
            this.RemoveAccount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RemoveAccount.Size = new System.Drawing.Size(250, 36);
            this.RemoveAccount.TabIndex = 4;
            this.RemoveAccount.Text = "Remove Account";
            this.RemoveAccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RemoveAccount.UseAccentColor = false;
            this.RemoveAccount.UseVisualStyleBackColor = true;
            this.RemoveAccount.Click += new System.EventHandler(this.RemoveAccount_Click);
            // 
            // AccountList
            // 
            this.AccountList.BackColor = System.Drawing.Color.White;
            this.AccountList.BorderColor = System.Drawing.Color.LightGray;
            this.AccountList.Depth = 0;
            this.AccountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AccountList.Location = new System.Drawing.Point(314, 22);
            this.AccountList.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccountList.Name = "AccountList";
            this.AccountList.SelectedIndex = -1;
            this.AccountList.SelectedItem = null;
            this.AccountList.ShowBorder = false;
            this.AccountList.ShowScrollBar = true;
            this.AccountList.Size = new System.Drawing.Size(446, 309);
            this.AccountList.TabIndex = 3;
            this.AccountList.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.AccountList_SelectedIndexChanged);
            // 
            // AddAccount
            // 
            this.AddAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddAccount.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddAccount.Depth = 0;
            this.AddAccount.HighEmphasis = true;
            this.AddAccount.Icon = null;
            this.AddAccount.Location = new System.Drawing.Point(21, 132);
            this.AddAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddAccount.MinimumSize = new System.Drawing.Size(250, 0);
            this.AddAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddAccount.Name = "AddAccount";
            this.AddAccount.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddAccount.Size = new System.Drawing.Size(250, 36);
            this.AddAccount.TabIndex = 2;
            this.AddAccount.Text = "Add Account";
            this.AddAccount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddAccount.UseAccentColor = false;
            this.AddAccount.UseVisualStyleBackColor = true;
            this.AddAccount.Click += new System.EventHandler(this.AddAccount_Click);
            // 
            // PassInput
            // 
            this.PassInput.AnimateReadOnly = false;
            this.PassInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PassInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PassInput.Depth = 0;
            this.PassInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PassInput.HideSelection = true;
            this.PassInput.Hint = "Password";
            this.PassInput.LeadingIcon = null;
            this.PassInput.Location = new System.Drawing.Point(21, 77);
            this.PassInput.MaxLength = 32767;
            this.PassInput.MouseState = MaterialSkin.MouseState.OUT;
            this.PassInput.Name = "PassInput";
            this.PassInput.PasswordChar = '*';
            this.PassInput.PrefixSuffixText = null;
            this.PassInput.ReadOnly = false;
            this.PassInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PassInput.SelectedText = "";
            this.PassInput.SelectionLength = 0;
            this.PassInput.SelectionStart = 0;
            this.PassInput.ShortcutsEnabled = true;
            this.PassInput.Size = new System.Drawing.Size(250, 48);
            this.PassInput.TabIndex = 1;
            this.PassInput.TabStop = false;
            this.PassInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassInput.TrailingIcon = null;
            this.PassInput.UseSystemPasswordChar = false;
            // 
            // UserInput
            // 
            this.UserInput.AnimateReadOnly = false;
            this.UserInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserInput.Depth = 0;
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserInput.HideSelection = true;
            this.UserInput.Hint = "Username";
            this.UserInput.LeadingIcon = null;
            this.UserInput.Location = new System.Drawing.Point(21, 22);
            this.UserInput.MaxLength = 32767;
            this.UserInput.MouseState = MaterialSkin.MouseState.OUT;
            this.UserInput.Name = "UserInput";
            this.UserInput.PasswordChar = '\0';
            this.UserInput.PrefixSuffixText = null;
            this.UserInput.ReadOnly = false;
            this.UserInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserInput.SelectedText = "";
            this.UserInput.SelectionLength = 0;
            this.UserInput.SelectionStart = 0;
            this.UserInput.ShortcutsEnabled = true;
            this.UserInput.Size = new System.Drawing.Size(250, 48);
            this.UserInput.TabIndex = 0;
            this.UserInput.TabStop = false;
            this.UserInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserInput.TrailingIcon = null;
            this.UserInput.UseSystemPasswordChar = false;
            // 
            // PageMods
            // 
            this.PageMods.Controls.Add(this.useMods);
            this.PageMods.Location = new System.Drawing.Point(4, 22);
            this.PageMods.Name = "PageMods";
            this.PageMods.Padding = new System.Windows.Forms.Padding(3);
            this.PageMods.Size = new System.Drawing.Size(786, 357);
            this.PageMods.TabIndex = 2;
            this.PageMods.Text = "Mods";
            this.PageMods.UseVisualStyleBackColor = true;
            // 
            // PageExtras
            // 
            this.PageExtras.Controls.Add(this.ForceClearData);
            this.PageExtras.Location = new System.Drawing.Point(4, 22);
            this.PageExtras.Name = "PageExtras";
            this.PageExtras.Padding = new System.Windows.Forms.Padding(3);
            this.PageExtras.Size = new System.Drawing.Size(786, 357);
            this.PageExtras.TabIndex = 3;
            this.PageExtras.Text = "Extras";
            this.PageExtras.UseVisualStyleBackColor = true;
            // 
            // useMods
            // 
            this.useMods.AutoSize = true;
            this.useMods.Depth = 0;
            this.useMods.Location = new System.Drawing.Point(7, 7);
            this.useMods.Margin = new System.Windows.Forms.Padding(0);
            this.useMods.MouseLocation = new System.Drawing.Point(-1, -1);
            this.useMods.MouseState = MaterialSkin.MouseState.HOVER;
            this.useMods.Name = "useMods";
            this.useMods.ReadOnly = false;
            this.useMods.Ripple = true;
            this.useMods.Size = new System.Drawing.Size(105, 37);
            this.useMods.TabIndex = 0;
            this.useMods.Text = "Use Mods";
            this.useMods.UseVisualStyleBackColor = true;
            this.useMods.CheckedChanged += new System.EventHandler(this.useMods_CheckedChanged);
            // 
            // ForceClearData
            // 
            this.ForceClearData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ForceClearData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ForceClearData.Depth = 0;
            this.ForceClearData.HighEmphasis = true;
            this.ForceClearData.Icon = null;
            this.ForceClearData.Location = new System.Drawing.Point(7, 7);
            this.ForceClearData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ForceClearData.MouseState = MaterialSkin.MouseState.HOVER;
            this.ForceClearData.Name = "ForceClearData";
            this.ForceClearData.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ForceClearData.Size = new System.Drawing.Size(232, 36);
            this.ForceClearData.TabIndex = 0;
            this.ForceClearData.Text = "Force Clear Tracking Data";
            this.ForceClearData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ForceClearData.UseAccentColor = false;
            this.ForceClearData.UseVisualStyleBackColor = true;
            this.ForceClearData.Click += new System.EventHandler(this.ForceClearData_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PWLauncher.Properties.Resources.pwSmall_removebg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(30, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(319, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(450, 250);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Custom Pixel Worlds launcher\r\nMade by @jed5729 (discord)\r\n\r\nFeatures:\r\n- Custom a" +
    "ccount manager\r\n- Mod manager (WIP)\r\n          - Only supports BepInEx\r\n- Force " +
    "clear tracking data from Kukouri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PW Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.PageLauncher.ResumeLayout(false);
            this.PageLauncher.PerformLayout();
            this.PageAccounts.ResumeLayout(false);
            this.PageAccounts.PerformLayout();
            this.PageMods.ResumeLayout(false);
            this.PageMods.PerformLayout();
            this.PageExtras.ResumeLayout(false);
            this.PageExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage PageLauncher;
        private System.Windows.Forms.TabPage PageAccounts;
        private MaterialSkin.Controls.MaterialButton StartPW;
        private System.Windows.Forms.TabPage PageMods;
        private System.Windows.Forms.TabPage PageExtras;
        private MaterialSkin.Controls.MaterialTextBox2 PassInput;
        private MaterialSkin.Controls.MaterialTextBox2 UserInput;
        private MaterialSkin.Controls.MaterialButton AddAccount;
        private MaterialSkin.Controls.MaterialListBox AccountList;
        private MaterialSkin.Controls.MaterialButton RemoveAccount;
        private MaterialSkin.Controls.MaterialCheckbox useMods;
        private MaterialSkin.Controls.MaterialButton ForceClearData;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

