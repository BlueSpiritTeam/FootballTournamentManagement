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
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string teamStadium = this.tbStadium.Text;
            string teamName = this.tbTeamName.Text;
            if (string.IsNullOrWhiteSpace(teamName))
            {
                MessageBox.Show("Please enter team name.");
                this.tbTeamName.SelectAll();
                this.tbTeamName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(teamStadium))
            {
                MessageBox.Show("Please enter stadium.");
                this.tbStadium.SelectAll();
                this.tbStadium.Focus();
                return;
            }

            var db = new Database.Db();

            db.CreateTeam(new Database.Team
            {
                Name = teamName.Trim(),
                Stadium = teamStadium.Trim(),
            });
            this.Close();
        }
    }
}
