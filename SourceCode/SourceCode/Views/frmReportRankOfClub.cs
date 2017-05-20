using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.Views
{
    public partial class frmReportRankOfClub : Form
    {
        public frmReportRankOfClub()
        {
            InitializeComponent();
        }

        private void frmReportRankOfClub_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'footballTournamentManagerDataSet3.LoadRankOfClub' table. You can move, or remove it, as needed.
            this.loadRankOfClubTableAdapter.Fill(this.footballTournamentManagerDataSet3.LoadRankOfClub);

            this.reportViewer_RankOfClubs.RefreshReport();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRankOfClub trp = new frmRankOfClub();
            trp.ShowDialog();
            this.Close();
        }
    }
}
