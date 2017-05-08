namespace SourceCode
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanalLogin = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtUserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanalLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel
            // 
            this.bunifuCustomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel.AutoSize = true;
            this.bunifuCustomLabel.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel.Location = new System.Drawing.Point(198, 91);
            this.bunifuCustomLabel.Name = "bunifuCustomLabel";
            this.bunifuCustomLabel.Size = new System.Drawing.Size(801, 44);
            this.bunifuCustomLabel.TabIndex = 0;
            this.bunifuCustomLabel.Text = "Footbal Tournament Management";
            // 
            // PanalLogin
            // 
            this.PanalLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanalLogin.BackColor = System.Drawing.Color.White;
            this.PanalLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanalLogin.BackgroundImage")));
            this.PanalLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanalLogin.Controls.Add(this.btnExit);
            this.PanalLogin.Controls.Add(this.btnLogin);
            this.PanalLogin.Controls.Add(this.txtPassword);
            this.PanalLogin.Controls.Add(this.txtUserName);
            this.PanalLogin.Controls.Add(this.lblPassword);
            this.PanalLogin.Controls.Add(this.lblUserName);
            this.PanalLogin.GradientBottomLeft = System.Drawing.Color.White;
            this.PanalLogin.GradientBottomRight = System.Drawing.Color.White;
            this.PanalLogin.GradientTopLeft = System.Drawing.Color.White;
            this.PanalLogin.GradientTopRight = System.Drawing.Color.White;
            this.PanalLogin.Location = new System.Drawing.Point(249, 184);
            this.PanalLogin.Name = "PanalLogin";
            this.PanalLogin.Padding = new System.Windows.Forms.Padding(1);
            this.PanalLogin.Quality = 20;
            this.PanalLogin.Size = new System.Drawing.Size(678, 458);
            this.PanalLogin.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 1;
            this.btnExit.ActiveCornerRadius = 20;
            this.btnExit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnExit.ActiveForecolor = System.Drawing.Color.White;
            this.btnExit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleCornerRadius = 20;
            this.btnExit.IdleFillColor = System.Drawing.Color.White;
            this.btnExit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnExit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnExit.Location = new System.Drawing.Point(21, 357);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(619, 56);
            this.btnExit.TabIndex = 9;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.White;
            this.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(21, 270);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(619, 56);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(27, 196);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(613, 44);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BorderColorFocused = System.Drawing.Color.SeaGreen;
            this.txtUserName.BorderColorIdle = System.Drawing.Color.SeaGreen;
            this.txtUserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtUserName.isPassword = false;
            this.txtUserName.Location = new System.Drawing.Point(27, 74);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(613, 44);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPassword.Location = new System.Drawing.Point(23, 144);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblUserName.Location = new System.Drawing.Point(23, 24);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName\r\n";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.PanalLogin);
            this.Controls.Add(this.bunifuCustomLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.PanalLogin.ResumeLayout(false);
            this.PanalLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel PanalLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUserName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserName;
    }
}

