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
    public partial class frmReportListPlayerToScore : Form
    {
        public frmReportListPlayerToScore()
        {
            InitializeComponent();
        }

        private void frmReportListPlayerToScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'footballTournamentManagerDataSet1.ListPlayerToScore' table. You can move, or remove it, as needed.
            this.listPlayerToScoreTableAdapter.Fill(this.footballTournamentManagerDataSet1.ListPlayerToScore);

            this.reportViewer_ListPlayer.RefreshReport();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListPlayerToScore trp = new frmListPlayerToScore();
            trp.ShowDialog();
            this.Close();
        }
    }
}
