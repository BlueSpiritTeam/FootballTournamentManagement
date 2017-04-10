namespace Footbal.UI
{
    partial class EditTeam
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
            this.lbTeamName = new System.Windows.Forms.Label();
            this.tbTeamNameUpdate = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStadiumUpdate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTeamName
            // 
            this.lbTeamName.AutoSize = true;
            this.lbTeamName.Location = new System.Drawing.Point(32, 62);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(68, 13);
            this.lbTeamName.TabIndex = 0;
            this.lbTeamName.Text = "Team Name:";
            // 
            // tbTeamNameUpdate
            // 
            this.tbTeamNameUpdate.Location = new System.Drawing.Point(116, 62);
            this.tbTeamNameUpdate.Name = "tbTeamNameUpdate";
            this.tbTeamNameUpdate.Size = new System.Drawing.Size(174, 20);
            this.tbTeamNameUpdate.TabIndex = 1;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(62, 227);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(143, 227);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stadium:";
            // 
            // tbStadiumUpdate
            // 
            this.tbStadiumUpdate.Location = new System.Drawing.Point(116, 96);
            this.tbStadiumUpdate.Name = "tbStadiumUpdate";
            this.tbStadiumUpdate.Size = new System.Drawing.Size(174, 20);
            this.tbStadiumUpdate.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.AcceptButton = this.btUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.tbStadiumUpdate);
            this.Controls.Add(this.tbTeamNameUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTeamName);
            this.Name = "Edit";
            this.Text = "Edit Team";
            this.Load += new System.EventHandler(this.UpdateTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTeamName;
        private System.Windows.Forms.TextBox tbTeamNameUpdate;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStadiumUpdate;
        private System.Windows.Forms.Button button1;
    }
}