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
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClub team = new frmClub();
            team.ShowDialog();
            this.Close();
        }

        private void frmGeneral_Load(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void btnPlayerManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPlayer player = new frmPlayer();
            player.ShowDialog();
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.ShowDialog();
            this.Close();
        }

        private void btnTournamentManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTournament tournament = new frmTournament();
            tournament.ShowDialog();
            this.Close();
        }

        private void btnTournamentReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTournamentReport tournament_report = new frmTournamentReport();
            tournament_report.ShowDialog();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
            this.Close();
        }
    }
}
