namespace SourceCode
{
    partial class frmRankOfClub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRankOfClub));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picCreateSchedule = new System.Windows.Forms.PictureBox();
            this.pnlRankOfTeams = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvRankOfTeams = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Draw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWinGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLoseGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReLoad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).BeginInit();
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
            this.pnlRankOfTeams.Location = new System.Drawing.Point(0, 83);
            this.pnlRankOfTeams.Name = "pnlRankOfTeams";
            this.pnlRankOfTeams.Quality = 10;
            this.pnlRankOfTeams.Size = new System.Drawing.Size(1046, 419);
            this.pnlRankOfTeams.TabIndex = 3;
            // 
            // dgvRankOfTeams
            // 
            this.dgvRankOfTeams.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRankOfTeams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRankOfTeams.BackgroundColor = System.Drawing.Color.White;
            this.dgvRankOfTeams.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRankOfTeams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRankOfTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRankOfTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRankOfTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderingNumber,
            this.ClubName,
            this.Win,
            this.Draw,
            this.Lose,
            this.Offset,
            this.TotalPoint,
            this.TotalWinGoal,
            this.TotalLoseGoal,
            this.Rank});
            this.dgvRankOfTeams.DoubleBuffered = true;
            this.dgvRankOfTeams.EnableHeadersVisualStyles = false;
            this.dgvRankOfTeams.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvRankOfTeams.HeaderBgColor = System.Drawing.Color.White;
            this.dgvRankOfTeams.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvRankOfTeams.Location = new System.Drawing.Point(0, 0);
            this.dgvRankOfTeams.Name = "dgvRankOfTeams";
            this.dgvRankOfTeams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvRankOfTeams.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRankOfTeams.RowTemplate.Height = 24;
            this.dgvRankOfTeams.Size = new System.Drawing.Size(1046, 416);
            this.dgvRankOfTeams.TabIndex = 2;
            // 
            // OrderingNumber
            // 
            this.OrderingNumber.DataPropertyName = "OrderingNumber";
            this.OrderingNumber.HeaderText = "Ordering Number";
            this.OrderingNumber.Name = "OrderingNumber";
            // 
            // ClubName
            // 
            this.ClubName.DataPropertyName = "ClubName";
            this.ClubName.HeaderText = "Club Name";
            this.ClubName.Name = "ClubName";
            // 
            // Win
            // 
            this.Win.DataPropertyName = "Win";
            this.Win.HeaderText = "Win";
            this.Win.Name = "Win";
            // 
            // Draw
            // 
            this.Draw.DataPropertyName = "Draw";
            this.Draw.HeaderText = "Draw";
            this.Draw.Name = "Draw";
            // 
            // Lose
            // 
            this.Lose.DataPropertyName = "Lose";
            this.Lose.HeaderText = "Lose";
            this.Lose.Name = "Lose";
            // 
            // Offset
            // 
            this.Offset.DataPropertyName = "Offset";
            this.Offset.HeaderText = "Offset";
            this.Offset.Name = "Offset";
            // 
            // TotalPoint
            // 
            this.TotalPoint.DataPropertyName = "TotalPoint";
            this.TotalPoint.HeaderText = "Total Point";
            this.TotalPoint.Name = "TotalPoint";
            // 
            // TotalWinGoal
            // 
            this.TotalWinGoal.DataPropertyName = "TotalWinGoal";
            this.TotalWinGoal.HeaderText = "Total Win Goal";
            this.TotalWinGoal.Name = "TotalWinGoal";
            // 
            // TotalLoseGoal
            // 
            this.TotalLoseGoal.DataPropertyName = "TotalLoseGoal";
            this.TotalLoseGoal.HeaderText = "Total Lose Goal";
            this.TotalLoseGoal.Name = "TotalLoseGoal";
            // 
            // Rank
            // 
            this.Rank.DataPropertyName = "RankClub";
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Activecolor = System.Drawing.Color.White;
            this.btnPrintReport.BackColor = System.Drawing.Color.White;
            this.btnPrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintReport.BorderRadius = 3;
            this.btnPrintReport.ButtonText = "Create Report";
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
            this.btnPrintReport.Text = "Create Report";
            this.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintReport.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnPrintReport.TextFont = new System.Drawing.Font("Source Sans Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnReLoad
            // 
            this.btnReLoad.Activecolor = System.Drawing.Color.White;
            this.btnReLoad.BackColor = System.Drawing.Color.White;
            this.btnReLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReLoad.BorderRadius = 3;
            this.btnReLoad.ButtonText = "ReLoad";
            this.btnReLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReLoad.DisabledColor = System.Drawing.Color.Gray;
            this.btnReLoad.Iconcolor = System.Drawing.Color.White;
            this.btnReLoad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Iconimage")));
            this.btnReLoad.Iconimage_right = null;
            this.btnReLoad.Iconimage_right_Selected = null;
            this.btnReLoad.Iconimage_Selected = null;
            this.btnReLoad.IconMarginLeft = 1;
            this.btnReLoad.IconMarginRight = 0;
            this.btnReLoad.IconRightVisible = false;
            this.btnReLoad.IconRightZoom = 0D;
            this.btnReLoad.IconVisible = true;
            this.btnReLoad.IconZoom = 90D;
            this.btnReLoad.IsTab = false;
            this.btnReLoad.Location = new System.Drawing.Point(139, 524);
            this.btnReLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Normalcolor = System.Drawing.Color.White;
            this.btnReLoad.OnHovercolor = System.Drawing.Color.Lime;
            this.btnReLoad.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnReLoad.selected = true;
            this.btnReLoad.Size = new System.Drawing.Size(226, 52);
            this.btnReLoad.TabIndex = 13;
            this.btnReLoad.Text = "ReLoad";
            this.btnReLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReLoad.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnReLoad.TextFont = new System.Drawing.Font("Source Sans Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
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
            // frmRankOfClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1046, 582);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReLoad);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.pnlRankOfTeams);
            this.Controls.Add(this.pnlTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRankOfClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rank Of Clubs";
            this.Load += new System.EventHandler(this.frmRankOfTeam_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).EndInit();
            this.pnlRankOfTeams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRankOfTeams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private System.Windows.Forms.PictureBox picCreateSchedule;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlRankOfTeams;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRankOfTeams;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintReport;
        private Bunifu.Framework.UI.BunifuFlatButton btnReLoad;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win;
        private System.Windows.Forms.DataGridViewTextBoxColumn Draw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWinGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLoseGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
    }
}