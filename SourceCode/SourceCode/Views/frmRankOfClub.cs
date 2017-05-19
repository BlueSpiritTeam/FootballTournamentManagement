using SourceCode.DAO;
using SourceCode.Views;
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
        public DataTable LoadAllRankOfClub()
        {
            DataTable dt = ClubDAO.Instance.LoadRankOfClub();
            return dt;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmTournamentReport tournament_report = new frmTournamentReport();
            tournament_report.ShowDialog();
            this.Close();
        }

        private void frmRankOfTeam_Load(object sender, EventArgs e)
        {
            dgvRankOfTeams.DataSource = LoadAllRankOfClub();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            dgvRankOfTeams.DataSource = LoadAllRankOfClub();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            frmReportRankOfClub rp = new frmReportRankOfClub();
            rp.ShowDialog();
        }
    }
}
