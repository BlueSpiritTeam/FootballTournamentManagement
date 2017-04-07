using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Footbal.UI
{
    public partial class EditTeam : Form
    {
        public EditTeam()
        {
            InitializeComponent();
        }
        public int TeamId { get; set; }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            
            string teamName = this.tbTeamNameUpdate.Text;
            string stadium = this.tbStadiumUpdate.Text;
            if(string.IsNullOrWhiteSpace(teamName))
            {
                MessageBox.Show("Please enter team name!");
                this.tbTeamNameUpdate.SelectAll();
                this.tbTeamNameUpdate.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(stadium))
            {
                MessageBox.Show("Please enter a stadium!");
                this.tbStadiumUpdate.SelectAll();
                this.tbStadiumUpdate.Focus();
                return;
            }
            var db = new Database.Db();
            int updatedCount = db.UpdateTeam(new Database.Team
            {
                Id = this.TeamId,
                Name = teamName.Trim(),
                Stadium = stadium.Trim(),
            });
            if (updatedCount > 0)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
        }

        private void UpdateTeam_Load(object sender, EventArgs e)
        {
            var db = new Database.Db();
            DataSet ds = db.GetTeam(TeamId);
            tbTeamNameUpdate.Clear();
            tbTeamNameUpdate.Text = ds.Tables[0].Rows[0][1].ToString();
            tbStadiumUpdate.Clear();
            tbStadiumUpdate.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var db = new Database.Db();
            int deleteCount = db.DeleteTeam(this.TeamId);
            if (deleteCount > 0)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;

        }
    }
}
