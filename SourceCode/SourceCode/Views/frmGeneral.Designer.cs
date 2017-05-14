﻿namespace SourceCode
{
    partial class frmGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneral));
            this.pnlGeneralContent = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnLogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picGeneralContent = new System.Windows.Forms.PictureBox();
            this.btnClub = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlGeneral = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSetting = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTournamentReport = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPlayerManagement = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTournamentManagement = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnRegister = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlGeneralContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGeneralContent)).BeginInit();
            this.pnlGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGeneralContent
            // 
            this.pnlGeneralContent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGeneralContent.BackgroundImage")));
            this.pnlGeneralContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGeneralContent.Controls.Add(this.btnLogout);
            this.pnlGeneralContent.Controls.Add(this.bunifuCustomLabel);
            this.pnlGeneralContent.Controls.Add(this.picGeneralContent);
            this.pnlGeneralContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGeneralContent.GradientBottomLeft = System.Drawing.Color.SeaGreen;
            this.pnlGeneralContent.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.pnlGeneralContent.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.pnlGeneralContent.GradientTopRight = System.Drawing.Color.SeaGreen;
            this.pnlGeneralContent.Location = new System.Drawing.Point(0, 0);
            this.pnlGeneralContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGeneralContent.Name = "pnlGeneralContent";
            this.pnlGeneralContent.Quality = 10;
            this.pnlGeneralContent.Size = new System.Drawing.Size(181, 544);
            this.pnlGeneralContent.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Activecolor = System.Drawing.Color.White;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.BorderRadius = 3;
            this.btnLogout.ButtonText = "Log Out";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogout.Iconcolor = System.Drawing.Color.White;
            this.btnLogout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogout.Iconimage")));
            this.btnLogout.Iconimage_right = null;
            this.btnLogout.Iconimage_right_Selected = null;
            this.btnLogout.Iconimage_Selected = null;
            this.btnLogout.IconMarginLeft = 1;
            this.btnLogout.IconMarginRight = 0;
            this.btnLogout.IconRightVisible = false;
            this.btnLogout.IconRightZoom = 0D;
            this.btnLogout.IconVisible = true;
            this.btnLogout.IconZoom = 90D;
            this.btnLogout.IsTab = false;
            this.btnLogout.Location = new System.Drawing.Point(4, 467);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Normalcolor = System.Drawing.Color.White;
            this.btnLogout.OnHovercolor = System.Drawing.Color.Lime;
            this.btnLogout.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnLogout.selected = true;
            this.btnLogout.Size = new System.Drawing.Size(174, 65);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogout.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnLogout.TextFont = new System.Drawing.Font("Source Sans Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // bunifuCustomLabel
            // 
            this.bunifuCustomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel.AutoSize = true;
            this.bunifuCustomLabel.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel.Location = new System.Drawing.Point(2, 181);
            this.bunifuCustomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel.Name = "bunifuCustomLabel";
            this.bunifuCustomLabel.Size = new System.Drawing.Size(229, 44);
            this.bunifuCustomLabel.TabIndex = 5;
            this.bunifuCustomLabel.Text = "Function";
            // 
            // picGeneralContent
            // 
            this.picGeneralContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picGeneralContent.BackColor = System.Drawing.Color.SeaGreen;
            this.picGeneralContent.Image = ((System.Drawing.Image)(resources.GetObject("picGeneralContent.Image")));
            this.picGeneralContent.Location = new System.Drawing.Point(48, 46);
            this.picGeneralContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picGeneralContent.Name = "picGeneralContent";
            this.picGeneralContent.Size = new System.Drawing.Size(100, 111);
            this.picGeneralContent.TabIndex = 0;
            this.picGeneralContent.TabStop = false;
            // 
            // btnClub
            // 
            this.btnClub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClub.BackColor = System.Drawing.Color.SeaGreen;
            this.btnClub.color = System.Drawing.Color.SeaGreen;
            this.btnClub.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnClub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClub.ForeColor = System.Drawing.Color.White;
            this.btnClub.Image = ((System.Drawing.Image)(resources.GetObject("btnClub.Image")));
            this.btnClub.ImagePosition = 14;
            this.btnClub.ImageZoom = 50;
            this.btnClub.LabelPosition = 30;
            this.btnClub.LabelText = "Club Management";
            this.btnClub.Location = new System.Drawing.Point(79, 186);
            this.btnClub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClub.Name = "btnClub";
            this.btnClub.Size = new System.Drawing.Size(244, 163);
            this.btnClub.TabIndex = 1;
            this.btnClub.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGeneral.BackgroundImage")));
            this.pnlGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGeneral.Controls.Add(this.btnSetting);
            this.pnlGeneral.Controls.Add(this.btnTournamentReport);
            this.pnlGeneral.Controls.Add(this.btnPlayerManagement);
            this.pnlGeneral.Controls.Add(this.btnTournamentManagement);
            this.pnlGeneral.Controls.Add(this.btnRegister);
            this.pnlGeneral.Controls.Add(this.btnClub);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlGeneral.GradientBottomRight = System.Drawing.Color.White;
            this.pnlGeneral.GradientTopLeft = System.Drawing.Color.White;
            this.pnlGeneral.GradientTopRight = System.Drawing.Color.White;
            this.pnlGeneral.Location = new System.Drawing.Point(181, 0);
            this.pnlGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Quality = 10;
            this.pnlGeneral.Size = new System.Drawing.Size(643, 544);
            this.pnlGeneral.TabIndex = 1;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSetting.color = System.Drawing.Color.SeaGreen;
            this.btnSetting.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImagePosition = 14;
            this.btnSetting.ImageZoom = 50;
            this.btnSetting.LabelPosition = 30;
            this.btnSetting.LabelText = "Setting";
            this.btnSetting.Location = new System.Drawing.Point(332, 356);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(244, 163);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnTournamentReport
            // 
            this.btnTournamentReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTournamentReport.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTournamentReport.color = System.Drawing.Color.SeaGreen;
            this.btnTournamentReport.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnTournamentReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTournamentReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTournamentReport.ForeColor = System.Drawing.Color.White;
            this.btnTournamentReport.Image = ((System.Drawing.Image)(resources.GetObject("btnTournamentReport.Image")));
            this.btnTournamentReport.ImagePosition = 14;
            this.btnTournamentReport.ImageZoom = 50;
            this.btnTournamentReport.LabelPosition = 30;
            this.btnTournamentReport.LabelText = "Tournament Report";
            this.btnTournamentReport.Location = new System.Drawing.Point(79, 356);
            this.btnTournamentReport.Name = "btnTournamentReport";
            this.btnTournamentReport.Size = new System.Drawing.Size(244, 163);
            this.btnTournamentReport.TabIndex = 5;
            this.btnTournamentReport.Click += new System.EventHandler(this.btnTournamentReport_Click);
            // 
            // btnPlayerManagement
            // 
            this.btnPlayerManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlayerManagement.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPlayerManagement.color = System.Drawing.Color.SeaGreen;
            this.btnPlayerManagement.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnPlayerManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerManagement.ForeColor = System.Drawing.Color.White;
            this.btnPlayerManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayerManagement.Image")));
            this.btnPlayerManagement.ImagePosition = 14;
            this.btnPlayerManagement.ImageZoom = 50;
            this.btnPlayerManagement.LabelPosition = 30;
            this.btnPlayerManagement.LabelText = "Player Management";
            this.btnPlayerManagement.Location = new System.Drawing.Point(332, 186);
            this.btnPlayerManagement.Name = "btnPlayerManagement";
            this.btnPlayerManagement.Size = new System.Drawing.Size(244, 163);
            this.btnPlayerManagement.TabIndex = 4;
            this.btnPlayerManagement.Click += new System.EventHandler(this.btnPlayerManagement_Click);
            // 
            // btnTournamentManagement
            // 
            this.btnTournamentManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTournamentManagement.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTournamentManagement.color = System.Drawing.Color.SeaGreen;
            this.btnTournamentManagement.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnTournamentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTournamentManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTournamentManagement.ForeColor = System.Drawing.Color.White;
            this.btnTournamentManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnTournamentManagement.Image")));
            this.btnTournamentManagement.ImagePosition = 14;
            this.btnTournamentManagement.ImageZoom = 50;
            this.btnTournamentManagement.LabelPosition = 30;
            this.btnTournamentManagement.LabelText = "Tournament Management";
            this.btnTournamentManagement.Location = new System.Drawing.Point(332, 16);
            this.btnTournamentManagement.Name = "btnTournamentManagement";
            this.btnTournamentManagement.Size = new System.Drawing.Size(244, 163);
            this.btnTournamentManagement.TabIndex = 3;
            this.btnTournamentManagement.Click += new System.EventHandler(this.btnTournamentManagement_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRegister.color = System.Drawing.Color.SeaGreen;
            this.btnRegister.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImagePosition = 14;
            this.btnRegister.ImageZoom = 50;
            this.btnRegister.LabelPosition = 30;
            this.btnRegister.LabelText = "Register";
            this.btnRegister.Location = new System.Drawing.Point(79, 16);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(244, 163);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 544);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.pnlGeneralContent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.frmGeneral_Load);
            this.pnlGeneralContent.ResumeLayout(false);
            this.pnlGeneralContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGeneralContent)).EndInit();
            this.pnlGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlGeneralContent;
        private System.Windows.Forms.PictureBox picGeneralContent;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogout;
        private Bunifu.Framework.UI.BunifuTileButton btnClub;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlGeneral;
        private Bunifu.Framework.UI.BunifuTileButton btnRegister;
        private Bunifu.Framework.UI.BunifuTileButton btnSetting;
        private Bunifu.Framework.UI.BunifuTileButton btnTournamentReport;
        private Bunifu.Framework.UI.BunifuTileButton btnPlayerManagement;
        private Bunifu.Framework.UI.BunifuTileButton btnTournamentManagement;
    }
}