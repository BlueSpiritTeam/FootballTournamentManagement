namespace SourceCode.Views
{
    partial class frmReportRankOfClub
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
            this.reportViewer_RankOfClubs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_RankOfClubs
            // 
            this.reportViewer_RankOfClubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_RankOfClubs.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_RankOfClubs.Name = "reportViewer_RankOfClubs";
            this.reportViewer_RankOfClubs.Size = new System.Drawing.Size(1045, 631);
            this.reportViewer_RankOfClubs.TabIndex = 0;
            // 
            // frmReportRankOfClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 631);
            this.Controls.Add(this.reportViewer_RankOfClubs);
            this.Name = "frmReportRankOfClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportMatchResult";
            this.Load += new System.EventHandler(this.frmReportRankOfClub_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_RankOfClubs;
    }
}