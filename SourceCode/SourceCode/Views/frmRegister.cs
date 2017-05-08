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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGeneral general = new frmGeneral();
            general.ShowDialog();
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtCoachName.Enabled = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmAddNewPlayer add_player = new frmAddNewPlayer();
            add_player.ShowDialog();   
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCoach add_coach = new frmAddCoach();
            add_coach.ShowDialog();
            this.Close();
        }
    }
}
