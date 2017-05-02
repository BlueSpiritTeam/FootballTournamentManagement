namespace SourceCode
{
    partial class frmTournamentReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTournamentReport));
            this.pnlTournamentContent = new System.Windows.Forms.Panel();
            this.btnFinish = new Bunifu.Framework.UI.BunifuFlatButton();
            this.picTournament = new System.Windows.Forms.PictureBox();
            this.btnRankOfTeam = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMatchResult = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnListPlayerToScore = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnReviewMatchResult = new Bunifu.Framework.UI.BunifuTileButton();
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
            this.pnlTournamentContent.Size = new System.Drawing.Size(234, 511);
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
            this.picTournament.Location = new System.Drawing.Point(49, 35);
            this.picTournament.Name = "picTournament";
            this.picTournament.Size = new System.Drawing.Size(168, 137);
            this.picTournament.TabIndex = 1;
            this.picTournament.TabStop = false;
            // 
            // btnRankOfTeam
            // 
            this.btnRankOfTeam.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRankOfTeam.color = System.Drawing.Color.SeaGreen;
            this.btnRankOfTeam.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnRankOfTeam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRankOfTeam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRankOfTeam.ForeColor = System.Drawing.Color.White;
            this.btnRankOfTeam.Image = ((System.Drawing.Image)(resources.GetObject("btnRankOfTeam.Image")));
            this.btnRankOfTeam.ImagePosition = 14;
            this.btnRankOfTeam.ImageZoom = 50;
            this.btnRankOfTeam.LabelPosition = 30;
            this.btnRankOfTeam.LabelText = "Rank Of Teams";
            this.btnRankOfTeam.Location = new System.Drawing.Point(266, 244);
            this.btnRankOfTeam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRankOfTeam.Name = "btnRankOfTeam";
            this.btnRankOfTeam.Size = new System.Drawing.Size(340, 201);
            this.btnRankOfTeam.TabIndex = 15;
            this.btnRankOfTeam.Click += new System.EventHandler(this.btnRankOfTeam_Click);
            // 
            // btnMatchResult
            // 
            this.btnMatchResult.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMatchResult.color = System.Drawing.Color.SeaGreen;
            this.btnMatchResult.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnMatchResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatchResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchResult.ForeColor = System.Drawing.Color.White;
            this.btnMatchResult.Image = ((System.Drawing.Image)(resources.GetObject("btnMatchResult.Image")));
            this.btnMatchResult.ImagePosition = 14;
            this.btnMatchResult.ImageZoom = 50;
            this.btnMatchResult.LabelPosition = 30;
            this.btnMatchResult.LabelText = "Record Match Result";
            this.btnMatchResult.Location = new System.Drawing.Point(266, 35);
            this.btnMatchResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMatchResult.Name = "btnMatchResult";
            this.btnMatchResult.Size = new System.Drawing.Size(340, 201);
            this.btnMatchResult.TabIndex = 14;
            this.btnMatchResult.Click += new System.EventHandler(this.btnMatchResult_Click);
            // 
            // btnListPlayerToScore
            // 
            this.btnListPlayerToScore.BackColor = System.Drawing.Color.SeaGreen;
            this.btnListPlayerToScore.color = System.Drawing.Color.SeaGreen;
            this.btnListPlayerToScore.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnListPlayerToScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListPlayerToScore.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPlayerToScore.ForeColor = System.Drawing.Color.White;
            this.btnListPlayerToScore.Image = ((System.Drawing.Image)(resources.GetObject("btnListPlayerToScore.Image")));
            this.btnListPlayerToScore.ImagePosition = 14;
            this.btnListPlayerToScore.ImageZoom = 50;
            this.btnListPlayerToScore.LabelPosition = 30;
            this.btnListPlayerToScore.LabelText = "List Player To Score";
            this.btnListPlayerToScore.Location = new System.Drawing.Point(614, 244);
            this.btnListPlayerToScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListPlayerToScore.Name = "btnListPlayerToScore";
            this.btnListPlayerToScore.Size = new System.Drawing.Size(340, 201);
            this.btnListPlayerToScore.TabIndex = 16;
            this.btnListPlayerToScore.Click += new System.EventHandler(this.btnListPlayerToScore_Click);
            // 
            // btnReviewMatchResult
            // 
            this.btnReviewMatchResult.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReviewMatchResult.color = System.Drawing.Color.SeaGreen;
            this.btnReviewMatchResult.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnReviewMatchResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviewMatchResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewMatchResult.ForeColor = System.Drawing.Color.White;
            this.btnReviewMatchResult.Image = ((System.Drawing.Image)(resources.GetObject("btnReviewMatchResult.Image")));
            this.btnReviewMatchResult.ImagePosition = 14;
            this.btnReviewMatchResult.ImageZoom = 50;
            this.btnReviewMatchResult.LabelPosition = 30;
            this.btnReviewMatchResult.LabelText = "Review Match Result";
            this.btnReviewMatchResult.Location = new System.Drawing.Point(614, 35);
            this.btnReviewMatchResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReviewMatchResult.Name = "btnReviewMatchResult";
            this.btnReviewMatchResult.Size = new System.Drawing.Size(340, 201);
            this.btnReviewMatchResult.TabIndex = 17;
            this.btnReviewMatchResult.Click += new System.EventHandler(this.btnReviewMatchResult_Click);
            // 
            // frmTournamentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1019, 511);
            this.Controls.Add(this.btnReviewMatchResult);
            this.Controls.Add(this.btnListPlayerToScore);
            this.Controls.Add(this.pnlTournamentContent);
            this.Controls.Add(this.btnRankOfTeam);
            this.Controls.Add(this.btnMatchResult);
            this.Name = "frmTournamentReport";
            this.Text = "frmTournamentReport";
            this.pnlTournamentContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTournament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTournamentContent;
        private Bunifu.Framework.UI.BunifuFlatButton btnFinish;
        private System.Windows.Forms.PictureBox picTournament;
        private Bunifu.Framework.UI.BunifuTileButton btnRankOfTeam;
        private Bunifu.Framework.UI.BunifuTileButton btnMatchResult;
        private Bunifu.Framework.UI.BunifuTileButton btnListPlayerToScore;
        private Bunifu.Framework.UI.BunifuTileButton btnReviewMatchResult;
    }
}