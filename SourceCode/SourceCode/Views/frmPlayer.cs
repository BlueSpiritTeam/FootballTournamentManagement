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
    public partial class frmPlayer : Form
    {
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGeneral general = new frmGeneral();
            general.ShowDialog();
            this.Close();
        }

        private void frmPlayer_Load(object sender, EventArgs e)
        {
            LoadData();
            Binding();
        }

        public void LoadData()
        {
            string sqlString = @"select  p.PlayerID, p.PlayerName, p.Birthday, p.Age, p.Gender, t.TeamName, p.Position, p.Nation, p.KitNum
                                from Team as t, Player as p
                                where t.TeamID = p.TeamID";
            DataTable dt = DAO.DataProvider.LoadCSDL(sqlString);
            dgvPlayerInfor.DataSource = dt;
        }
        
        public void Binding()
        {
            txtPlayerName.DataBindings.Clear();
            txtPlayerName.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "PlayerName");
            txtAge.DataBindings.Clear();
            txtAge.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Age");
            txtClub.DataBindings.Clear();
            txtClub.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "TeamName");
            txtKitnum.DataBindings.Clear();
            txtKitnum.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "KitNum");
            txtNation.DataBindings.Clear();
            txtNation.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Nation");
            txtRole.DataBindings.Clear();
            txtRole.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Position");
            dtpBirthday.DataBindings.Clear();
            dtpBirthday.DataBindings.Add("Value", dgvPlayerInfor.DataSource, "Birthday");
            cmbGender.DataBindings.Clear();
            cmbGender.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Gender");
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
