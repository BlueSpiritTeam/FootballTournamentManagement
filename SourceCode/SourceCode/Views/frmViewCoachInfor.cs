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
    public partial class frmViewCoachInfor : Form
    {
        public frmViewCoachInfor()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClub team = new frmClub();
            team.ShowDialog();
            this.Close();
        }

        private void frmViewCoachInfor_Load(object sender, EventArgs e)
        {
            btnSaveCoachInfor.Visible = false;
        }

        private void btnUpdateCoachInfor_Click(object sender, EventArgs e)
        {
            btnSaveCoachInfor.Visible = true;
        }
    }
}
