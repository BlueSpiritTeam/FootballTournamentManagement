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
    public partial class frmReviewMatchResult : Form
    {
        public frmReviewMatchResult()
        {
            InitializeComponent();
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            pnlMatchResult.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTournamentReport tournament_report = new frmTournamentReport();
            tournament_report.ShowDialog();
            this.Close();
        }

        private void frmReviewMatchResult_Load(object sender, EventArgs e)
        {
            pnlMatchResult.Visible = false;
        }
    }
}
