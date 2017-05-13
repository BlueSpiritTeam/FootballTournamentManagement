namespace SourceCode
{
    partial class frmClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClub));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbTeamInfor = new System.Windows.Forms.GroupBox();
            this.btnCoachInfor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnModify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picLogoTeam = new System.Windows.Forms.PictureBox();
            this.txtStadiumName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCoach = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNumberPlayer = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClubName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClubID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grbSearchTeam = new System.Windows.Forms.GroupBox();
            this.btnSearchClub = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbSearchTeam = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSearchTeam = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.grbTeamPlayer = new System.Windows.Forms.GroupBox();
            this.dgvTeamPlayer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeletePlayerInClub = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveTeamInfor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateTeamInfor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.grbTeamInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTeam)).BeginInit();
            this.grbSearchTeam.SuspendLayout();
            this.grbTeamPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTeamInfor
            // 
            this.grbTeamInfor.BackColor = System.Drawing.Color.White;
            this.grbTeamInfor.Controls.Add(this.btnCoachInfor);
            this.grbTeamInfor.Controls.Add(this.btnModify);
            this.grbTeamInfor.Controls.Add(this.btnExit);
            this.grbTeamInfor.Controls.Add(this.picLogoTeam);
            this.grbTeamInfor.Controls.Add(this.txtStadiumName);
            this.grbTeamInfor.Controls.Add(this.bunifuCustomLabel7);
            this.grbTeamInfor.Controls.Add(this.txtCoach);
            this.grbTeamInfor.Controls.Add(this.bunifuCustomLabel6);
            this.grbTeamInfor.Controls.Add(this.txtNumberPlayer);
            this.grbTeamInfor.Controls.Add(this.bunifuCustomLabel5);
            this.grbTeamInfor.Controls.Add(this.txtClubName);
            this.grbTeamInfor.Controls.Add(this.bunifuCustomLabel4);
            this.grbTeamInfor.Controls.Add(this.txtClubID);
            this.grbTeamInfor.Controls.Add(this.bunifuCustomLabel3);
            this.grbTeamInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTeamInfor.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTeamInfor.ForeColor = System.Drawing.Color.SeaGreen;
            this.grbTeamInfor.Location = new System.Drawing.Point(0, 0);
            this.grbTeamInfor.Name = "grbTeamInfor";
            this.grbTeamInfor.Size = new System.Drawing.Size(1102, 274);
            this.grbTeamInfor.TabIndex = 4;
            this.grbTeamInfor.TabStop = false;
            this.grbTeamInfor.Text = "Club Information";
            // 
            // btnCoachInfor
            // 
            this.btnCoachInfor.ActiveBorderThickness = 1;
            this.btnCoachInfor.ActiveCornerRadius = 20;
            this.btnCoachInfor.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCoachInfor.ActiveForecolor = System.Drawing.Color.White;
            this.btnCoachInfor.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCoachInfor.BackColor = System.Drawing.Color.White;
            this.btnCoachInfor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoachInfor.BackgroundImage")));
            this.btnCoachInfor.ButtonText = "View Coach Information";
            this.btnCoachInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoachInfor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoachInfor.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCoachInfor.IdleBorderThickness = 1;
            this.btnCoachInfor.IdleCornerRadius = 20;
            this.btnCoachInfor.IdleFillColor = System.Drawing.Color.White;
            this.btnCoachInfor.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCoachInfor.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCoachInfor.Location = new System.Drawing.Point(707, 92);
            this.btnCoachInfor.Margin = new System.Windows.Forms.Padding(5);
            this.btnCoachInfor.Name = "btnCoachInfor";
            this.btnCoachInfor.Size = new System.Drawing.Size(290, 51);
            this.btnCoachInfor.TabIndex = 24;
            this.btnCoachInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCoachInfor.Click += new System.EventHandler(this.btnCoachInfor_Click);
            // 
            // btnModify
            // 
            this.btnModify.Activecolor = System.Drawing.Color.White;
            this.btnModify.BackColor = System.Drawing.Color.White;
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModify.BorderRadius = 3;
            this.btnModify.ButtonText = "Modifies";
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.DisabledColor = System.Drawing.Color.Gray;
            this.btnModify.Iconcolor = System.Drawing.Color.White;
            this.btnModify.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModify.Iconimage")));
            this.btnModify.Iconimage_right = null;
            this.btnModify.Iconimage_right_Selected = null;
            this.btnModify.Iconimage_Selected = null;
            this.btnModify.IconMarginLeft = 1;
            this.btnModify.IconMarginRight = 0;
            this.btnModify.IconRightVisible = false;
            this.btnModify.IconRightZoom = 0D;
            this.btnModify.IconVisible = true;
            this.btnModify.IconZoom = 90D;
            this.btnModify.IsTab = false;
            this.btnModify.Location = new System.Drawing.Point(719, 485);
            this.btnModify.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Normalcolor = System.Drawing.Color.White;
            this.btnModify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnModify.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnModify.selected = true;
            this.btnModify.Size = new System.Drawing.Size(348, 71);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modifies";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModify.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnModify.TextFont = new System.Drawing.Font("Source Sans Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.White;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 3;
            this.btnExit.ButtonText = "Cancel";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.White;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 1;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = false;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(719, 566);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.White;
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnExit.selected = true;
            this.btnExit.Size = new System.Drawing.Size(348, 71);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Cancel";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnExit.TextFont = new System.Drawing.Font("Source Sans Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // picLogoTeam
            // 
            this.picLogoTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picLogoTeam.Location = new System.Drawing.Point(18, 35);
            this.picLogoTeam.Name = "picLogoTeam";
            this.picLogoTeam.Size = new System.Drawing.Size(215, 215);
            this.picLogoTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoTeam.TabIndex = 12;
            this.picLogoTeam.TabStop = false;
            // 
            // txtStadiumName
            // 
            this.txtStadiumName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtStadiumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStadiumName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtStadiumName.Location = new System.Drawing.Point(436, 173);
            this.txtStadiumName.Name = "txtStadiumName";
            this.txtStadiumName.Size = new System.Drawing.Size(251, 28);
            this.txtStadiumName.TabIndex = 11;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(272, 177);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(147, 19);
            this.bunifuCustomLabel7.TabIndex = 10;
            this.bunifuCustomLabel7.Text = "Stadium Name:";
            // 
            // txtCoach
            // 
            this.txtCoach.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoach.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtCoach.Location = new System.Drawing.Point(360, 106);
            this.txtCoach.Name = "txtCoach";
            this.txtCoach.Size = new System.Drawing.Size(327, 28);
            this.txtCoach.TabIndex = 9;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(274, 114);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(76, 19);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "Coach:";
            // 
            // txtNumberPlayer
            // 
            this.txtNumberPlayer.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNumberPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberPlayer.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtNumberPlayer.Location = new System.Drawing.Point(920, 173);
            this.txtNumberPlayer.Name = "txtNumberPlayer";
            this.txtNumberPlayer.Size = new System.Drawing.Size(77, 28);
            this.txtNumberPlayer.TabIndex = 7;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(726, 177);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(172, 19);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "Number Players:";
            // 
            // txtClubName
            // 
            this.txtClubName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtClubName.Location = new System.Drawing.Point(707, 35);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.Size = new System.Drawing.Size(290, 28);
            this.txtClubName.TabIndex = 5;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(570, 39);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(118, 19);
            this.bunifuCustomLabel4.TabIndex = 4;
            this.bunifuCustomLabel4.Text = "Club Name:";
            // 
            // txtClubID
            // 
            this.txtClubID.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtClubID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClubID.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtClubID.Location = new System.Drawing.Point(360, 35);
            this.txtClubID.Name = "txtClubID";
            this.txtClubID.Size = new System.Drawing.Size(182, 28);
            this.txtClubID.TabIndex = 3;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(268, 39);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(86, 19);
            this.bunifuCustomLabel3.TabIndex = 1;
            this.bunifuCustomLabel3.Text = "Club ID:";
            // 
            // grbSearchTeam
            // 
            this.grbSearchTeam.BackColor = System.Drawing.Color.White;
            this.grbSearchTeam.Controls.Add(this.btnSearchClub);
            this.grbSearchTeam.Controls.Add(this.cmbSearchTeam);
            this.grbSearchTeam.Controls.Add(this.bunifuCustomLabel10);
            this.grbSearchTeam.Controls.Add(this.txtSearchTeam);
            this.grbSearchTeam.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearchTeam.ForeColor = System.Drawing.Color.SeaGreen;
            this.grbSearchTeam.Location = new System.Drawing.Point(0, 280);
            this.grbSearchTeam.Name = "grbSearchTeam";
            this.grbSearchTeam.Size = new System.Drawing.Size(542, 152);
            this.grbSearchTeam.TabIndex = 5;
            this.grbSearchTeam.TabStop = false;
            this.grbSearchTeam.Text = "Search";
            // 
            // btnSearchClub
            // 
            this.btnSearchClub.ActiveBorderThickness = 1;
            this.btnSearchClub.ActiveCornerRadius = 20;
            this.btnSearchClub.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSearchClub.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearchClub.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearchClub.BackColor = System.Drawing.Color.White;
            this.btnSearchClub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchClub.BackgroundImage")));
            this.btnSearchClub.ButtonText = "Search Club";
            this.btnSearchClub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClub.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClub.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearchClub.IdleBorderThickness = 1;
            this.btnSearchClub.IdleCornerRadius = 20;
            this.btnSearchClub.IdleFillColor = System.Drawing.Color.White;
            this.btnSearchClub.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSearchClub.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearchClub.Location = new System.Drawing.Point(66, 87);
            this.btnSearchClub.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchClub.Name = "btnSearchClub";
            this.btnSearchClub.Size = new System.Drawing.Size(333, 41);
            this.btnSearchClub.TabIndex = 23;
            this.btnSearchClub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSearchTeam
            // 
            this.cmbSearchTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchTeam.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmbSearchTeam.FormattingEnabled = true;
            this.cmbSearchTeam.Location = new System.Drawing.Point(345, 38);
            this.cmbSearchTeam.Name = "cmbSearchTeam";
            this.cmbSearchTeam.Size = new System.Drawing.Size(154, 30);
            this.cmbSearchTeam.TabIndex = 22;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(292, 43);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(34, 21);
            this.bunifuCustomLabel10.TabIndex = 21;
            this.bunifuCustomLabel10.Text = "by";
            // 
            // txtSearchTeam
            // 
            this.txtSearchTeam.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSearchTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTeam.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtSearchTeam.Location = new System.Drawing.Point(6, 37);
            this.txtSearchTeam.Name = "txtSearchTeam";
            this.txtSearchTeam.Size = new System.Drawing.Size(270, 28);
            this.txtSearchTeam.TabIndex = 20;
            // 
            // grbTeamPlayer
            // 
            this.grbTeamPlayer.BackColor = System.Drawing.Color.White;
            this.grbTeamPlayer.Controls.Add(this.dgvTeamPlayer);
            this.grbTeamPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbTeamPlayer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTeamPlayer.ForeColor = System.Drawing.Color.SeaGreen;
            this.grbTeamPlayer.Location = new System.Drawing.Point(0, 438);
            this.grbTeamPlayer.Name = "grbTeamPlayer";
            this.grbTeamPlayer.Size = new System.Drawing.Size(1102, 235);
            this.grbTeamPlayer.TabIndex = 6;
            this.grbTeamPlayer.TabStop = false;
            this.grbTeamPlayer.Text = "Team Players";
            // 
            // dgvTeamPlayer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTeamPlayer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeamPlayer.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeamPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeamPlayer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeamPlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeamPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderingNumber,
            this.PlayerID,
            this.PlayerName,
            this.Position,
            this.PlayerType,
            this.Note});
            this.dgvTeamPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamPlayer.DoubleBuffered = true;
            this.dgvTeamPlayer.EnableHeadersVisualStyles = false;
            this.dgvTeamPlayer.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvTeamPlayer.HeaderBgColor = System.Drawing.Color.White;
            this.dgvTeamPlayer.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvTeamPlayer.Location = new System.Drawing.Point(3, 22);
            this.dgvTeamPlayer.Name = "dgvTeamPlayer";
            this.dgvTeamPlayer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvTeamPlayer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeamPlayer.RowTemplate.Height = 24;
            this.dgvTeamPlayer.Size = new System.Drawing.Size(1096, 210);
            this.dgvTeamPlayer.TabIndex = 0;
            // 
            // OrderingNumber
            // 
            this.OrderingNumber.HeaderText = "Ordering Number";
            this.OrderingNumber.Name = "OrderingNumber";
            // 
            // PlayerID
            // 
            this.PlayerID.HeaderText = "Player ID";
            this.PlayerID.Name = "PlayerID";
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.Name = "PlayerName";
            // 
            // Position
            // 
            this.Position.HeaderText = "Posititon";
            this.Position.Name = "Position";
            // 
            // PlayerType
            // 
            this.PlayerType.HeaderText = "Player Type";
            this.PlayerType.Name = "PlayerType";
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            // 
            // btnDeletePlayerInClub
            // 
            this.btnDeletePlayerInClub.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnDeletePlayerInClub.BackColor = System.Drawing.Color.White;
            this.btnDeletePlayerInClub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletePlayerInClub.BorderRadius = 3;
            this.btnDeletePlayerInClub.ButtonText = "Delete Player In Club";
            this.btnDeletePlayerInClub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePlayerInClub.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnDeletePlayerInClub.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePlayerInClub.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDeletePlayerInClub.Iconcolor = System.Drawing.Color.White;
            this.btnDeletePlayerInClub.Iconimage = null;
            this.btnDeletePlayerInClub.Iconimage_right = null;
            this.btnDeletePlayerInClub.Iconimage_right_Selected = null;
            this.btnDeletePlayerInClub.Iconimage_Selected = null;
            this.btnDeletePlayerInClub.IconMarginLeft = 1;
            this.btnDeletePlayerInClub.IconMarginRight = 0;
            this.btnDeletePlayerInClub.IconRightVisible = false;
            this.btnDeletePlayerInClub.IconRightZoom = 0D;
            this.btnDeletePlayerInClub.IconVisible = true;
            this.btnDeletePlayerInClub.IconZoom = 90D;
            this.btnDeletePlayerInClub.IsTab = false;
            this.btnDeletePlayerInClub.Location = new System.Drawing.Point(610, 357);
            this.btnDeletePlayerInClub.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeletePlayerInClub.Name = "btnDeletePlayerInClub";
            this.btnDeletePlayerInClub.Normalcolor = System.Drawing.Color.White;
            this.btnDeletePlayerInClub.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnDeletePlayerInClub.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeletePlayerInClub.selected = true;
            this.btnDeletePlayerInClub.Size = new System.Drawing.Size(262, 63);
            this.btnDeletePlayerInClub.TabIndex = 32;
            this.btnDeletePlayerInClub.Text = "Delete Player In Club";
            this.btnDeletePlayerInClub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeletePlayerInClub.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnDeletePlayerInClub.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSaveTeamInfor
            // 
            this.btnSaveTeamInfor.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnSaveTeamInfor.BackColor = System.Drawing.Color.White;
            this.btnSaveTeamInfor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveTeamInfor.BorderRadius = 3;
            this.btnSaveTeamInfor.ButtonText = "Save";
            this.btnSaveTeamInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTeamInfor.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnSaveTeamInfor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTeamInfor.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaveTeamInfor.Iconcolor = System.Drawing.Color.White;
            this.btnSaveTeamInfor.Iconimage = null;
            this.btnSaveTeamInfor.Iconimage_right = null;
            this.btnSaveTeamInfor.Iconimage_right_Selected = null;
            this.btnSaveTeamInfor.Iconimage_Selected = null;
            this.btnSaveTeamInfor.IconMarginLeft = 1;
            this.btnSaveTeamInfor.IconMarginRight = 0;
            this.btnSaveTeamInfor.IconRightVisible = false;
            this.btnSaveTeamInfor.IconRightZoom = 0D;
            this.btnSaveTeamInfor.IconVisible = true;
            this.btnSaveTeamInfor.IconZoom = 90D;
            this.btnSaveTeamInfor.IsTab = false;
            this.btnSaveTeamInfor.Location = new System.Drawing.Point(610, 283);
            this.btnSaveTeamInfor.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveTeamInfor.Name = "btnSaveTeamInfor";
            this.btnSaveTeamInfor.Normalcolor = System.Drawing.Color.White;
            this.btnSaveTeamInfor.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnSaveTeamInfor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveTeamInfor.selected = true;
            this.btnSaveTeamInfor.Size = new System.Drawing.Size(125, 63);
            this.btnSaveTeamInfor.TabIndex = 33;
            this.btnSaveTeamInfor.Text = "Save";
            this.btnSaveTeamInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveTeamInfor.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnSaveTeamInfor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnUpdateTeamInfor
            // 
            this.btnUpdateTeamInfor.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnUpdateTeamInfor.BackColor = System.Drawing.Color.White;
            this.btnUpdateTeamInfor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateTeamInfor.BorderRadius = 3;
            this.btnUpdateTeamInfor.ButtonText = "Update";
            this.btnUpdateTeamInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateTeamInfor.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateTeamInfor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeamInfor.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateTeamInfor.Iconcolor = System.Drawing.Color.White;
            this.btnUpdateTeamInfor.Iconimage = null;
            this.btnUpdateTeamInfor.Iconimage_right = null;
            this.btnUpdateTeamInfor.Iconimage_right_Selected = null;
            this.btnUpdateTeamInfor.Iconimage_Selected = null;
            this.btnUpdateTeamInfor.IconMarginLeft = 1;
            this.btnUpdateTeamInfor.IconMarginRight = 0;
            this.btnUpdateTeamInfor.IconRightVisible = false;
            this.btnUpdateTeamInfor.IconRightZoom = 0D;
            this.btnUpdateTeamInfor.IconVisible = true;
            this.btnUpdateTeamInfor.IconZoom = 90D;
            this.btnUpdateTeamInfor.IsTab = false;
            this.btnUpdateTeamInfor.Location = new System.Drawing.Point(747, 283);
            this.btnUpdateTeamInfor.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateTeamInfor.Name = "btnUpdateTeamInfor";
            this.btnUpdateTeamInfor.Normalcolor = System.Drawing.Color.White;
            this.btnUpdateTeamInfor.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnUpdateTeamInfor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateTeamInfor.selected = true;
            this.btnUpdateTeamInfor.Size = new System.Drawing.Size(125, 63);
            this.btnUpdateTeamInfor.TabIndex = 34;
            this.btnUpdateTeamInfor.Text = "Update";
            this.btnUpdateTeamInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateTeamInfor.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnUpdateTeamInfor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeamInfor.Click += new System.EventHandler(this.btnUpdateTeamInfor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 3;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Iconcolor = System.Drawing.Color.White;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 1;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = false;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(898, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.White;
            this.btnCancel.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(169, 78);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 673);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateTeamInfor);
            this.Controls.Add(this.btnSaveTeamInfor);
            this.Controls.Add(this.btnDeletePlayerInClub);
            this.Controls.Add(this.grbTeamPlayer);
            this.Controls.Add(this.grbSearchTeam);
            this.Controls.Add(this.grbTeamInfor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Management";
            this.Load += new System.EventHandler(this.frmTeam_Load);
            this.grbTeamInfor.ResumeLayout(false);
            this.grbTeamInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTeam)).EndInit();
            this.grbSearchTeam.ResumeLayout(false);
            this.grbSearchTeam.PerformLayout();
            this.grbTeamPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTeamInfor;
        private Bunifu.Framework.UI.BunifuFlatButton btnModify;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private System.Windows.Forms.PictureBox picLogoTeam;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtStadiumName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCoach;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNumberPlayer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtClubName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtClubID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.GroupBox grbSearchTeam;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchClub;
        private System.Windows.Forms.ComboBox cmbSearchTeam;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSearchTeam;
        private System.Windows.Forms.GroupBox grbTeamPlayer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTeamPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCoachInfor;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeletePlayerInClub;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveTeamInfor;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateTeamInfor;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
    }
}