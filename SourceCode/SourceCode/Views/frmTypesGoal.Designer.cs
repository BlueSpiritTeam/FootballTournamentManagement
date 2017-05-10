namespace SourceCode.Views
{
    partial class frmTypesGoal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypesGoal));
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_GoalName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_TypeGoalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.White;
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(106, 99);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 43);
            this.btnSave.TabIndex = 58;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt_GoalName
            // 
            this.txt_GoalName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GoalName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_GoalName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GoalName.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_GoalName.Location = new System.Drawing.Point(200, 54);
            this.txt_GoalName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_GoalName.Name = "txt_GoalName";
            this.txt_GoalName.Size = new System.Drawing.Size(227, 26);
            this.txt_GoalName.TabIndex = 56;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(51, 60);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(99, 18);
            this.bunifuCustomLabel1.TabIndex = 59;
            this.bunifuCustomLabel1.Text = "Add new type:";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.White;
            this.btnCancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.Location = new System.Drawing.Point(254, 99);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 43);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txt_TypeGoalID
            // 
            this.txt_TypeGoalID.Location = new System.Drawing.Point(200, 23);
            this.txt_TypeGoalID.Name = "txt_TypeGoalID";
            this.txt_TypeGoalID.Size = new System.Drawing.Size(227, 20);
            this.txt_TypeGoalID.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "ID";
            // 
            // frmTypesGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 205);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TypeGoalID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_GoalName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmTypesGoal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Types Goal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_GoalName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private System.Windows.Forms.TextBox txt_TypeGoalID;
        private System.Windows.Forms.Label label1;
    }
}