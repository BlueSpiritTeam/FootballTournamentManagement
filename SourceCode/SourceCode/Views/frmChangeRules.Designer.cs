namespace SourceCode
{
    partial class frmChangeRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeRules));
            this.pnlTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picCreateSchedule = new System.Windows.Forms.PictureBox();
            this.grbTeam = new System.Windows.Forms.GroupBox();
            this.max_player = new System.Windows.Forms.NumericUpDown();
            this.min_player = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.max_age = new System.Windows.Forms.NumericUpDown();
            this.min_age = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView_typeGoal = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lose_score = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.draw_score = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.win_score = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDeleteTypeOfGoals = new System.Windows.Forms.Button();
            this.btnAddTypeOfGoals = new System.Windows.Forms.Button();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDefaultRules = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUpdateRules = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).BeginInit();
            this.grbTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_age)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lose_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.win_score)).BeginInit();
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
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Quality = 10;
            this.pnlTitle.Size = new System.Drawing.Size(780, 82);
            this.pnlTitle.TabIndex = 16;
            // 
            // bunifuCustomLabel
            // 
            this.bunifuCustomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel.AutoSize = true;
            this.bunifuCustomLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel.Location = new System.Drawing.Point(239, 18);
            this.bunifuCustomLabel.Name = "bunifuCustomLabel";
            this.bunifuCustomLabel.Size = new System.Drawing.Size(483, 44);
            this.bunifuCustomLabel.TabIndex = 60;
            this.bunifuCustomLabel.Text = "Tournament Setting";
            // 
            // picCreateSchedule
            // 
            this.picCreateSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.picCreateSchedule.Image = ((System.Drawing.Image)(resources.GetObject("picCreateSchedule.Image")));
            this.picCreateSchedule.Location = new System.Drawing.Point(156, 7);
            this.picCreateSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCreateSchedule.Name = "picCreateSchedule";
            this.picCreateSchedule.Size = new System.Drawing.Size(55, 57);
            this.picCreateSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCreateSchedule.TabIndex = 59;
            this.picCreateSchedule.TabStop = false;
            // 
            // grbTeam
            // 
            this.grbTeam.BackColor = System.Drawing.Color.White;
            this.grbTeam.Controls.Add(this.max_player);
            this.grbTeam.Controls.Add(this.min_player);
            this.grbTeam.Controls.Add(this.bunifuCustomLabel4);
            this.grbTeam.Controls.Add(this.bunifuCustomLabel5);
            this.grbTeam.Controls.Add(this.bunifuCustomLabel6);
            this.grbTeam.Controls.Add(this.max_age);
            this.grbTeam.Controls.Add(this.min_age);
            this.grbTeam.Controls.Add(this.bunifuCustomLabel2);
            this.grbTeam.Controls.Add(this.bunifuCustomLabel1);
            this.grbTeam.Controls.Add(this.bunifuCustomLabel3);
            this.grbTeam.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbTeam.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTeam.ForeColor = System.Drawing.Color.SeaGreen;
            this.grbTeam.Location = new System.Drawing.Point(0, 82);
            this.grbTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTeam.Name = "grbTeam";
            this.grbTeam.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTeam.Size = new System.Drawing.Size(780, 194);
            this.grbTeam.TabIndex = 17;
            this.grbTeam.TabStop = false;
            this.grbTeam.Text = "Rules for receiving team records";
            // 
            // max_player
            // 
            this.max_player.ForeColor = System.Drawing.Color.SeaGreen;
            this.max_player.Location = new System.Drawing.Point(544, 113);
            this.max_player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.max_player.Name = "max_player";
            this.max_player.Size = new System.Drawing.Size(76, 27);
            this.max_player.TabIndex = 38;
            // 
            // min_player
            // 
            this.min_player.ForeColor = System.Drawing.Color.SeaGreen;
            this.min_player.Location = new System.Drawing.Point(384, 113);
            this.min_player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.min_player.Name = "min_player";
            this.min_player.Size = new System.Drawing.Size(76, 27);
            this.min_player.TabIndex = 37;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(488, 114);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(35, 21);
            this.bunifuCustomLabel4.TabIndex = 36;
            this.bunifuCustomLabel4.Text = "to";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(309, 114);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel5.TabIndex = 35;
            this.bunifuCustomLabel5.Text = "From";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(37, 114);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(231, 21);
            this.bunifuCustomLabel6.TabIndex = 34;
            this.bunifuCustomLabel6.Text = "Number Of Players:";
            // 
            // max_age
            // 
            this.max_age.ForeColor = System.Drawing.Color.SeaGreen;
            this.max_age.Location = new System.Drawing.Point(544, 53);
            this.max_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.max_age.Name = "max_age";
            this.max_age.Size = new System.Drawing.Size(76, 27);
            this.max_age.TabIndex = 33;
            // 
            // min_age
            // 
            this.min_age.ForeColor = System.Drawing.Color.SeaGreen;
            this.min_age.Location = new System.Drawing.Point(384, 53);
            this.min_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.min_age.Name = "min_age";
            this.min_age.Size = new System.Drawing.Size(76, 27);
            this.min_age.TabIndex = 32;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(488, 55);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(35, 21);
            this.bunifuCustomLabel2.TabIndex = 31;
            this.bunifuCustomLabel2.Text = "to";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(309, 55);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel1.TabIndex = 30;
            this.bunifuCustomLabel1.Text = "From";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(37, 55);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(188, 21);
            this.bunifuCustomLabel3.TabIndex = 29;
            this.bunifuCustomLabel3.Text = "Age Of Players:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.listView_typeGoal);
            this.groupBox1.Controls.Add(this.lose_score);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel12);
            this.groupBox1.Controls.Add(this.draw_score);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel10);
            this.groupBox1.Controls.Add(this.win_score);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel11);
            this.groupBox1.Controls.Add(this.btnDeleteTypeOfGoals);
            this.groupBox1.Controls.Add(this.btnAddTypeOfGoals);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(0, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(780, 298);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rules for score and rank";
            // 
            // listView_typeGoal
            // 
            this.listView_typeGoal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_typeGoal.FullRowSelect = true;
            this.listView_typeGoal.GridLines = true;
            this.listView_typeGoal.Location = new System.Drawing.Point(27, 95);
            this.listView_typeGoal.Margin = new System.Windows.Forms.Padding(4);
            this.listView_typeGoal.Name = "listView_typeGoal";
            this.listView_typeGoal.Size = new System.Drawing.Size(280, 155);
            this.listView_typeGoal.TabIndex = 54;
            this.listView_typeGoal.UseCompatibleStateImageBehavior = false;
            this.listView_typeGoal.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type ID";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type Name";
            this.columnHeader2.Width = 141;
            // 
            // lose_score
            // 
            this.lose_score.ForeColor = System.Drawing.Color.SeaGreen;
            this.lose_score.Location = new System.Drawing.Point(631, 198);
            this.lose_score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lose_score.Name = "lose_score";
            this.lose_score.Size = new System.Drawing.Size(76, 28);
            this.lose_score.TabIndex = 53;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(463, 199);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(145, 21);
            this.bunifuCustomLabel12.TabIndex = 52;
            this.bunifuCustomLabel12.Text = "Lose Score:";
            // 
            // draw_score
            // 
            this.draw_score.ForeColor = System.Drawing.Color.SeaGreen;
            this.draw_score.Location = new System.Drawing.Point(631, 148);
            this.draw_score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.draw_score.Name = "draw_score";
            this.draw_score.Size = new System.Drawing.Size(76, 28);
            this.draw_score.TabIndex = 51;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(463, 149);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(152, 21);
            this.bunifuCustomLabel10.TabIndex = 50;
            this.bunifuCustomLabel10.Text = "Draw Score:";
            // 
            // win_score
            // 
            this.win_score.ForeColor = System.Drawing.Color.SeaGreen;
            this.win_score.Location = new System.Drawing.Point(631, 92);
            this.win_score.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.win_score.Name = "win_score";
            this.win_score.Size = new System.Drawing.Size(76, 28);
            this.win_score.TabIndex = 49;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(469, 95);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(132, 21);
            this.bunifuCustomLabel11.TabIndex = 48;
            this.bunifuCustomLabel11.Text = "Win Score:";
            // 
            // btnDeleteTypeOfGoals
            // 
            this.btnDeleteTypeOfGoals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTypeOfGoals.BackgroundImage")));
            this.btnDeleteTypeOfGoals.Location = new System.Drawing.Point(315, 186);
            this.btnDeleteTypeOfGoals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTypeOfGoals.Name = "btnDeleteTypeOfGoals";
            this.btnDeleteTypeOfGoals.Size = new System.Drawing.Size(69, 65);
            this.btnDeleteTypeOfGoals.TabIndex = 45;
            this.btnDeleteTypeOfGoals.UseVisualStyleBackColor = true;
            this.btnDeleteTypeOfGoals.Click += new System.EventHandler(this.btnDeleteTypeOfGoals_Click);
            // 
            // btnAddTypeOfGoals
            // 
            this.btnAddTypeOfGoals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTypeOfGoals.BackgroundImage")));
            this.btnAddTypeOfGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTypeOfGoals.Location = new System.Drawing.Point(315, 95);
            this.btnAddTypeOfGoals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTypeOfGoals.Name = "btnAddTypeOfGoals";
            this.btnAddTypeOfGoals.Size = new System.Drawing.Size(69, 65);
            this.btnAddTypeOfGoals.TabIndex = 43;
            this.btnAddTypeOfGoals.UseVisualStyleBackColor = true;
            this.btnAddTypeOfGoals.Click += new System.EventHandler(this.btnAddTypeOfGoals_Click);
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(23, 54);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(250, 21);
            this.bunifuCustomLabel9.TabIndex = 42;
            this.bunifuCustomLabel9.Text = "List Of type of goals";
            // 
            // btnDefaultRules
            // 
            this.btnDefaultRules.Activecolor = System.Drawing.Color.White;
            this.btnDefaultRules.BackColor = System.Drawing.Color.White;
            this.btnDefaultRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefaultRules.BorderRadius = 3;
            this.btnDefaultRules.ButtonText = "Default";
            this.btnDefaultRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefaultRules.DisabledColor = System.Drawing.Color.Gray;
            this.btnDefaultRules.Iconcolor = System.Drawing.Color.White;
            this.btnDefaultRules.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDefaultRules.Iconimage")));
            this.btnDefaultRules.Iconimage_right = null;
            this.btnDefaultRules.Iconimage_right_Selected = null;
            this.btnDefaultRules.Iconimage_Selected = null;
            this.btnDefaultRules.IconMarginLeft = 1;
            this.btnDefaultRules.IconMarginRight = 0;
            this.btnDefaultRules.IconRightVisible = false;
            this.btnDefaultRules.IconRightZoom = 0D;
            this.btnDefaultRules.IconVisible = true;
            this.btnDefaultRules.IconZoom = 90D;
            this.btnDefaultRules.IsTab = false;
            this.btnDefaultRules.Location = new System.Drawing.Point(19, 598);
            this.btnDefaultRules.Margin = new System.Windows.Forms.Padding(5);
            this.btnDefaultRules.Name = "btnDefaultRules";
            this.btnDefaultRules.Normalcolor = System.Drawing.Color.White;
            this.btnDefaultRules.OnHovercolor = System.Drawing.Color.Lime;
            this.btnDefaultRules.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnDefaultRules.selected = true;
            this.btnDefaultRules.Size = new System.Drawing.Size(227, 52);
            this.btnDefaultRules.TabIndex = 22;
            this.btnDefaultRules.Text = "Default";
            this.btnDefaultRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDefaultRules.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnDefaultRules.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultRules.Click += new System.EventHandler(this.btnDefaultRules_Click);
            // 
            // btnUpdateRules
            // 
            this.btnUpdateRules.Activecolor = System.Drawing.Color.White;
            this.btnUpdateRules.BackColor = System.Drawing.Color.White;
            this.btnUpdateRules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateRules.BorderRadius = 3;
            this.btnUpdateRules.ButtonText = "Update";
            this.btnUpdateRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateRules.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateRules.Iconcolor = System.Drawing.Color.White;
            this.btnUpdateRules.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdateRules.Iconimage")));
            this.btnUpdateRules.Iconimage_right = null;
            this.btnUpdateRules.Iconimage_right_Selected = null;
            this.btnUpdateRules.Iconimage_Selected = null;
            this.btnUpdateRules.IconMarginLeft = 1;
            this.btnUpdateRules.IconMarginRight = 0;
            this.btnUpdateRules.IconRightVisible = false;
            this.btnUpdateRules.IconRightZoom = 0D;
            this.btnUpdateRules.IconVisible = true;
            this.btnUpdateRules.IconZoom = 90D;
            this.btnUpdateRules.IsTab = false;
            this.btnUpdateRules.Location = new System.Drawing.Point(265, 598);
            this.btnUpdateRules.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateRules.Name = "btnUpdateRules";
            this.btnUpdateRules.Normalcolor = System.Drawing.Color.White;
            this.btnUpdateRules.OnHovercolor = System.Drawing.Color.Lime;
            this.btnUpdateRules.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateRules.selected = true;
            this.btnUpdateRules.Size = new System.Drawing.Size(227, 52);
            this.btnUpdateRules.TabIndex = 21;
            this.btnUpdateRules.Text = "Update";
            this.btnUpdateRules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateRules.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnUpdateRules.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRules.Click += new System.EventHandler(this.btnUpdateRules_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.White;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 3;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.White;
            this.btnCancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancel.Iconimage")));
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
            this.btnCancel.Location = new System.Drawing.Point(520, 598);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.White;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Lime;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(227, 52);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmChangeRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(780, 658);
            this.Controls.Add(this.btnDefaultRules);
            this.Controls.Add(this.btnUpdateRules);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbTeam);
            this.Controls.Add(this.pnlTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Rules";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).EndInit();
            this.grbTeam.ResumeLayout(false);
            this.grbTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.max_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min_age)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lose_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.draw_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.win_score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private System.Windows.Forms.PictureBox picCreateSchedule;
        private System.Windows.Forms.GroupBox grbTeam;
        private System.Windows.Forms.NumericUpDown max_player;
        private System.Windows.Forms.NumericUpDown min_player;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.NumericUpDown max_age;
        private System.Windows.Forms.NumericUpDown min_age;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown lose_score;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.NumericUpDown draw_score;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.NumericUpDown win_score;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.Button btnDeleteTypeOfGoals;
        private System.Windows.Forms.Button btnAddTypeOfGoals;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuFlatButton btnDefaultRules;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdateRules;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.ListView listView_typeGoal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}