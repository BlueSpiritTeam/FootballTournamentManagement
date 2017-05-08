using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class frmTournament : Form
    {
        public frmTournament()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGeneral general = new frmGeneral();
            general.ShowDialog();
            this.Close();
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMatchSchedule match_schedule = new frmMatchSchedule();
            match_schedule.ShowDialog();
            this.Close();
        }

        private void btnCreateNewTournament_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewTournament new_tournament = new frmNewTournament();
            new_tournament.ShowDialog();
            this.Close();
        }
    }
}
