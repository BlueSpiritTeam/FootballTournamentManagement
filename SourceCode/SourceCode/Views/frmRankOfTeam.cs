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
    public partial class frmRankOfTeam : Form
    {
        public frmRankOfTeam()
        {
            InitializeComponent();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmTournamentReport tournament_report = new frmTournamentReport();
            tournament_report.ShowDialog();
            this.Close();
        }
    }
}
