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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportRankOfClub));
            this.reportViewer_RankOfClubs = new Microsoft.Reporting.WinForms.ReportViewer();
            this.footballTournamentManagerDataSet3 = new SourceCode.FootballTournamentManagerDataSet3();
            this.loadRankOfClubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadRankOfClubTableAdapter = new SourceCode.FootballTournamentManagerDataSet3TableAdapters.LoadRankOfClubTableAdapter();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.footballTournamentManagerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadRankOfClubBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer_RankOfClubs
            // 
            reportDataSource2.Name = "RpRankOfClub";
            reportDataSource2.Value = this.loadRankOfClubBindingSource;
            this.reportViewer_RankOfClubs.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer_RankOfClubs.LocalReport.ReportEmbeddedResource = "SourceCode.Views.Report2.rdlc";
            this.reportViewer_RankOfClubs.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_RankOfClubs.Name = "reportViewer_RankOfClubs";
            this.reportViewer_RankOfClubs.Size = new System.Drawing.Size(1207, 546);
            this.reportViewer_RankOfClubs.TabIndex = 0;
            // 
            // footballTournamentManagerDataSet3
            // 
            this.footballTournamentManagerDataSet3.DataSetName = "FootballTournamentManagerDataSet3";
            this.footballTournamentManagerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadRankOfClubBindingSource
            // 
            this.loadRankOfClubBindingSource.DataMember = "LoadRankOfClub";
            this.loadRankOfClubBindingSource.DataSource = this.footballTournamentManagerDataSet3;
            // 
            // loadRankOfClubTableAdapter
            // 
            this.loadRankOfClubTableAdapter.ClearBeforeFill = true;
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
            this.btnCancel.Location = new System.Drawing.Point(515, 565);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.White;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Lime;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(227, 52);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmReportRankOfClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1208, 631);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.reportViewer_RankOfClubs);
            this.Name = "frmReportRankOfClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportMatchResult";
            this.Load += new System.EventHandler(this.frmReportRankOfClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.footballTournamentManagerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadRankOfClubBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_RankOfClubs;
        private FootballTournamentManagerDataSet3 footballTournamentManagerDataSet3;
        private System.Windows.Forms.BindingSource loadRankOfClubBindingSource;
        private FootballTournamentManagerDataSet3TableAdapters.LoadRankOfClubTableAdapter loadRankOfClubTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
    }
}