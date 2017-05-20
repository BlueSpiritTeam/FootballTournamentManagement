namespace SourceCode.Views
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.pnlTournamentContent = new System.Windows.Forms.Panel();
            this.btnFinish = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picTournament = new System.Windows.Forms.PictureBox();
            this.btnApplicationSetting = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTournamentSetting = new Bunifu.Framework.UI.BunifuTileButton();
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
            this.pnlTournamentContent.Name = "pnlTournamentContent";
            this.pnlTournamentContent.Size = new System.Drawing.Size(234, 299);
            this.pnlTournamentContent.TabIndex = 13;
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
            this.btnFinish.Font = new System.Drawing.Font("Copperplate Gothic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnFinish.Location = new System.Drawing.Point(4, 203);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Normalcolor = System.Drawing.Color.White;
            this.btnFinish.OnHovercolor = System.Drawing.Color.Lime;
            this.btnFinish.OnHoverTextColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.selected = true;
            this.btnFinish.Size = new System.Drawing.Size(226, 81);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "Finish";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinish.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnFinish.TextFont = new System.Drawing.Font("Source Sans Pro Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // picTournament
            // 
            this.picTournament.BackColor = System.Drawing.Color.SeaGreen;
            this.picTournament.Image = ((System.Drawing.Image)(resources.GetObject("picTournament.Image")));
            this.picTournament.Location = new System.Drawing.Point(41, 35);
            this.picTournament.Name = "picTournament";
            this.picTournament.Size = new System.Drawing.Size(168, 137);
            this.picTournament.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTournament.TabIndex = 1;
            this.picTournament.TabStop = false;
            // 
            // btnApplicationSetting
            // 
            this.btnApplicationSetting.BackColor = System.Drawing.Color.SeaGreen;
            this.btnApplicationSetting.color = System.Drawing.Color.SeaGreen;
            this.btnApplicationSetting.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnApplicationSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicationSetting.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicationSetting.ForeColor = System.Drawing.Color.White;
            this.btnApplicationSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicationSetting.Image")));
            this.btnApplicationSetting.ImagePosition = 14;
            this.btnApplicationSetting.ImageZoom = 50;
            this.btnApplicationSetting.LabelPosition = 30;
            this.btnApplicationSetting.LabelText = "Application Setting";
            this.btnApplicationSetting.Location = new System.Drawing.Point(679, 51);
            this.btnApplicationSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApplicationSetting.Name = "btnApplicationSetting";
            this.btnApplicationSetting.Size = new System.Drawing.Size(340, 201);
            this.btnApplicationSetting.TabIndex = 15;
            // 
            // btnTournamentSetting
            // 
            this.btnTournamentSetting.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTournamentSetting.color = System.Drawing.Color.SeaGreen;
            this.btnTournamentSetting.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnTournamentSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTournamentSetting.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTournamentSetting.ForeColor = System.Drawing.Color.White;
            this.btnTournamentSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnTournamentSetting.Image")));
            this.btnTournamentSetting.ImagePosition = 14;
            this.btnTournamentSetting.ImageZoom = 50;
            this.btnTournamentSetting.LabelPosition = 30;
            this.btnTournamentSetting.LabelText = "Tournament Setting";
            this.btnTournamentSetting.Location = new System.Drawing.Point(331, 51);
            this.btnTournamentSetting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTournamentSetting.Name = "btnTournamentSetting";
            this.btnTournamentSetting.Size = new System.Drawing.Size(340, 201);
            this.btnTournamentSetting.TabIndex = 14;
            this.btnTournamentSetting.Click += new System.EventHandler(this.btnTournamentSetting_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 299);
            this.Controls.Add(this.pnlTournamentContent);
            this.Controls.Add(this.btnApplicationSetting);
            this.Controls.Add(this.btnTournamentSetting);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetting";
            this.pnlTournamentContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTournament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTournamentContent;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinish;
        private System.Windows.Forms.PictureBox picTournament;
        private Bunifu.Framework.UI.BunifuTileButton btnApplicationSetting;
        private Bunifu.Framework.UI.BunifuTileButton btnTournamentSetting;
    }
}