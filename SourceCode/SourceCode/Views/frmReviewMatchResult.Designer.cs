namespace SourceCode
{
    partial class frmReviewMatchResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReviewMatchResult));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picCreateSchedule = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbClub = new System.Windows.Forms.ComboBox();
            this.dgvReviewMatch = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtHomeClubName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtAwayClubName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMatchDate = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMatchTime = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtStadium = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pnlMatchResult = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtRatio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLoadAll = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviewMatch)).BeginInit();
            this.pnlMatchResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel
            // 
            this.bunifuCustomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel.AutoSize = true;
            this.bunifuCustomLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel.Location = new System.Drawing.Point(145, 22);
            this.bunifuCustomLabel.Name = "bunifuCustomLabel";
            this.bunifuCustomLabel.Size = new System.Drawing.Size(504, 44);
            this.bunifuCustomLabel.TabIndex = 60;
            this.bunifuCustomLabel.Text = "Review Match Result";
            // 
            // picCreateSchedule
            // 
            this.picCreateSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.picCreateSchedule.Image = ((System.Drawing.Image)(resources.GetObject("picCreateSchedule.Image")));
            this.picCreateSchedule.Location = new System.Drawing.Point(83, 9);
            this.picCreateSchedule.Name = "picCreateSchedule";
            this.picCreateSchedule.Size = new System.Drawing.Size(55, 57);
            this.picCreateSchedule.TabIndex = 59;
            this.picCreateSchedule.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitle.BackgroundImage")));
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitle.Controls.Add(this.btnLoadAll);
            this.pnlTitle.Controls.Add(this.bunifuCustomLabel1);
            this.pnlTitle.Controls.Add(this.cmbClub);
            this.pnlTitle.Controls.Add(this.dgvReviewMatch);
            this.pnlTitle.Controls.Add(this.bunifuCustomLabel);
            this.pnlTitle.Controls.Add(this.picCreateSchedule);
            this.pnlTitle.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlTitle.GradientBottomRight = System.Drawing.Color.White;
            this.pnlTitle.GradientTopLeft = System.Drawing.Color.White;
            this.pnlTitle.GradientTopRight = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Quality = 10;
            this.pnlTitle.Size = new System.Drawing.Size(833, 440);
            this.pnlTitle.TabIndex = 56;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(113, 97);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(150, 21);
            this.bunifuCustomLabel1.TabIndex = 63;
            this.bunifuCustomLabel1.Text = "Choose Club";
            // 
            // cmbClub
            // 
            this.cmbClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClub.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmbClub.FormattingEnabled = true;
            this.cmbClub.Location = new System.Drawing.Point(290, 90);
            this.cmbClub.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClub.Name = "cmbClub";
            this.cmbClub.Size = new System.Drawing.Size(203, 33);
            this.cmbClub.TabIndex = 62;
            this.cmbClub.SelectedIndexChanged += new System.EventHandler(this.cmbClub_SelectedIndexChanged);
            // 
            // dgvReviewMatch
            // 
            this.dgvReviewMatch.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReviewMatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReviewMatch.BackgroundColor = System.Drawing.Color.White;
            this.dgvReviewMatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReviewMatch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReviewMatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReviewMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReviewMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderingPlayer,
            this.HomeClub,
            this.AwayClub,
            this.Ratio,
            this.Date,
            this.Time,
            this.Stadium});
            this.dgvReviewMatch.DoubleBuffered = true;
            this.dgvReviewMatch.EnableHeadersVisualStyles = false;
            this.dgvReviewMatch.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvReviewMatch.HeaderBgColor = System.Drawing.Color.White;
            this.dgvReviewMatch.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvReviewMatch.Location = new System.Drawing.Point(0, 149);
            this.dgvReviewMatch.MultiSelect = false;
            this.dgvReviewMatch.Name = "dgvReviewMatch";
            this.dgvReviewMatch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvReviewMatch.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvReviewMatch.RowTemplate.Height = 24;
            this.dgvReviewMatch.Size = new System.Drawing.Size(833, 288);
            this.dgvReviewMatch.TabIndex = 61;
            // 
            // OrderingPlayer
            // 
            this.OrderingPlayer.DataPropertyName = "OrderingNumber";
            this.OrderingPlayer.HeaderText = "Odering Number";
            this.OrderingPlayer.Name = "OrderingPlayer";
            // 
            // HomeClub
            // 
            this.HomeClub.DataPropertyName = "Home";
            this.HomeClub.HeaderText = "Home Club";
            this.HomeClub.Name = "HomeClub";
            // 
            // AwayClub
            // 
            this.AwayClub.DataPropertyName = "Away";
            this.AwayClub.HeaderText = "Away Club";
            this.AwayClub.Name = "AwayClub";
            // 
            // Ratio
            // 
            this.Ratio.DataPropertyName = "Ratio";
            this.Ratio.HeaderText = "Ratio";
            this.Ratio.Name = "Ratio";
            this.Ratio.Width = 70;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // Stadium
            // 
            this.Stadium.DataPropertyName = "Stadium";
            this.Stadium.HeaderText = "Stadium";
            this.Stadium.Name = "Stadium";
            this.Stadium.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(290, 198);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 41);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtHomeClubName
            // 
            this.txtHomeClubName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtHomeClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeClubName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtHomeClubName.Location = new System.Drawing.Point(26, 75);
            this.txtHomeClubName.Name = "txtHomeClubName";
            this.txtHomeClubName.Size = new System.Drawing.Size(216, 28);
            this.txtHomeClubName.TabIndex = 9;
            // 
            // txtAwayClubName
            // 
            this.txtAwayClubName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtAwayClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAwayClubName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtAwayClubName.Location = new System.Drawing.Point(485, 75);
            this.txtAwayClubName.Name = "txtAwayClubName";
            this.txtAwayClubName.Size = new System.Drawing.Size(219, 28);
            this.txtAwayClubName.TabIndex = 13;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(26, 140);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(68, 21);
            this.bunifuCustomLabel8.TabIndex = 16;
            this.bunifuCustomLabel8.Text = "Date:";
            // 
            // txtMatchDate
            // 
            this.txtMatchDate.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMatchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtMatchDate.Location = new System.Drawing.Point(112, 135);
            this.txtMatchDate.Name = "txtMatchDate";
            this.txtMatchDate.Size = new System.Drawing.Size(119, 28);
            this.txtMatchDate.TabIndex = 17;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(255, 140);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(63, 21);
            this.bunifuCustomLabel7.TabIndex = 18;
            this.bunifuCustomLabel7.Text = "Time:";
            // 
            // txtMatchTime
            // 
            this.txtMatchTime.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatchTime.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtMatchTime.Location = new System.Drawing.Point(343, 135);
            this.txtMatchTime.Name = "txtMatchTime";
            this.txtMatchTime.Size = new System.Drawing.Size(105, 28);
            this.txtMatchTime.TabIndex = 19;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(481, 142);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(102, 21);
            this.bunifuCustomLabel9.TabIndex = 20;
            this.bunifuCustomLabel9.Text = "Stadium:";
            // 
            // txtStadium
            // 
            this.txtStadium.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtStadium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStadium.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtStadium.Location = new System.Drawing.Point(613, 137);
            this.txtStadium.Name = "txtStadium";
            this.txtStadium.Size = new System.Drawing.Size(187, 28);
            this.txtStadium.TabIndex = 21;
            // 
            // pnlMatchResult
            // 
            this.pnlMatchResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMatchResult.BackgroundImage")));
            this.pnlMatchResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMatchResult.Controls.Add(this.btnCancel);
            this.pnlMatchResult.Controls.Add(this.txtRatio);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel5);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel4);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel2);
            this.pnlMatchResult.Controls.Add(this.txtStadium);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel9);
            this.pnlMatchResult.Controls.Add(this.txtMatchTime);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel7);
            this.pnlMatchResult.Controls.Add(this.txtMatchDate);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel8);
            this.pnlMatchResult.Controls.Add(this.txtAwayClubName);
            this.pnlMatchResult.Controls.Add(this.txtHomeClubName);
            this.pnlMatchResult.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlMatchResult.GradientBottomRight = System.Drawing.Color.White;
            this.pnlMatchResult.GradientTopLeft = System.Drawing.Color.White;
            this.pnlMatchResult.GradientTopRight = System.Drawing.Color.White;
            this.pnlMatchResult.Location = new System.Drawing.Point(0, 446);
            this.pnlMatchResult.Name = "pnlMatchResult";
            this.pnlMatchResult.Quality = 10;
            this.pnlMatchResult.Size = new System.Drawing.Size(833, 253);
            this.pnlMatchResult.TabIndex = 57;
            // 
            // txtRatio
            // 
            this.txtRatio.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRatio.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtRatio.Location = new System.Drawing.Point(279, 75);
            this.txtRatio.Name = "txtRatio";
            this.txtRatio.Size = new System.Drawing.Size(150, 28);
            this.txtRatio.TabIndex = 64;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(546, 34);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(125, 21);
            this.bunifuCustomLabel5.TabIndex = 63;
            this.bunifuCustomLabel5.Text = "Away Club";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(322, 34);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 21);
            this.bunifuCustomLabel4.TabIndex = 62;
            this.bunifuCustomLabel4.Text = "Ratio";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(79, 34);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(126, 21);
            this.bunifuCustomLabel2.TabIndex = 61;
            this.bunifuCustomLabel2.Text = "Home Club";
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.ActiveBorderThickness = 1;
            this.btnLoadAll.ActiveCornerRadius = 20;
            this.btnLoadAll.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLoadAll.ActiveForecolor = System.Drawing.Color.White;
            this.btnLoadAll.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLoadAll.BackColor = System.Drawing.Color.White;
            this.btnLoadAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadAll.BackgroundImage")));
            this.btnLoadAll.ButtonText = "Load all Result";
            this.btnLoadAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAll.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLoadAll.IdleBorderThickness = 1;
            this.btnLoadAll.IdleCornerRadius = 20;
            this.btnLoadAll.IdleFillColor = System.Drawing.Color.White;
            this.btnLoadAll.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLoadAll.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLoadAll.Location = new System.Drawing.Point(550, 72);
            this.btnLoadAll.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(205, 59);
            this.btnLoadAll.TabIndex = 64;
            this.btnLoadAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // frmReviewMatchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 699);
            this.Controls.Add(this.pnlMatchResult);
            this.Controls.Add(this.pnlTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReviewMatchResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Match Result";
            this.Load += new System.EventHandler(this.frmReviewMatchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviewMatch)).EndInit();
            this.pnlMatchResult.ResumeLayout(false);
            this.pnlMatchResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private System.Windows.Forms.PictureBox picCreateSchedule;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitle;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtHomeClubName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtAwayClubName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMatchDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMatchTime;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtStadium;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlMatchResult;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtRatio;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvReviewMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadium;
        private System.Windows.Forms.ComboBox cmbClub;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLoadAll;
    }
}