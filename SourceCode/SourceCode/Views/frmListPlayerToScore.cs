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
    public partial class frmListPlayerToScore : Form
    {
        public frmListPlayerToScore()
        {
            InitializeComponent();
        }
        public void LoadListPlayerToScore()
        {
            DataTable dt = PlayerDAO.Instance.ListPlayerToScore();
            dgvListPlayerToScore.DataSource = dt;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTournamentReport tournament_report = new frmTournamentReport();
            tournament_report.ShowDialog();
            this.Close();
        }

        private void frmListPlayerToScore_Load(object sender, EventArgs e)
        {
            LoadListPlayerToScore();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadListPlayerToScore();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReportListPlayerToScore rp = new frmReportListPlayerToScore();
            rp.ShowDialog();
            this.Close();
        }
    }
}
