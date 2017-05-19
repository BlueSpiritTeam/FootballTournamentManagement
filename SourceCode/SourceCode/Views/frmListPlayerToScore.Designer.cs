namespace SourceCode
{
    partial class frmListPlayerToScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListPlayerToScore));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picCreateSchedule = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvListPlayerToScore = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNumberOfGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRankOfTeams = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPlayerToScore)).BeginInit();
            this.pnlRankOfTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Activecolor = System.Drawing.Color.White;
            this.btnReload.BackColor = System.Drawing.Color.White;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 3;
            this.btnReload.ButtonText = "ReLoad";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.Iconcolor = System.Drawing.Color.White;
            this.btnReload.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReload.Iconimage")));
            this.btnReload.Iconimage_right = null;
            this.btnReload.Iconimage_right_Selected = null;
            this.btnReload.Iconimage_Selected = null;
            this.btnReload.IconMarginLeft = 1;
            this.btnReload.IconMarginRight = 0;
            this.btnReload.IconRightVisible = false;
            this.btnReload.IconRightZoom = 0D;
            this.btnReload.IconVisible = true;
            this.btnReload.IconZoom = 90D;
            this.btnReload.IsTab = false;
            this.btnReload.Location = new System.Drawing.Point(73, 563);
            this.btnReload.Margin = new System.Windows.Forms.Padding(5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.White;
            this.btnReload.OnHovercolor = System.Drawing.Color.Lime;
            this.btnReload.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnReload.selected = true;
            this.btnReload.Size = new System.Drawing.Size(227, 52);
            this.btnReload.TabIndex = 19;
            this.btnReload.Text = "ReLoad";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReload.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
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
            this.btnPrintReport.Location = new System.Drawing.Point(319, 563);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Normalcolor = System.Drawing.Color.White;
            this.btnPrintReport.OnHovercolor = System.Drawing.Color.Lime;
            this.btnPrintReport.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnPrintReport.selected = true;
            this.btnPrintReport.Size = new System.Drawing.Size(227, 52);
            this.btnPrintReport.TabIndex = 18;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintReport.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnPrintReport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // bunifuCustomLabel
            // 
            this.bunifuCustomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel.AutoSize = true;
            this.bunifuCustomLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel.Location = new System.Drawing.Point(232, 21);
            this.bunifuCustomLabel.Name = "bunifuCustomLabel";
            this.bunifuCustomLabel.Size = new System.Drawing.Size(381, 46);
            this.bunifuCustomLabel.TabIndex = 60;
            this.bunifuCustomLabel.Text = "List Player To Score";
            // 
            // picCreateSchedule
            // 
            this.picCreateSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.picCreateSchedule.Image = ((System.Drawing.Image)(resources.GetObject("picCreateSchedule.Image")));
            this.picCreateSchedule.Location = new System.Drawing.Point(171, 7);
            this.picCreateSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCreateSchedule.Name = "picCreateSchedule";
            this.picCreateSchedule.Size = new System.Drawing.Size(55, 57);
            this.picCreateSchedule.TabIndex = 59;
            this.picCreateSchedule.TabStop = false;
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
            this.pnlTitle.Size = new System.Drawing.Size(872, 82);
            this.pnlTitle.TabIndex = 15;
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
            this.btnCancel.Location = new System.Drawing.Point(574, 563);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.White;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Lime;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(227, 52);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvListPlayerToScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListPlayerToScore.DoubleBuffered = true;
            this.dgvListPlayerToScore.EnableHeadersVisualStyles = false;
            this.dgvListPlayerToScore.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvListPlayerToScore.HeaderBgColor = System.Drawing.Color.White;
            this.dgvListPlayerToScore.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvListPlayerToScore.Location = new System.Drawing.Point(0, 0);
            this.dgvListPlayerToScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListPlayerToScore.MultiSelect = false;
            this.dgvListPlayerToScore.Name = "dgvListPlayerToScore";
            this.dgvListPlayerToScore.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvListPlayerToScore.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListPlayerToScore.RowTemplate.Height = 24;
            this.dgvListPlayerToScore.Size = new System.Drawing.Size(872, 459);
            this.dgvListPlayerToScore.TabIndex = 2;
            // 
            // OrderingNumber
            // 
            this.OrderingNumber.DataPropertyName = "OrderingNumber";
            this.OrderingNumber.HeaderText = "Ordering Number";
            this.OrderingNumber.Name = "OrderingNumber";
            // 
            // PlayerName
            // 
            this.PlayerName.DataPropertyName = "Name";
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Width = 150;
            // 
            // Club
            // 
            this.Club.DataPropertyName = "ClubName";
            this.Club.HeaderText = "Club";
            this.Club.Name = "Club";
            this.Club.Width = 150;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "RoleName";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // TotalNumberOfGoals
            // 
            this.TotalNumberOfGoals.DataPropertyName = "GoalNumber";
            this.TotalNumberOfGoals.HeaderText = "Total Number Of Goals";
            this.TotalNumberOfGoals.Name = "TotalNumberOfGoals";
            // 
            // pnlRankOfTeams
            // 
            this.pnlRankOfTeams.BackColor = System.Drawing.Color.Silver;
            this.pnlRankOfTeams.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRankOfTeams.BackgroundImage")));
            this.pnlRankOfTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRankOfTeams.Controls.Add(this.dgvListPlayerToScore);
            this.pnlRankOfTeams.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRankOfTeams.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlRankOfTeams.GradientBottomRight = System.Drawing.Color.White;
            this.pnlRankOfTeams.GradientTopLeft = System.Drawing.Color.White;
            this.pnlRankOfTeams.GradientTopRight = System.Drawing.Color.White;
            this.pnlRankOfTeams.Location = new System.Drawing.Point(0, 82);
            this.pnlRankOfTeams.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRankOfTeams.Name = "pnlRankOfTeams";
            this.pnlRankOfTeams.Quality = 10;
            this.pnlRankOfTeams.Size = new System.Drawing.Size(872, 459);
            this.pnlRankOfTeams.TabIndex = 17;
            // 
            // frmListPlayerToScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(872, 629);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.pnlRankOfTeams);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListPlayerToScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Player To Score";
            this.Load += new System.EventHandler(this.frmListPlayerToScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPlayerToScore)).EndInit();
            this.pnlRankOfTeams.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintReport;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private System.Windows.Forms.PictureBox picCreateSchedule;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvListPlayerToScore;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlRankOfTeams;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNumberOfGoals;
    }
}