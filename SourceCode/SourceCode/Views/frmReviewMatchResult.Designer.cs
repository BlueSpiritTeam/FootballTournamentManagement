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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picCreateSchedule = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnShowResult = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbRound = new System.Windows.Forms.ComboBox();
            this.cmbSearchMatch = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtHomeClubName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtHomeClubRatio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtGuestClubName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtGuestClubRatio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMatchDate = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MatchTime = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.pnlMatchResult = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListPlayerToScore = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNumberOfGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.pnlMatchResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPlayerToScore)).BeginInit();
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
            this.pnlTitle.Controls.Add(this.btnCancel);
            this.pnlTitle.Controls.Add(this.btnShowResult);
            this.pnlTitle.Controls.Add(this.cmbRound);
            this.pnlTitle.Controls.Add(this.cmbSearchMatch);
            this.pnlTitle.Controls.Add(this.bunifuCustomLabel);
            this.pnlTitle.Controls.Add(this.picCreateSchedule);
            this.pnlTitle.Controls.Add(this.bunifuCustomLabel3);
            this.pnlTitle.Controls.Add(this.bunifuCustomLabel1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlTitle.GradientBottomRight = System.Drawing.Color.White;
            this.pnlTitle.GradientTopLeft = System.Drawing.Color.White;
            this.pnlTitle.GradientTopRight = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Quality = 10;
            this.pnlTitle.Size = new System.Drawing.Size(833, 203);
            this.pnlTitle.TabIndex = 56;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnCancel.Location = new System.Drawing.Point(405, 154);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 41);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnShowResult
            // 
            this.btnShowResult.ActiveBorderThickness = 1;
            this.btnShowResult.ActiveCornerRadius = 20;
            this.btnShowResult.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnShowResult.ActiveForecolor = System.Drawing.Color.White;
            this.btnShowResult.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnShowResult.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowResult.BackgroundImage")));
            this.btnShowResult.ButtonText = "Show Result";
            this.btnShowResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnShowResult.IdleBorderThickness = 1;
            this.btnShowResult.IdleCornerRadius = 20;
            this.btnShowResult.IdleFillColor = System.Drawing.Color.White;
            this.btnShowResult.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnShowResult.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnShowResult.Location = new System.Drawing.Point(198, 154);
            this.btnShowResult.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(179, 41);
            this.btnShowResult.TabIndex = 63;
            this.btnShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // cmbRound
            // 
            this.cmbRound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRound.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmbRound.FormattingEnabled = true;
            this.cmbRound.Location = new System.Drawing.Point(590, 96);
            this.cmbRound.Name = "cmbRound";
            this.cmbRound.Size = new System.Drawing.Size(118, 33);
            this.cmbRound.TabIndex = 62;
            // 
            // cmbSearchMatch
            // 
            this.cmbSearchMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearchMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchMatch.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmbSearchMatch.FormattingEnabled = true;
            this.cmbSearchMatch.Location = new System.Drawing.Point(153, 98);
            this.cmbSearchMatch.Name = "cmbSearchMatch";
            this.cmbSearchMatch.Size = new System.Drawing.Size(244, 33);
            this.cmbSearchMatch.TabIndex = 61;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(33, 103);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(85, 21);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Match:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(479, 101);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(90, 21);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Round: ";
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
            // txtHomeClubRatio
            // 
            this.txtHomeClubRatio.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtHomeClubRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomeClubRatio.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtHomeClubRatio.Location = new System.Drawing.Point(268, 75);
            this.txtHomeClubRatio.Name = "txtHomeClubRatio";
            this.txtHomeClubRatio.Size = new System.Drawing.Size(84, 28);
            this.txtHomeClubRatio.TabIndex = 11;
            // 
            // txtGuestClubName
            // 
            this.txtGuestClubName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtGuestClubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestClubName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtGuestClubName.Location = new System.Drawing.Point(485, 75);
            this.txtGuestClubName.Name = "txtGuestClubName";
            this.txtGuestClubName.Size = new System.Drawing.Size(219, 28);
            this.txtGuestClubName.TabIndex = 13;
            // 
            // txtGuestClubRatio
            // 
            this.txtGuestClubRatio.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtGuestClubRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestClubRatio.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtGuestClubRatio.Location = new System.Drawing.Point(369, 75);
            this.txtGuestClubRatio.Name = "txtGuestClubRatio";
            this.txtGuestClubRatio.Size = new System.Drawing.Size(84, 28);
            this.txtGuestClubRatio.TabIndex = 15;
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
            // MatchTime
            // 
            this.MatchTime.BorderColor = System.Drawing.Color.SeaGreen;
            this.MatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchTime.ForeColor = System.Drawing.Color.SeaGreen;
            this.MatchTime.Location = new System.Drawing.Point(343, 135);
            this.MatchTime.Name = "MatchTime";
            this.MatchTime.Size = new System.Drawing.Size(105, 28);
            this.MatchTime.TabIndex = 19;
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
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(613, 137);
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(187, 28);
            this.bunifuCustomTextbox1.TabIndex = 21;
            // 
            // pnlMatchResult
            // 
            this.pnlMatchResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMatchResult.BackgroundImage")));
            this.pnlMatchResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel5);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel4);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel2);
            this.pnlMatchResult.Controls.Add(this.groupBox1);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomTextbox1);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel9);
            this.pnlMatchResult.Controls.Add(this.MatchTime);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel7);
            this.pnlMatchResult.Controls.Add(this.txtMatchDate);
            this.pnlMatchResult.Controls.Add(this.bunifuCustomLabel8);
            this.pnlMatchResult.Controls.Add(this.txtGuestClubRatio);
            this.pnlMatchResult.Controls.Add(this.txtGuestClubName);
            this.pnlMatchResult.Controls.Add(this.txtHomeClubRatio);
            this.pnlMatchResult.Controls.Add(this.txtHomeClubName);
            this.pnlMatchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMatchResult.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlMatchResult.GradientBottomRight = System.Drawing.Color.White;
            this.pnlMatchResult.GradientTopLeft = System.Drawing.Color.White;
            this.pnlMatchResult.GradientTopRight = System.Drawing.Color.White;
            this.pnlMatchResult.Location = new System.Drawing.Point(0, 203);
            this.pnlMatchResult.Name = "pnlMatchResult";
            this.pnlMatchResult.Quality = 10;
            this.pnlMatchResult.Size = new System.Drawing.Size(833, 496);
            this.pnlMatchResult.TabIndex = 57;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(546, 34);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(132, 21);
            this.bunifuCustomLabel5.TabIndex = 63;
            this.bunifuCustomLabel5.Text = "Guest Club";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListPlayerToScore);
            this.groupBox1.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(26, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 234);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Players to Score";
            // 
            // dgvListPlayerToScore
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListPlayerToScore.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListPlayerToScore.BackgroundColor = System.Drawing.Color.White;
            this.dgvListPlayerToScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListPlayerToScore.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPlayerToScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListPlayerToScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPlayerToScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderingNumber,
            this.PlayerName,
            this.Club,
            this.Role,
            this.TotalNumberOfGoals});
            this.dgvListPlayerToScore.DoubleBuffered = true;
            this.dgvListPlayerToScore.EnableHeadersVisualStyles = false;
            this.dgvListPlayerToScore.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvListPlayerToScore.HeaderBgColor = System.Drawing.Color.White;
            this.dgvListPlayerToScore.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvListPlayerToScore.Location = new System.Drawing.Point(3, 22);
            this.dgvListPlayerToScore.Name = "dgvListPlayerToScore";
            this.dgvListPlayerToScore.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvListPlayerToScore.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListPlayerToScore.RowTemplate.Height = 24;
            this.dgvListPlayerToScore.Size = new System.Drawing.Size(802, 268);
            this.dgvListPlayerToScore.TabIndex = 1;
            // 
            // OrderingNumber
            // 
            this.OrderingNumber.HeaderText = "Ordering Number";
            this.OrderingNumber.Name = "OrderingNumber";
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.Name = "PlayerName";
            // 
            // Club
            // 
            this.Club.HeaderText = "Club";
            this.Club.Name = "Club";
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // TotalNumberOfGoals
            // 
            this.TotalNumberOfGoals.HeaderText = "Total Number Of Goals";
            this.TotalNumberOfGoals.Name = "TotalNumberOfGoals";
            // 
            // frmReviewMatchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 699);
            this.Controls.Add(this.pnlMatchResult);
            this.Controls.Add(this.pnlTitle);
            this.MinimizeBox = false;
            this.Name = "frmReviewMatchResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Match Result";
            this.Load += new System.EventHandler(this.frmReviewMatchResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlMatchResult.ResumeLayout(false);
            this.pnlMatchResult.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPlayerToScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private System.Windows.Forms.PictureBox picCreateSchedule;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtHomeClubName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtHomeClubRatio;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtGuestClubName;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtGuestClubRatio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMatchDate;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox MatchTime;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlMatchResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvListPlayerToScore;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox cmbRound;
        private System.Windows.Forms.ComboBox cmbSearchMatch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShowResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNumberOfGoals;
    }
}