namespace SourceCode.Views
{
    partial class frmReportListPlayerToScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportListPlayerToScore));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listPlayerToScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballTournamentManagerDataSet1 = new SourceCode.FootballTournamentManagerDataSet1();
            this.listPlayerToScoreTableAdapter = new SourceCode.FootballTournamentManagerDataSet1TableAdapters.ListPlayerToScoreTableAdapter();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reportViewer_ListPlayer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.listPlayerToScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballTournamentManagerDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // listPlayerToScoreBindingSource
            // 
            this.listPlayerToScoreBindingSource.DataMember = "ListPlayerToScore";
            this.listPlayerToScoreBindingSource.DataSource = this.footballTournamentManagerDataSet1;
            // 
            // footballTournamentManagerDataSet1
            // 
            this.footballTournamentManagerDataSet1.DataSetName = "FootballTournamentManagerDataSet1";
            this.footballTournamentManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listPlayerToScoreTableAdapter
            // 
            this.listPlayerToScoreTableAdapter.ClearBeforeFill = true;
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
            this.btnCancel.Location = new System.Drawing.Point(436, 565);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.White;
            this.btnCancel.OnHovercolor = System.Drawing.Color.Lime;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.selected = true;
            this.btnCancel.Size = new System.Drawing.Size(227, 52);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // reportViewer_ListPlayer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listPlayerToScoreBindingSource;
            this.reportViewer_ListPlayer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_ListPlayer.LocalReport.ReportEmbeddedResource = "SourceCode.Views.Report1.rdlc";
            this.reportViewer_ListPlayer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_ListPlayer.Name = "reportViewer_ListPlayer";
            this.reportViewer_ListPlayer.Size = new System.Drawing.Size(1052, 557);
            this.reportViewer_ListPlayer.TabIndex = 23;
            // 
            // frmReportListPlayerToScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1052, 631);
            this.Controls.Add(this.reportViewer_ListPlayer);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmReportListPlayerToScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReportListPlayerToScore";
            this.Load += new System.EventHandler(this.frmReportListPlayerToScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listPlayerToScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballTournamentManagerDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FootballTournamentManagerDataSet1 footballTournamentManagerDataSet1;
        private System.Windows.Forms.BindingSource listPlayerToScoreBindingSource;
        private FootballTournamentManagerDataSet1TableAdapters.ListPlayerToScoreTableAdapter listPlayerToScoreTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_ListPlayer;
    }
}