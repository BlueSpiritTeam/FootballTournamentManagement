namespace SourceCode
{
    partial class frmNewTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTournament));
            this.pnlTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picCreateSchedule = new System.Windows.Forms.PictureBox();
            this.grbCreateTournament = new System.Windows.Forms.GroupBox();
            this.chkCreateNewTournament = new System.Windows.Forms.CheckBox();
            this.chkTeamList = new System.Windows.Forms.CheckBox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCreateNewTournament = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).BeginInit();
            this.grbCreateTournament.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitle.Controls.Add(this.bunifuCustomLabel);
            this.pnlTitle.Controls.Add(this.picCreateSchedule);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlTitle.GradientBottomRight = System.Drawing.Color.White;
            this.pnlTitle.GradientTopLeft = System.Drawing.Color.White;
            this.pnlTitle.GradientTopRight = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Quality = 10;
            this.pnlTitle.Size = new System.Drawing.Size(711, 100);
            this.pnlTitle.TabIndex = 0;
            // 
            // bunifuCustomLabel
            // 
            this.bunifuCustomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel.AutoSize = true;
            this.bunifuCustomLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel.Location = new System.Drawing.Point(71, 32);
            this.bunifuCustomLabel.Name = "bunifuCustomLabel";
            this.bunifuCustomLabel.Size = new System.Drawing.Size(584, 44);
            this.bunifuCustomLabel.TabIndex = 58;
            this.bunifuCustomLabel.Text = "Create New Tournament";
            // 
            // picCreateSchedule
            // 
            this.picCreateSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.picCreateSchedule.Image = ((System.Drawing.Image)(resources.GetObject("picCreateSchedule.Image")));
            this.picCreateSchedule.Location = new System.Drawing.Point(9, 19);
            this.picCreateSchedule.Name = "picCreateSchedule";
            this.picCreateSchedule.Size = new System.Drawing.Size(55, 57);
            this.picCreateSchedule.TabIndex = 57;
            this.picCreateSchedule.TabStop = false;
            // 
            // grbCreateTournament
            // 
            this.grbCreateTournament.Controls.Add(this.chkCreateNewTournament);
            this.grbCreateTournament.Controls.Add(this.chkTeamList);
            this.grbCreateTournament.Controls.Add(this.btnCancel);
            this.grbCreateTournament.Controls.Add(this.btnCreateNewTournament);
            this.grbCreateTournament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCreateTournament.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCreateTournament.ForeColor = System.Drawing.Color.SeaGreen;
            this.grbCreateTournament.Location = new System.Drawing.Point(0, 100);
            this.grbCreateTournament.Name = "grbCreateTournament";
            this.grbCreateTournament.Size = new System.Drawing.Size(711, 312);
            this.grbCreateTournament.TabIndex = 1;
            this.grbCreateTournament.TabStop = false;
            this.grbCreateTournament.Text = "Select the information to re-create the tournament";
            // 
            // chkCreateNewTournament
            // 
            this.chkCreateNewTournament.AutoSize = true;
            this.chkCreateNewTournament.BackColor = System.Drawing.Color.SeaGreen;
            this.chkCreateNewTournament.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreateNewTournament.ForeColor = System.Drawing.Color.White;
            this.chkCreateNewTournament.Location = new System.Drawing.Point(135, 122);
            this.chkCreateNewTournament.Name = "chkCreateNewTournament";
            this.chkCreateNewTournament.Size = new System.Drawing.Size(399, 44);
            this.chkCreateNewTournament.TabIndex = 64;
            this.chkCreateNewTournament.Text = "Match Schedule, Goal";
            this.chkCreateNewTournament.UseVisualStyleBackColor = false;
            // 
            // chkTeamList
            // 
            this.chkTeamList.AutoSize = true;
            this.chkTeamList.BackColor = System.Drawing.Color.SeaGreen;
            this.chkTeamList.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTeamList.ForeColor = System.Drawing.Color.White;
            this.chkTeamList.Location = new System.Drawing.Point(135, 44);
            this.chkTeamList.Name = "chkTeamList";
            this.chkTeamList.Size = new System.Drawing.Size(180, 44);
            this.chkTeamList.TabIndex = 63;
            this.chkTeamList.Text = "Team List";
            this.chkTeamList.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(354, 185);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(223, 70);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateNewTournament
            // 
            this.btnCreateNewTournament.ActiveBorderThickness = 1;
            this.btnCreateNewTournament.ActiveCornerRadius = 20;
            this.btnCreateNewTournament.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCreateNewTournament.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreateNewTournament.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreateNewTournament.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateNewTournament.BackColor = System.Drawing.Color.White;
            this.btnCreateNewTournament.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateNewTournament.BackgroundImage")));
            this.btnCreateNewTournament.ButtonText = "Create New Tournament";
            this.btnCreateNewTournament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNewTournament.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewTournament.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCreateNewTournament.IdleBorderThickness = 1;
            this.btnCreateNewTournament.IdleCornerRadius = 20;
            this.btnCreateNewTournament.IdleFillColor = System.Drawing.Color.White;
            this.btnCreateNewTournament.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCreateNewTournament.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreateNewTournament.Location = new System.Drawing.Point(96, 185);
            this.btnCreateNewTournament.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateNewTournament.Name = "btnCreateNewTournament";
            this.btnCreateNewTournament.Size = new System.Drawing.Size(223, 70);
            this.btnCreateNewTournament.TabIndex = 61;
            this.btnCreateNewTournament.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNewTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 412);
            this.Controls.Add(this.grbCreateTournament);
            this.Controls.Add(this.pnlTitle);
            this.MinimizeBox = false;
            this.Name = "frmNewTournament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create A New Tournament";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).EndInit();
            this.grbCreateTournament.ResumeLayout(false);
            this.grbCreateTournament.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private System.Windows.Forms.PictureBox picCreateSchedule;
        private System.Windows.Forms.GroupBox grbCreateTournament;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreateNewTournament;
        private System.Windows.Forms.CheckBox chkCreateNewTournament;
        private System.Windows.Forms.CheckBox chkTeamList;
    }
}