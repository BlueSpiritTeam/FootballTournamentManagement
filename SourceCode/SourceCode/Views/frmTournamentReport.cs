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
    public partial class frmTournamentReport : Form
    {
        public frmTournamentReport()
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

        private void btnMatchResult_Click(object sender, EventArgs e)
        {

        }

        private void btnReviewMatchResult_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReviewMatchResult review_match_result = new frmReviewMatchResult();
            review_match_result.ShowDialog();
            this.Close();
        }

        private void btnRankOfTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRankOfTeam rank_of_team = new frmRankOfTeam();
            rank_of_team.ShowDialog();
            this.Close();
        }

        private void btnListPlayerToScore_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListPlayerToScore list_player_to_score = new frmListPlayerToScore();
            list_player_to_score.ShowDialog();
            this.Close();
        }
    }
}
