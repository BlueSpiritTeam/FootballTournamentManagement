using SourceCode.DAO;
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

        public DataTable LoadReviewMatch()
        {
            DataTable dt = MatchRecordDAO.Instance.LoadMatchReview();
            return dt;
        }
        public void Binding()
        {
            txtHomeClubName.DataBindings.Clear();
            txtHomeClubName.DataBindings.Add("Text", dgvReviewMatch.DataSource, "Home", true, DataSourceUpdateMode.Never);
            txtAwayClubName.DataBindings.Clear();
            txtAwayClubName.DataBindings.Add("Text", dgvReviewMatch.DataSource, "Away", true, DataSourceUpdateMode.Never);
            txtMatchDate.DataBindings.Clear();
            txtMatchDate.DataBindings.Add("Text", dgvReviewMatch.DataSource, "Date", true, DataSourceUpdateMode.Never);
            txtMatchTime.DataBindings.Clear();
            txtMatchTime.DataBindings.Add("Text", dgvReviewMatch.DataSource, "Time", true, DataSourceUpdateMode.Never);
            txtRatio.DataBindings.Clear();
            txtRatio.DataBindings.Add("Text", dgvReviewMatch.DataSource, "Ratio", true, DataSourceUpdateMode.Never);
            txtStadium.DataBindings.Clear();
            txtStadium.DataBindings.Add("Text", dgvReviewMatch.DataSource, "Stadium", true, DataSourceUpdateMode.Never);
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
            dgvReviewMatch.DataSource = LoadReviewMatch();
            Binding();
        }
    }
}
