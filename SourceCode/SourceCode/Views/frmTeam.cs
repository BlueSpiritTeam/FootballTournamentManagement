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
    public partial class frmTeam : Form
    {
        public frmTeam()
        {
            InitializeComponent();
        }


        private void btnCoachInfor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmViewCoachInfor coach_infor = new frmViewCoachInfor();
            coach_infor.ShowDialog();
            this.Close();
        }

        private void frmTeam_Load(object sender, EventArgs e)
        {
            btnDeletePlayerInTeam.Enabled = false;
            btnSaveTeamInfor.Enabled = false;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGeneral coach_infor = new frmGeneral();
            coach_infor.ShowDialog();
            this.Close();
        }

        private void btnUpdateTeamInfor_Click(object sender, EventArgs e)
        {
            btnSaveTeamInfor.Enabled = true;
        }
    }
}
