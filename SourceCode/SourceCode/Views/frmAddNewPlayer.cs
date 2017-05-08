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
    public partial class frmAddNewPlayer : Form
    {
        public frmAddNewPlayer()
        {
            InitializeComponent();
        }

        private void btnFinishAddPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister register = new frmRegister();
            register.ShowDialog();
        }

        private void btnSaveNewPlayer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add completed!");
        }

        public void RefreshTextbox()
        {
            txtPlayerName.Clear();
            txtAge.Clear();
            txtKitnum.Clear();
            txtNation.Clear();
            txtRole.Clear();
            txtType.Clear();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTextbox();
        }

        private void frmAddNewPlayer_Load(object sender, EventArgs e)
        {
            txtClub.Enabled = false;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog oddd = new OpenFileDialog();
            oddd.ShowDialog();
        }
    }
}
