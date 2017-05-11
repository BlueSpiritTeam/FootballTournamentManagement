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
            this.btnShowResult = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintReport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvListPlayerToScore = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNumberOfGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRankOfTeams = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlDateOfCompetition = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picCreateSchedule = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPlayerToScore)).BeginInit();
            this.pnlRankOfTeams.SuspendLayout();
            this.pnlDateOfCompetition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
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
            this.btnShowResult.Location = new System.Drawing.Point(56, 445);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Normalcolor = System.Drawing.Color.White;
            this.btnShowResult.OnHovercolor = System.Drawing.Color.Lime;
            this.btnShowResult.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnShowResult.selected = true;
            this.btnShowResult.Size = new System.Drawing.Size(170, 42);
            this.btnShowResult.TabIndex = 19;
            this.btnShowResult.Text = "Show Result";
            this.btnShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowResult.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnShowResult.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnPrintReport.Location = new System.Drawing.Point(241, 445);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Normalcolor = System.Drawing.Color.White;
            this.btnPrintReport.OnHovercolor = System.Drawing.Color.Lime;
            this.btnPrintReport.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnPrintReport.selected = true;
            this.btnPrintReport.Size = new System.Drawing.Size(170, 42);
            this.btnPrintReport.TabIndex = 18;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintReport.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnPrintReport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgvListPlayerToScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvListPlayerToScore.DoubleBuffered = true;
            this.dgvListPlayerToScore.EnableHeadersVisualStyles = false;
            this.dgvListPlayerToScore.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvListPlayerToScore.HeaderBgColor = System.Drawing.Color.White;
            this.dgvListPlayerToScore.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvListPlayerToScore.Location = new System.Drawing.Point(0, 0);
            this.dgvListPlayerToScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListPlayerToScore.Name = "dgvListPlayerToScore";
            this.dgvListPlayerToScore.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvListPlayerToScore.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListPlayerToScore.RowTemplate.Height = 24;
            this.dgvListPlayerToScore.Size = new System.Drawing.Size(654, 293);
            this.dgvListPlayerToScore.TabIndex = 2;
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
            this.pnlRankOfTeams.Location = new System.Drawing.Point(0, 126);
            this.pnlRankOfTeams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRankOfTeams.Name = "pnlRankOfTeams";
            this.pnlRankOfTeams.Quality = 10;
            this.pnlRankOfTeams.Size = new System.Drawing.Size(654, 293);
            this.pnlRankOfTeams.TabIndex = 17;
            // 
            // cmbFrom
            // 
            this.cmbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFrom.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(88, 14);
            this.cmbFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(174, 28);
            this.cmbFrom.TabIndex = 64;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 20);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(44, 18);
            this.bunifuCustomLabel1.TabIndex = 63;
            this.bunifuCustomLabel1.Text = "From";
            // 
            // pnlDateOfCompetition
            // 
            this.pnlDateOfCompetition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDateOfCompetition.BackgroundImage")));
            this.pnlDateOfCompetition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDateOfCompetition.Controls.Add(this.cmbTo);
            this.pnlDateOfCompetition.Controls.Add(this.bunifuCustomLabel2);
            this.pnlDateOfCompetition.Controls.Add(this.cmbFrom);
            this.pnlDateOfCompetition.Controls.Add(this.bunifuCustomLabel1);
            this.pnlDateOfCompetition.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDateOfCompetition.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlDateOfCompetition.GradientBottomRight = System.Drawing.Color.White;
            this.pnlDateOfCompetition.GradientTopLeft = System.Drawing.Color.White;
            this.pnlDateOfCompetition.GradientTopRight = System.Drawing.Color.White;
            this.pnlDateOfCompetition.Location = new System.Drawing.Point(0, 67);
            this.pnlDateOfCompetition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDateOfCompetition.Name = "pnlDateOfCompetition";
            this.pnlDateOfCompetition.Quality = 10;
            this.pnlDateOfCompetition.Size = new System.Drawing.Size(654, 59);
            this.pnlDateOfCompetition.TabIndex = 16;
            // 
            // cmbTo
            // 
            this.cmbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTo.ForeColor = System.Drawing.Color.SeaGreen;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(352, 14);
            this.cmbTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(172, 28);
            this.cmbTo.TabIndex = 66;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(296, 20);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(26, 18);
            this.bunifuCustomLabel2.TabIndex = 65;
            this.bunifuCustomLabel2.Text = "To";
            // 
            // bunifuCustomLabel
            // 
            this.bunifuCustomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel.AutoSize = true;
            this.bunifuCustomLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel.Location = new System.Drawing.Point(174, 17);
            this.bunifuCustomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel.Name = "bunifuCustomLabel";
            this.bunifuCustomLabel.Size = new System.Drawing.Size(304, 37);
            this.bunifuCustomLabel.TabIndex = 60;
            this.bunifuCustomLabel.Text = "List Player To Score";
            // 
            // picCreateSchedule
            // 
            this.picCreateSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.picCreateSchedule.Image = ((System.Drawing.Image)(resources.GetObject("picCreateSchedule.Image")));
            this.picCreateSchedule.Location = new System.Drawing.Point(128, 6);
            this.picCreateSchedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCreateSchedule.Name = "picCreateSchedule";
            this.picCreateSchedule.Size = new System.Drawing.Size(41, 46);
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
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Quality = 10;
            this.pnlTitle.Size = new System.Drawing.Size(654, 67);
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
            this.btnCancel.Location = new System.Drawing.Point(432, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.White;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Lime;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(170, 42);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmListPlayerToScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 511);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.pnlRankOfTeams);
            this.Controls.Add(this.pnlDateOfCompetition);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnCancel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "frmListPlayerToScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Player To Score";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPlayerToScore)).EndInit();
            this.pnlRankOfTeams.ResumeLayout(false);
            this.pnlDateOfCompetition.ResumeLayout(false);
            this.pnlDateOfCompetition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnShowResult;
        private Bunifu.Framework.UI.BunifuFlatButton btnPrintReport;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvListPlayerToScore;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlRankOfTeams;
        private System.Windows.Forms.ComboBox cmbFrom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlDateOfCompetition;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private System.Windows.Forms.PictureBox picCreateSchedule;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.ComboBox cmbTo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNumberOfGoals;
    }
}