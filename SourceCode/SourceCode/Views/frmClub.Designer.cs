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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbTeamInfor = new System.Windows.Forms.GroupBox();
            this.btnUpdateTeamInfor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCoachInfor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaveTeamInfor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picLogoTeam = new System.Windows.Forms.PictureBox();
            this.txtStadiumName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCoach = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClubName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtClubID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grbTeamPlayer = new System.Windows.Forms.GroupBox();
            this.dgvTeamPlayer = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grouAllClub = new System.Windows.Forms.GroupBox();
            this.dgvListClubs = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadiumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderCoach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachNation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbCoachInformation = new System.Windows.Forms.GroupBox();
            this.dtpBirthday = new Bunifu.Framework.UI.BunifuDatepicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnCancelViewCoach = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdateCoachInfor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSaveCoachInfor = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNation = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCoachName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picViewCoach = new System.Windows.Forms.PictureBox();
            this.grbTeamInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTeam)).BeginInit();
            this.grbTeamPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayer)).BeginInit();
            this.grouAllClub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClubs)).BeginInit();
            this.grbCoachInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewCoach)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTeamInfor
            // 
            this.grbTeamInfor.BackColor = System.Drawing.Color.White;
            this.grbTeamInfor.Controls.Add(this.btnUpdateTeamInfor);
            this.grbTeamInfor.Controls.Add(this.btnCancel);
            this.grbTeamInfor.Controls.Add(this.btnCoachInfor);
            this.grbTeamInfor.Controls.Add(this.btnSaveTeamInfor);
            this.grbTeamInfor.Controls.Add(this.btnModify);
            this.grbTeamInfor.Controls.Add(this.btnExit);
            this.grbTeamInfor.Controls.Add(this.picLogoTeam);
            this.grbTeamInfor.Controls.Add(this.txtStadiumName);
            this.grbTeamInfor.Controls.Add(this.bunifuCustomLabel7);
            this.grbTeamInfor.Controls.Add(this.txtCoach);
            this.grbTeamInfor.Controls.Add(this.bunifuCustomLabel6);
            this.grbTeamInfor.Controls.Add(this.txtClubName);
            this.grbTeamInfor.Controls.Add(this.bunifuCustomLabel4);
            this.grbTeamInfor.Controls.Add(this.txtClubID);
            this.grbTeamInfor.Controls.Add(this.bunifuCustomLabel3);
            this.grbTeamInfor.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTeamInfor.ForeColor = System.Drawing.Color.SeaGreen;
            this.grbTeamInfor.Location = new System.Drawing.Point(2, 268);
            this.grbTeamInfor.Name = "grbTeamInfor";
            this.grbTeamInfor.Size = new System.Drawing.Size(1102, 297);
            this.grbTeamInfor.TabIndex = 4;
            this.grbTeamInfor.TabStop = false;
            this.grbTeamInfor.Text = "Club Information";
            // 
            // btnUpdateTeamInfor
            // 
            this.btnUpdateTeamInfor.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnUpdateTeamInfor.BackColor = System.Drawing.Color.SeaGreen;
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
            this.btnUpdateTeamInfor.Location = new System.Drawing.Point(417, 225);
            this.btnUpdateTeamInfor.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdateTeamInfor.Name = "btnUpdateTeamInfor";
            this.btnUpdateTeamInfor.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnUpdateTeamInfor.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdateTeamInfor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateTeamInfor.selected = true;
            this.btnUpdateTeamInfor.Size = new System.Drawing.Size(125, 63);
            this.btnUpdateTeamInfor.TabIndex = 34;
            this.btnUpdateTeamInfor.Text = "Update";
            this.btnUpdateTeamInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateTeamInfor.Textcolor = System.Drawing.Color.White;
            this.btnUpdateTeamInfor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeamInfor.Click += new System.EventHandler(this.btnUpdateTeamInfor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.Color.SeaGreen;
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
            this.btnCancel.Location = new System.Drawing.Point(771, 225);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(169, 63);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // btnSaveTeamInfor
            // 
            this.btnSaveTeamInfor.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnSaveTeamInfor.BackColor = System.Drawing.Color.SeaGreen;
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
            this.btnSaveTeamInfor.Location = new System.Drawing.Point(592, 225);
            this.btnSaveTeamInfor.Margin = new System.Windows.Forms.Padding(6);
            this.btnSaveTeamInfor.Name = "btnSaveTeamInfor";
            this.btnSaveTeamInfor.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnSaveTeamInfor.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveTeamInfor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSaveTeamInfor.selected = true;
            this.btnSaveTeamInfor.Size = new System.Drawing.Size(125, 63);
            this.btnSaveTeamInfor.TabIndex = 33;
            this.btnSaveTeamInfor.Text = "Save";
            this.btnSaveTeamInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveTeamInfor.Textcolor = System.Drawing.Color.White;
            this.btnSaveTeamInfor.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTeamInfor.Click += new System.EventHandler(this.btnSaveTeamInfor_Click);
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
            this.picLogoTeam.BackColor = System.Drawing.Color.White;
            this.picLogoTeam.Location = new System.Drawing.Point(18, 35);
            this.picLogoTeam.Name = "picLogoTeam";
            this.picLogoTeam.Size = new System.Drawing.Size(200, 200);
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
            // grbTeamPlayer
            // 
            this.grbTeamPlayer.BackColor = System.Drawing.Color.White;
            this.grbTeamPlayer.Controls.Add(this.dgvTeamPlayer);
            this.grbTeamPlayer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTeamPlayer.ForeColor = System.Drawing.Color.SeaGreen;
            this.grbTeamPlayer.Location = new System.Drawing.Point(3, 569);
            this.grbTeamPlayer.Name = "grbTeamPlayer";
            this.grbTeamPlayer.Size = new System.Drawing.Size(1102, 231);
            this.grbTeamPlayer.TabIndex = 6;
            this.grbTeamPlayer.TabStop = false;
            this.grbTeamPlayer.Text = "Team Players";
            // 
            // dgvTeamPlayer
            // 
            this.dgvTeamPlayer.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTeamPlayer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeamPlayer.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeamPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeamPlayer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeamPlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeamPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderingPlayer,
            this.PlayerName,
            this.Role,
            this.KitNum});
            this.dgvTeamPlayer.DoubleBuffered = true;
            this.dgvTeamPlayer.EnableHeadersVisualStyles = false;
            this.dgvTeamPlayer.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvTeamPlayer.HeaderBgColor = System.Drawing.Color.White;
            this.dgvTeamPlayer.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvTeamPlayer.Location = new System.Drawing.Point(3, 22);
            this.dgvTeamPlayer.Name = "dgvTeamPlayer";
            this.dgvTeamPlayer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvTeamPlayer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeamPlayer.RowTemplate.Height = 24;
            this.dgvTeamPlayer.Size = new System.Drawing.Size(1096, 209);
            this.dgvTeamPlayer.TabIndex = 0;
            // 
            // OrderingPlayer
            // 
            this.OrderingPlayer.DataPropertyName = "OrderingPlayer";
            this.OrderingPlayer.HeaderText = "Odering Number";
            this.OrderingPlayer.Name = "OrderingPlayer";
            // 
            // PlayerName
            // 
            this.PlayerName.DataPropertyName = "PlayerName";
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Width = 200;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "RoleName";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // KitNum
            // 
            this.KitNum.DataPropertyName = "KitNum";
            this.KitNum.HeaderText = "KitNum";
            this.KitNum.Name = "KitNum";
            // 
            // grouAllClub
            // 
            this.grouAllClub.BackColor = System.Drawing.Color.White;
            this.grouAllClub.Controls.Add(this.dgvListClubs);
            this.grouAllClub.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouAllClub.ForeColor = System.Drawing.Color.SeaGreen;
            this.grouAllClub.Location = new System.Drawing.Point(0, 0);
            this.grouAllClub.Name = "grouAllClub";
            this.grouAllClub.Size = new System.Drawing.Size(1104, 262);
            this.grouAllClub.TabIndex = 7;
            this.grouAllClub.TabStop = false;
            this.grouAllClub.Text = "List Clubs";
            // 
            // dgvListClubs
            // 
            this.dgvListClubs.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListClubs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListClubs.BackgroundColor = System.Drawing.Color.White;
            this.dgvListClubs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListClubs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListClubs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderingNumber,
            this.ClubID,
            this.ClubName,
            this.StadiumName,
            this.CoachName,
            this.Path,
            this.GenderCoach,
            this.CoachNation,
            this.CoachBirthday,
            this.CoachPath});
            this.dgvListClubs.DoubleBuffered = true;
            this.dgvListClubs.EnableHeadersVisualStyles = false;
            this.dgvListClubs.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvListClubs.HeaderBgColor = System.Drawing.Color.White;
            this.dgvListClubs.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvListClubs.Location = new System.Drawing.Point(3, 22);
            this.dgvListClubs.Name = "dgvListClubs";
            this.dgvListClubs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListClubs.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvListClubs.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListClubs.RowTemplate.Height = 24;
            this.dgvListClubs.Size = new System.Drawing.Size(1096, 234);
            this.dgvListClubs.TabIndex = 0;
            this.dgvListClubs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListClubs_CellClick);
            // 
            // OrderingNumber
            // 
            this.OrderingNumber.DataPropertyName = "OrderingNumber";
            this.OrderingNumber.HeaderText = "Ordering Number";
            this.OrderingNumber.Name = "OrderingNumber";
            // 
            // ClubID
            // 
            this.ClubID.DataPropertyName = "ClubID";
            this.ClubID.HeaderText = "Club ID";
            this.ClubID.Name = "ClubID";
            // 
            // ClubName
            // 
            this.ClubName.DataPropertyName = "ClubName";
            this.ClubName.HeaderText = "Club Name";
            this.ClubName.Name = "ClubName";
            this.ClubName.Width = 200;
            // 
            // StadiumName
            // 
            this.StadiumName.DataPropertyName = "StadiumName";
            this.StadiumName.HeaderText = "Stadium Name";
            this.StadiumName.Name = "StadiumName";
            this.StadiumName.Width = 200;
            // 
            // CoachName
            // 
            this.CoachName.DataPropertyName = "CoachName";
            this.CoachName.HeaderText = "Coach Name";
            this.CoachName.Name = "CoachName";
            this.CoachName.Width = 150;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "PathClub";
            this.Path.HeaderText = "PathClub";
            this.Path.Name = "Path";
            this.Path.Visible = false;
            // 
            // GenderCoach
            // 
            this.GenderCoach.DataPropertyName = "CoachGender";
            this.GenderCoach.HeaderText = "CoachGender";
            this.GenderCoach.Name = "GenderCoach";
            this.GenderCoach.Visible = false;
            // 
            // CoachNation
            // 
            this.CoachNation.DataPropertyName = "CoachNation";
            this.CoachNation.HeaderText = "Coach Nation";
            this.CoachNation.Name = "CoachNation";
            this.CoachNation.Visible = false;
            // 
            // CoachBirthday
            // 
            this.CoachBirthday.DataPropertyName = "CoachBirthday";
            this.CoachBirthday.HeaderText = "Coach Birthday";
            this.CoachBirthday.Name = "CoachBirthday";
            this.CoachBirthday.Visible = false;
            // 
            // CoachPath
            // 
            this.CoachPath.DataPropertyName = "CoachPath";
            this.CoachPath.HeaderText = "CoachPath";
            this.CoachPath.Name = "CoachPath";
            this.CoachPath.Visible = false;
            // 
            // grbCoachInformation
            // 
            this.grbCoachInformation.BackColor = System.Drawing.Color.White;
            this.grbCoachInformation.Controls.Add(this.dtpBirthday);
            this.grbCoachInformation.Controls.Add(this.cmbGender);
            this.grbCoachInformation.Controls.Add(this.btnCancelViewCoach);
            this.grbCoachInformation.Controls.Add(this.btnUpdateCoachInfor);
            this.grbCoachInformation.Controls.Add(this.btnSaveCoachInfor);
            this.grbCoachInformation.Controls.Add(this.bunifuCustomLabel1);
            this.grbCoachInformation.Controls.Add(this.txtNation);
            this.grbCoachInformation.Controls.Add(this.bunifuCustomLabel2);
            this.grbCoachInformation.Controls.Add(this.bunifuCustomLabel5);
            this.grbCoachInformation.Controls.Add(this.txtCoachName);
            this.grbCoachInformation.Controls.Add(this.bunifuCustomLabel8);
            this.grbCoachInformation.Controls.Add(this.picViewCoach);
            this.grbCoachInformation.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCoachInformation.ForeColor = System.Drawing.Color.SeaGreen;
            this.grbCoachInformation.Location = new System.Drawing.Point(1106, 0);
            this.grbCoachInformation.Name = "grbCoachInformation";
            this.grbCoachInformation.Size = new System.Drawing.Size(639, 772);
            this.grbCoachInformation.TabIndex = 8;
            this.grbCoachInformation.TabStop = false;
            this.grbCoachInformation.Text = "Coach Information";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.BackColor = System.Drawing.Color.White;
            this.dtpBirthday.BorderRadius = 0;
            this.dtpBirthday.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.ForeColor = System.Drawing.Color.SeaGreen;
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBirthday.FormatCustom = null;
            this.dtpBirthday.Location = new System.Drawing.Point(258, 246);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(268, 45);
            this.dtpBirthday.TabIndex = 81;
            this.dtpBirthday.Value = new System.DateTime(2017, 5, 1, 10, 35, 47, 69);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(141, 324);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(163, 30);
            this.cmbGender.TabIndex = 80;
            // 
            // btnCancelViewCoach
            // 
            this.btnCancelViewCoach.ActiveBorderThickness = 1;
            this.btnCancelViewCoach.ActiveCornerRadius = 20;
            this.btnCancelViewCoach.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelViewCoach.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelViewCoach.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancelViewCoach.BackColor = System.Drawing.Color.White;
            this.btnCancelViewCoach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelViewCoach.BackgroundImage")));
            this.btnCancelViewCoach.ButtonText = "Cancel";
            this.btnCancelViewCoach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelViewCoach.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelViewCoach.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancelViewCoach.IdleBorderThickness = 1;
            this.btnCancelViewCoach.IdleCornerRadius = 20;
            this.btnCancelViewCoach.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelViewCoach.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancelViewCoach.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancelViewCoach.Location = new System.Drawing.Point(66, 534);
            this.btnCancelViewCoach.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelViewCoach.Name = "btnCancelViewCoach";
            this.btnCancelViewCoach.Size = new System.Drawing.Size(384, 60);
            this.btnCancelViewCoach.TabIndex = 79;
            this.btnCancelViewCoach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelViewCoach.Click += new System.EventHandler(this.btnCancelViewCoach_Click);
            // 
            // btnUpdateCoachInfor
            // 
            this.btnUpdateCoachInfor.ActiveBorderThickness = 1;
            this.btnUpdateCoachInfor.ActiveCornerRadius = 20;
            this.btnUpdateCoachInfor.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdateCoachInfor.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdateCoachInfor.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateCoachInfor.BackColor = System.Drawing.Color.White;
            this.btnUpdateCoachInfor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCoachInfor.BackgroundImage")));
            this.btnUpdateCoachInfor.ButtonText = "Update";
            this.btnUpdateCoachInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCoachInfor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCoachInfor.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateCoachInfor.IdleBorderThickness = 1;
            this.btnUpdateCoachInfor.IdleCornerRadius = 20;
            this.btnUpdateCoachInfor.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdateCoachInfor.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnUpdateCoachInfor.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateCoachInfor.Location = new System.Drawing.Point(272, 455);
            this.btnUpdateCoachInfor.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateCoachInfor.Name = "btnUpdateCoachInfor";
            this.btnUpdateCoachInfor.Size = new System.Drawing.Size(178, 60);
            this.btnUpdateCoachInfor.TabIndex = 78;
            this.btnUpdateCoachInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateCoachInfor.Click += new System.EventHandler(this.btnUpdateCoachInfor_Click);
            // 
            // btnSaveCoachInfor
            // 
            this.btnSaveCoachInfor.ActiveBorderThickness = 1;
            this.btnSaveCoachInfor.ActiveCornerRadius = 20;
            this.btnSaveCoachInfor.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveCoachInfor.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveCoachInfor.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSaveCoachInfor.BackColor = System.Drawing.Color.White;
            this.btnSaveCoachInfor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCoachInfor.BackgroundImage")));
            this.btnSaveCoachInfor.ButtonText = "Save";
            this.btnSaveCoachInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCoachInfor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCoachInfor.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSaveCoachInfor.IdleBorderThickness = 1;
            this.btnSaveCoachInfor.IdleCornerRadius = 20;
            this.btnSaveCoachInfor.IdleFillColor = System.Drawing.Color.White;
            this.btnSaveCoachInfor.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSaveCoachInfor.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSaveCoachInfor.Location = new System.Drawing.Point(63, 455);
            this.btnSaveCoachInfor.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveCoachInfor.Name = "btnSaveCoachInfor";
            this.btnSaveCoachInfor.Size = new System.Drawing.Size(179, 60);
            this.btnSaveCoachInfor.TabIndex = 77;
            this.btnSaveCoachInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveCoachInfor.Click += new System.EventHandler(this.btnSaveCoachInfor_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 329);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 21);
            this.bunifuCustomLabel1.TabIndex = 76;
            this.bunifuCustomLabel1.Text = "Gender:";
            // 
            // txtNation
            // 
            this.txtNation.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNation.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtNation.Location = new System.Drawing.Point(143, 392);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(216, 28);
            this.txtNation.TabIndex = 75;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(29, 398);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(91, 21);
            this.bunifuCustomLabel2.TabIndex = 74;
            this.bunifuCustomLabel2.Text = "Nation:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(254, 212);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(117, 21);
            this.bunifuCustomLabel5.TabIndex = 73;
            this.bunifuCustomLabel5.Text = "Birthday: ";
            // 
            // txtCoachName
            // 
            this.txtCoachName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCoachName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoachName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtCoachName.Location = new System.Drawing.Point(258, 149);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(254, 28);
            this.txtCoachName.TabIndex = 72;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(254, 110);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(74, 21);
            this.bunifuCustomLabel8.TabIndex = 71;
            this.bunifuCustomLabel8.Text = "Name:";
            // 
            // picViewCoach
            // 
            this.picViewCoach.BackColor = System.Drawing.Color.White;
            this.picViewCoach.Location = new System.Drawing.Point(29, 76);
            this.picViewCoach.Name = "picViewCoach";
            this.picViewCoach.Size = new System.Drawing.Size(215, 215);
            this.picViewCoach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picViewCoach.TabIndex = 70;
            this.picViewCoach.TabStop = false;
            // 
            // frmClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 803);
            this.Controls.Add(this.grbCoachInformation);
            this.Controls.Add(this.grouAllClub);
            this.Controls.Add(this.grbTeamInfor);
            this.Controls.Add(this.grbTeamPlayer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClub";
            this.Text = "Club Management";
            this.Load += new System.EventHandler(this.frmTeam_Load);
            this.grbTeamInfor.ResumeLayout(false);
            this.grbTeamInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTeam)).EndInit();
            this.grbTeamPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayer)).EndInit();
            this.grouAllClub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClubs)).EndInit();
            this.grbCoachInformation.ResumeLayout(false);
            this.grbCoachInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewCoach)).EndInit();
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
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtClubName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtClubID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.GroupBox grbTeamPlayer;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTeamPlayer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCoachInfor;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveTeamInfor;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateTeamInfor;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.GroupBox grouAllClub;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvListClubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitNum;
        private System.Windows.Forms.GroupBox grbCoachInformation;
        private System.Windows.Forms.ComboBox cmbGender;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelViewCoach;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdateCoachInfor;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSaveCoachInfor;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNation;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCoachName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.PictureBox picViewCoach;
        private Bunifu.Framework.UI.BunifuDatepicker dtpBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadiumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderCoach;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachNation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachPath;
    }
}