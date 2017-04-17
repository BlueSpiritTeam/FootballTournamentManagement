namespace Footbal.UI
{
    partial class AddTeam
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
            this.btAdd = new System.Windows.Forms.Button();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.lbTeamName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStadium = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(197, 218);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbTeamName
            // 
            this.tbTeamName.Location = new System.Drawing.Point(82, 54);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(190, 20);
            this.tbTeamName.TabIndex = 1;
            // 
            // lbTeamName
            // 
            this.lbTeamName.AutoSize = true;
            this.lbTeamName.Location = new System.Drawing.Point(12, 57);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(68, 13);
            this.lbTeamName.TabIndex = 2;
            this.lbTeamName.Text = "Team Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stadium:";
            // 
            // tbStadium
            // 
            this.tbStadium.Location = new System.Drawing.Point(82, 110);
            this.tbStadium.Name = "tbStadium";
            this.tbStadium.Size = new System.Drawing.Size(190, 20);
            this.tbStadium.TabIndex = 1;
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTeamName);
            this.Controls.Add(this.tbStadium);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.btAdd);
            this.Name = "AddTeam";
            this.Text = "AddTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.Label lbTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStadium;
    }
}