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
            //LoadData();
            //Binding();
        }

        
        //public void LoadData()
        //{
        //    string sqlString = @"SELECT Row_number() over(ORDER BY h.HumandID) as OrderingNumber, p.PlayerID, h.Name, h.Birthday, (YEAR(GETDATE()) - YEAR(h.Birthday)) as Age, g.GenderName, c.ClubName, r.RoleName, h.Nation, p.KitNum
        //                         FROM HumandInformation as h, Club as c, Player as p, Role as r, Gender as g
        //                         WHERE h.HumandID = p.PlayerID and h.ClubID = c.ClubID and h.GenderID = g.GenderID
        //                         and p.RoleID = r.RoleID";
        //    DataTable dt = DAO.DataProvider.LoadCSDL(sqlString);
        //    dgvPlayerInfor.DataSource = dt;
        //}
        
        public void Binding()
        {
            txtPlayerName.DataBindings.Clear();
            txtPlayerName.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Name");
            txtAge.DataBindings.Clear();
            txtAge.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Age");
            txtClub.DataBindings.Clear();
            txtClub.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "ClubName");
            txtKitnum.DataBindings.Clear();
            txtKitnum.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "KitNum");
            txtNation.DataBindings.Clear();
            txtNation.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Nation");
            txtRole.DataBindings.Clear();
            txtRole.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "RoleName");
            dtpBirthday.DataBindings.Clear();
            dtpBirthday.DataBindings.Add("Value", dgvPlayerInfor.DataSource, "Birthday");
            cmbGender.DataBindings.Clear();
            cmbGender.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "GenderName");
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
