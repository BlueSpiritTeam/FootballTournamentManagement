namespace SourceCode
{
    partial class frmMatchSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatchSchedule));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picCreateSchedule = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pnlMatchRound = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvMatchResult = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.OrderingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreateMatch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlFooter = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnFinish = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlMatchRound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchResult)).BeginInit();
            this.pnlFooter.SuspendLayout();
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
            this.pnlTitle.Size = new System.Drawing.Size(935, 95);
            this.pnlTitle.TabIndex = 0;
            // 
            // bunifuCustomLabel
            // 
            this.bunifuCustomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel.AutoSize = true;
            this.bunifuCustomLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel.Location = new System.Drawing.Point(247, 30);
            this.bunifuCustomLabel.Name = "bunifuCustomLabel";
            this.bunifuCustomLabel.Size = new System.Drawing.Size(568, 44);
            this.bunifuCustomLabel.TabIndex = 56;
            this.bunifuCustomLabel.Text = "Create Match Schedule";
            // 
            // picCreateSchedule
            // 
            this.picCreateSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.picCreateSchedule.Image = ((System.Drawing.Image)(resources.GetObject("picCreateSchedule.Image")));
            this.picCreateSchedule.Location = new System.Drawing.Point(135, 20);
            this.picCreateSchedule.Name = "picCreateSchedule";
            this.picCreateSchedule.Size = new System.Drawing.Size(51, 57);
            this.picCreateSchedule.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCreateSchedule.TabIndex = 0;
            this.picCreateSchedule.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.SeaGreen;
            this.numericUpDown1.Location = new System.Drawing.Point(480, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 36);
            this.numericUpDown1.TabIndex = 1;
            // 
            // pnlMatchRound
            // 
            this.pnlMatchRound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMatchRound.BackgroundImage")));
            this.pnlMatchRound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMatchRound.Controls.Add(this.bunifuCustomLabel1);
            this.pnlMatchRound.Controls.Add(this.numericUpDown1);
            this.pnlMatchRound.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMatchRound.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlMatchRound.GradientBottomRight = System.Drawing.Color.White;
            this.pnlMatchRound.GradientTopLeft = System.Drawing.Color.White;
            this.pnlMatchRound.GradientTopRight = System.Drawing.Color.White;
            this.pnlMatchRound.Location = new System.Drawing.Point(0, 95);
            this.pnlMatchRound.Name = "pnlMatchRound";
            this.pnlMatchRound.Quality = 10;
            this.pnlMatchRound.Size = new System.Drawing.Size(935, 73);
            this.pnlMatchRound.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(276, 20);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(175, 30);
            this.bunifuCustomLabel1.TabIndex = 57;
            this.bunifuCustomLabel1.Text = "Match Round";
            // 
            // dgvMatchResult
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMatchResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMatchResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMatchResult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMatchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderingNumber,
            this.Date,
            this.Time,
            this.HomeTeam,
            this.GuestTeam,
            this.Stadium});
            this.dgvMatchResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMatchResult.DoubleBuffered = true;
            this.dgvMatchResult.EnableHeadersVisualStyles = false;
            this.dgvMatchResult.GridColor = System.Drawing.Color.SeaGreen;
            this.dgvMatchResult.HeaderBgColor = System.Drawing.Color.White;
            this.dgvMatchResult.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvMatchResult.Location = new System.Drawing.Point(0, 168);
            this.dgvMatchResult.Name = "dgvMatchResult";
            this.dgvMatchResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            this.dgvMatchResult.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMatchResult.RowTemplate.Height = 24;
            this.dgvMatchResult.Size = new System.Drawing.Size(935, 426);
            this.dgvMatchResult.TabIndex = 3;
            // 
            // OrderingNumber
            // 
            this.OrderingNumber.HeaderText = "Ordering Number";
            this.OrderingNumber.Name = "OrderingNumber";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // HomeTeam
            // 
            this.HomeTeam.HeaderText = "Home Team";
            this.HomeTeam.Name = "HomeTeam";
            // 
            // GuestTeam
            // 
            this.GuestTeam.HeaderText = "Guest Team";
            this.GuestTeam.Name = "GuestTeam";
            // 
            // Stadium
            // 
            this.Stadium.HeaderText = "Stadium";
            this.Stadium.Name = "Stadium";
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.ActiveBorderThickness = 1;
            this.btnCreateMatch.ActiveCornerRadius = 20;
            this.btnCreateMatch.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCreateMatch.ActiveForecolor = System.Drawing.Color.White;
            this.btnCreateMatch.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreateMatch.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateMatch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateMatch.BackgroundImage")));
            this.btnCreateMatch.ButtonText = "Create Match";
            this.btnCreateMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateMatch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMatch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCreateMatch.IdleBorderThickness = 1;
            this.btnCreateMatch.IdleCornerRadius = 20;
            this.btnCreateMatch.IdleFillColor = System.Drawing.Color.White;
            this.btnCreateMatch.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCreateMatch.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCreateMatch.Location = new System.Drawing.Point(111, 5);
            this.btnCreateMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(178, 60);
            this.btnCreateMatch.TabIndex = 67;
            this.btnCreateMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFooter.BackgroundImage")));
            this.pnlFooter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFooter.Controls.Add(this.btnFinish);
            this.pnlFooter.Controls.Add(this.btnUpdate);
            this.pnlFooter.Controls.Add(this.btnCreateMatch);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlFooter.GradientBottomRight = System.Drawing.Color.White;
            this.pnlFooter.GradientTopLeft = System.Drawing.Color.White;
            this.pnlFooter.GradientTopRight = System.Drawing.Color.White;
            this.pnlFooter.Location = new System.Drawing.Point(0, 600);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Quality = 10;
            this.pnlFooter.Size = new System.Drawing.Size(935, 73);
            this.pnlFooter.TabIndex = 68;
            // 
            // btnFinish
            // 
            this.btnFinish.ActiveBorderThickness = 1;
            this.btnFinish.ActiveCornerRadius = 20;
            this.btnFinish.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.ActiveForecolor = System.Drawing.Color.White;
            this.btnFinish.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.BackColor = System.Drawing.SystemColors.Control;
            this.btnFinish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinish.BackgroundImage")));
            this.btnFinish.ButtonText = "Finish";
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.IdleBorderThickness = 1;
            this.btnFinish.IdleCornerRadius = 20;
            this.btnFinish.IdleFillColor = System.Drawing.Color.White;
            this.btnFinish.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnFinish.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.Location = new System.Drawing.Point(565, 5);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(5);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(178, 60);
            this.btnFinish.TabIndex = 69;
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Update";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdate.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.Location = new System.Drawing.Point(335, 5);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 60);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMatchSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 673);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.dgvMatchResult);
            this.Controls.Add(this.pnlMatchRound);
            this.Controls.Add(this.pnlTitle);
            this.MinimizeBox = false;
            this.Name = "frmMatchSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Match Schedule";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCreateSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlMatchRound.ResumeLayout(false);
            this.pnlMatchRound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchResult)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnlTitle;
        private System.Windows.Forms.PictureBox picCreateSchedule;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlMatchRound;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvMatchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadium;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCreateMatch;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlFooter;
        private Bunifu.Framework.UI.BunifuThinButton2 btnFinish;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
    }
}