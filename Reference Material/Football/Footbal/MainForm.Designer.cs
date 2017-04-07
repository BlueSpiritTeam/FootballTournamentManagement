namespace Footbal
{
    partial class MainForm
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
            this.btAddTeam = new System.Windows.Forms.Button();
            this.btUppdateTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAddTeam
            // 
            this.btAddTeam.Location = new System.Drawing.Point(91, 56);
            this.btAddTeam.Name = "btAddTeam";
            this.btAddTeam.Size = new System.Drawing.Size(118, 23);
            this.btAddTeam.TabIndex = 0;
            this.btAddTeam.Text = "Add Team";
            this.btAddTeam.UseVisualStyleBackColor = true;
            this.btAddTeam.Click += new System.EventHandler(this.btAddTeam_Click);
            // 
            // btUppdateTeam
            // 
            this.btUppdateTeam.Location = new System.Drawing.Point(91, 98);
            this.btUppdateTeam.Name = "btUppdateTeam";
            this.btUppdateTeam.Size = new System.Drawing.Size(118, 23);
            this.btUppdateTeam.TabIndex = 0;
            this.btUppdateTeam.Text = "View Team List";
            this.btUppdateTeam.Click += new System.EventHandler(this.btUppdateTeam_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btUppdateTeam);
            this.Controls.Add(this.btAddTeam);
            this.Name = "MainForm";
            this.Text = "Football";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddTeam;
        private System.Windows.Forms.Button btUppdateTeam;
    }
}

