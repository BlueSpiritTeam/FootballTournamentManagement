namespace SourceCode
{
    partial class frmTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTournament));
            this.pnlTournamentContent = new System.Windows.Forms.Panel();
            this.btnFinish = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picTournament = new System.Windows.Forms.PictureBox();
            this.btn_recording = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCreateSchedule = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlTournamentContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTournament)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTournamentContent
            // 
            this.pnlTournamentContent.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlTournamentContent.Controls.Add(this.btnFinish);
            this.pnlTournamentContent.Controls.Add(this.picTournament);
            this.pnlTournamentContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTournamentContent.Location = new System.Drawing.Point(0, 0);
            this.pnlTournamentContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTournamentContent.Name = "pnlTournamentContent";
            this.pnlTournamentContent.Size = new System.Drawing.Size(176, 271);
            this.pnlTournamentContent.TabIndex = 10;
            // 
            // btnFinish
            // 
            this.btnFinish.Activecolor = System.Drawing.Color.White;
            this.btnFinish.BackColor = System.Drawing.Color.White;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinish.BorderRadius = 3;
            this.btnFinish.ButtonText = "Finish";
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.DisabledColor = System.Drawing.Color.Gray;
            this.btnFinish.Iconcolor = System.Drawing.Color.White;
            this.btnFinish.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFinish.Iconimage")));
            this.btnFinish.Iconimage_right = null;
            this.btnFinish.Iconimage_right_Selected = null;
            this.btnFinish.Iconimage_Selected = null;
            this.btnFinish.IconMarginLeft = 1;
            this.btnFinish.IconMarginRight = 0;
            this.btnFinish.IconRightVisible = false;
            this.btnFinish.IconRightZoom = 0D;
            this.btnFinish.IconVisible = true;
            this.btnFinish.IconZoom = 90D;
            this.btnFinish.IsTab = false;
            this.btnFinish.Location = new System.Drawing.Point(3, 165);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Normalcolor = System.Drawing.Color.White;
            this.btnFinish.OnHovercolor = System.Drawing.Color.Lime;
            this.btnFinish.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.selected = true;
            this.btnFinish.Size = new System.Drawing.Size(170, 66);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "Finish";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinish.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnFinish.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // picTournament
            // 
            this.picTournament.BackColor = System.Drawing.Color.SeaGreen;
            this.picTournament.Image = ((System.Drawing.Image)(resources.GetObject("picTournament.Image")));
            this.picTournament.Location = new System.Drawing.Point(31, 28);
            this.picTournament.Margin = new System.Windows.Forms.Padding(2);
            this.picTournament.Name = "picTournament";
            this.picTournament.Size = new System.Drawing.Size(126, 111);
            this.picTournament.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTournament.TabIndex = 1;
            this.picTournament.TabStop = false;
            // 
            // btn_recording
            // 
            this.btn_recording.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_recording.color = System.Drawing.Color.SeaGreen;
            this.btn_recording.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btn_recording.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_recording.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recording.ForeColor = System.Drawing.Color.White;
            this.btn_recording.Image = ((System.Drawing.Image)(resources.GetObject("btn_recording.Image")));
            this.btn_recording.ImagePosition = 14;
            this.btn_recording.ImageZoom = 50;
            this.btn_recording.LabelPosition = 30;
            this.btn_recording.LabelText = "Recording    ";
            this.btn_recording.Location = new System.Drawing.Point(240, 42);
            this.btn_recording.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_recording.Name = "btn_recording";
            this.btn_recording.Size = new System.Drawing.Size(255, 163);
            this.btn_recording.TabIndex = 11;
            this.btn_recording.Click += new System.EventHandler(this.btn_recording_Click);
            // 
            // btnCreateSchedule
            // 
            this.btnCreateSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateSchedule.color = System.Drawing.Color.SeaGreen;
            this.btnCreateSchedule.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateSchedule.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSchedule.ForeColor = System.Drawing.Color.White;
            this.btnCreateSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateSchedule.Image")));
            this.btnCreateSchedule.ImagePosition = 14;
            this.btnCreateSchedule.ImageZoom = 50;
            this.btnCreateSchedule.LabelPosition = 30;
            this.btnCreateSchedule.LabelText = "Match Schedule       ";
            this.btnCreateSchedule.Location = new System.Drawing.Point(501, 42);
            this.btnCreateSchedule.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCreateSchedule.Name = "btnCreateSchedule";
            this.btnCreateSchedule.Size = new System.Drawing.Size(255, 163);
            this.btnCreateSchedule.TabIndex = 12;
            this.btnCreateSchedule.Click += new System.EventHandler(this.btnCreateSchedule_Click);
            // 
            // frmTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 271);
            this.Controls.Add(this.btnCreateSchedule);
            this.Controls.Add(this.btn_recording);
            this.Controls.Add(this.pnlTournamentContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTournament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament";
            this.pnlTournamentContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTournament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTournamentContent;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinish;
        private System.Windows.Forms.PictureBox picTournament;
        private Bunifu.Framework.UI.BunifuTileButton btn_recording;
        private Bunifu.Framework.UI.BunifuTileButton btnCreateSchedule;
    }
}