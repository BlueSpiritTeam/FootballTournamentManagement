namespace SourceCode
{
    partial class frmRankOfTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRankOfTeam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picCreateSchedule = new System.Windows.Forms.PictureBox();
            this.pnlDateOfCompetition = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cmbDateOfCompetition = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlRankOfTeams = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvRankOfTeams = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBanThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBanThua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShowResult = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).BeginInit();
            this.pnlDateOfCompetition.SuspendLayout();
            this.pnlRankOfTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankOfTeams)).BeginInit();
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
            this.pnlTitle.Size = new System.Drawing.Size(1046, 83);
            this.pnlTitle.TabIndex = 1;
            // 
            // bunifuCustomLabel
            // 
            this.bunifuCustomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel.AutoSize = true;
            this.bunifuCustomLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel.Location = new System.Drawing.Point(403, 21);
            this.bunifuCustomLabel.Name = "bunifuCustomLabel";
            this.bunifuCustomLabel.Size = new System.Drawing.Size(352, 44);
            this.bunifuCustomLabel.TabIndex = 60;
            this.bunifuCustomLabel.Text = "Rank Of Clubs";
            // 
            // picCreateSchedule
            // 
            this.picCreateSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.picCreateSchedule.Image = ((System.Drawing.Image)(resources.GetObject("picCreateSchedule.Image")));
            this.picCreateSchedule.Location = new System.Drawing.Point(341, 8);
            this.picCreateSchedule.Name = "picCreateSchedule";
            this.picCreateSchedule.Size = new System.Drawing.Size(55, 57);
            this.picCreateSchedule.TabIndex = 59;
            this.picCreateSchedule.TabStop = false;
            // 
            // pnlDateOfCompetition
            // 
            this.pnlDateOfCompetition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDateOfCompetition.BackgroundImage")));
            this.pnlDateOfCompetition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDateOfCompetition.Controls.Add(this.cmbDateOfCompetition);
            this.pnlDateOfCompetition.Controls.Add(this.bunifuCustomLabel1);
            this.pnlDateOfCompetition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDateOfCompetition.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlDateOfCompetition.GradientBottomRight = System.Drawing.Color.White;
            this.pnlDateOfCompetition.GradientTopLeft = System.Drawing.Color.White;
            this.pnlDateOfCompetition.GradientTopRight = System.Drawing.Color.White;
            this.pnlDateOfCompetition.Location = new System.Drawing.Point(0, 83);
            this.pnlDateOfCompetition.Name = "pnlDateOfCompetition";
            this.pnlDateOfCompetition.Quality = 10;
            this.pnlDateOfCompetition.Size = new System.Drawing.Size(1046, 73);
            this.pnlDateOfCompetition.TabIndex = 2;
            // 
            // cmbDateOfCompetition
            // 
            this.cmbDateOfCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDateOfCompetition.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmbDateOfCompetition.FormattingEnabled = true;
            this.cmbDateOfCompetition.Location = new System.Drawing.Point(421, 18);
            this.cmbDateOfCompetition.Name = "cmbDateOfCompetition";
            this.cmbDateOfCompetition.Size = new System.Drawing.Size(325, 33);
            this.cmbDateOfCompetition.TabIndex = 64;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(330, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 21);
            this.bunifuCustomLabel1.TabIndex = 63;
            this.bunifuCustomLabel1.Text = "Date";
            // 
            // pnlRankOfTeams
            // 
            this.pnlRankOfTeams.BackColor = System.Drawing.Color.Silver;
            this.pnlRankOfTeams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRankOfTeams.BackgroundImage")));
            this.pnlRankOfTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRankOfTeams.Controls.Add(this.dgvRankOfTeams);
            this.pnlRankOfTeams.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRankOfTeams.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlRankOfTeams.GradientBottomRight = System.Drawing.Color.White;
            this.pnlRankOfTeams.GradientTopLeft = System.Drawing.Color.White;
            this.pnlRankOfTeams.GradientTopRight = System.Drawing.Color.White;
            this.pnlRankOfTeams.Location = new System.Drawing.Point(0, 156);
            this.pnlRankOfTeams.Name = "pnlRankOfTeams";
            this.pnlRankOfTeams.Quality = 10;
            this.pnlRankOfTeams.Size = new System.Drawing.Size(1046, 361);
            this.pnlRankOfTeams.TabIndex = 3;
            // 
            // dgvRankOfTeams
            // 
            this.dgvRankOfTeams.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRankOfTeams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRankOfTeams.BackgroundColor = System.Drawing.Color.White;
            this.dgvRankOfTeams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRankOfTeams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRankOfTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRankOfTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRankOfTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderingNumber,
            this.ClubName,
            this.Win,
            this.Draw,
            this.Lose,
            this.Offset,
            this.TotalScore,
            this.SoBanThang,
            this.SoBanThua,
            this.Rank});
            this.dgvRankOfTeams.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRankOfTeams.DoubleBuffered = true;
            this.dgvRankOfTeams.EnableHeadersVisualStyles = false;
            this.dgvRankOfTeams.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvRankOfTeams.HeaderBgColor = System.Drawing.Color.White;
            this.dgvRankOfTeams.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvRankOfTeams.Location = new System.Drawing.Point(0, 0);
            this.dgvRankOfTeams.Name = "dgvRankOfTeams";
            this.dgvRankOfTeams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvRankOfTeams.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRankOfTeams.RowTemplate.Height = 24;
            this.dgvRankOfTeams.Size = new System.Drawing.Size(1046, 361);
            this.dgvRankOfTeams.TabIndex = 2;
            // 
            // OrderingNumber
            // 
            this.OrderingNumber.HeaderText = "Ordering Number";
            this.OrderingNumber.Name = "OrderingNumber";
            // 
            // ClubName
            // 
            this.ClubName.HeaderText = "Club Name";
            this.ClubName.Name = "ClubName";
            // 
            // Win
            // 
            this.Win.HeaderText = "Win";
            this.Win.Name = "Win";
            // 
            // Draw
            // 
            this.Draw.HeaderText = "Draw";
            this.Draw.Name = "Draw";
            // 
            // Lose
            // 
            this.Lose.HeaderText = "Lose";
            this.Lose.Name = "Lose";
            // 
            // Offset
            // 
            this.Offset.HeaderText = "Offset";
            this.Offset.Name = "Offset";
            // 
            // TotalScore
            // 
            this.TotalScore.HeaderText = "Total Score";
            this.TotalScore.Name = "TotalScore";
            // 
            // SoBanThang
            // 
            this.SoBanThang.HeaderText = "So Ban Thang";
            this.SoBanThang.Name = "SoBanThang";
            // 
            // SoBanThua
            // 
            this.SoBanThua.HeaderText = "So Ban Thua";
            this.SoBanThua.Name = "SoBanThua";
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Activecolor = System.Drawing.Color.White;
            this.btnPrintReport.BackColor = System.Drawing.Color.White;
            this.btnPrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintReport.BorderRadius = 3;
            this.btnPrintReport.ButtonText = "Print Report";
            this.btnPrintReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintReport.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintReport.Iconcolor = System.Drawing.Color.White;
            this.btnPrintReport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintReport.Iconimage")));
            this.btnPrintReport.Iconimage_right = null;
            this.btnPrintReport.Iconimage_right_Selected = null;
            this.btnPrintReport.Iconimage_Selected = null;
            this.btnPrintReport.IconMarginLeft = 1;
            this.btnPrintReport.IconMarginRight = 0;
            this.btnPrintReport.IconRightVisible = false;
            this.btnPrintReport.IconRightZoom = 0D;
            this.btnPrintReport.IconVisible = true;
            this.btnPrintReport.IconZoom = 90D;
            this.btnPrintReport.IsTab = false;
            this.btnPrintReport.Location = new System.Drawing.Point(385, 524);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Normalcolor = System.Drawing.Color.White;
            this.btnPrintReport.OnHovercolor = System.Drawing.Color.Lime;
            this.btnPrintReport.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnPrintReport.selected = true;
            this.btnPrintReport.Size = new System.Drawing.Size(226, 52);
            this.btnPrintReport.TabIndex = 12;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintReport.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnPrintReport.TextFont = new System.Drawing.Font("Source Sans Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnShowResult
            // 
            this.btnShowResult.Activecolor = System.Drawing.Color.White;
            this.btnShowResult.BackColor = System.Drawing.Color.White;
            this.btnShowResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowResult.BorderRadius = 3;
            this.btnShowResult.ButtonText = "Show Result";
            this.btnShowResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowResult.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowResult.Iconcolor = System.Drawing.Color.White;
            this.btnShowResult.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowResult.Iconimage")));
            this.btnShowResult.Iconimage_right = null;
            this.btnShowResult.Iconimage_right_Selected = null;
            this.btnShowResult.Iconimage_Selected = null;
            this.btnShowResult.IconMarginLeft = 1;
            this.btnShowResult.IconMarginRight = 0;
            this.btnShowResult.IconRightVisible = false;
            this.btnShowResult.IconRightZoom = 0D;
            this.btnShowResult.IconVisible = true;
            this.btnShowResult.IconZoom = 90D;
            this.btnShowResult.IsTab = false;
            this.btnShowResult.Location = new System.Drawing.Point(139, 524);
            this.btnShowResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Normalcolor = System.Drawing.Color.White;
            this.btnShowResult.OnHovercolor = System.Drawing.Color.Lime;
            this.btnShowResult.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnShowResult.selected = true;
            this.btnShowResult.Size = new System.Drawing.Size(226, 52);
            this.btnShowResult.TabIndex = 13;
            this.btnShowResult.Text = "Show Result";
            this.btnShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowResult.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnShowResult.TextFont = new System.Drawing.Font("Source Sans Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCancel.Location = new System.Drawing.Point(640, 524);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.White;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Lime;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(226, 52);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.TextFont = new System.Drawing.Font("Source Sans Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // frmRankOfTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1046, 582);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.pnlRankOfTeams);
            this.Controls.Add(this.pnlDateOfCompetition);
            this.Controls.Add(this.pnlTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRankOfTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rank Of Clubs";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).EndInit();
            this.pnlDateOfCompetition.ResumeLayout(false);
            this.pnlDateOfCompetition.PerformLayout();
            this.pnlRankOfTeams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankOfTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private System.Windows.Forms.PictureBox picCreateSchedule;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlDateOfCompetition;
        private System.Windows.Forms.ComboBox cmbDateOfCompetition;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlRankOfTeams;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRankOfTeams;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintReport;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowResult;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBanThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBanThua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
    }
}