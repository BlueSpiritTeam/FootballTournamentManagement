using SourceCode.DAO;
using SourceCode.DTO;
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
        public string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
        public static List<GenderDTO> list_gender = new List<GenderDTO>();
        public static List<RoleDTO> list_roles = new List<RoleDTO>();
        
        public frmPlayer()
        {
            InitializeComponent();
            LoadAllPlayerInfor();
            LoadGenderIntoCombobox(cmbGender);
            LoadRolesIntoCombobox(cmbRole);
            DisableAtt();
            Binding();
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
            cmbSearchPlayer.Text = "Name";
            LoadImage(picPlayer);
            SearchCategory();
        }
        private void LoadGenderIntoCombobox(ComboBox cb)
        {
            list_gender = GenderDAO.Instances.LoadAllGender();
            // lay vao list_gender trong ham LoadGender() cua DAO vao List<>
            list_gender = GenderDAO.Instances.LoadAllGender();
            foreach (GenderDTO item in list_gender)
            {
                cb.Items.Add(item.Gender_name);
            }
        }

        private void LoadRolesIntoCombobox(ComboBox cb)
        {

            list_roles = RoleDAO.Instances.LoadAllRoles();
            foreach (RoleDTO item in list_roles)
                cb.Items.Add(item.Role_name);
        }
        public void DisableAtt()
        {
            txtAge.Enabled = false;
            txtClub.Enabled = false;
            txtKitnum.Enabled = false;
            txtNation.Enabled = false;
            txtPlayerName.Enabled = false;
            cmbRole.Enabled = false;
            cmbGender.Enabled = false;
        }

        public void EnableAtt()
        {
            txtAge.Enabled = true;
            txtClub.Enabled = true;
            txtKitnum.Enabled = true;
            txtNation.Enabled = true;
            txtPlayerName.Enabled = true;
            cmbRole.Enabled = true;
            cmbGender.Enabled = true;
        }

        public void LoadAllPlayerInfor()
        {
            DataTable dt = PlayerDAO.Instance.LoadPlayer();
            dgvPlayerInfor.DataSource = dt;
        }
        
        public void Binding()
        {
            txtPlayerName.DataBindings.Clear();
            txtPlayerName.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Name", true, DataSourceUpdateMode.Never);
            txtAge.DataBindings.Clear();
            txtAge.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Age", true, DataSourceUpdateMode.Never);
            txtClub.DataBindings.Clear();
            txtClub.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "ClubName", true, DataSourceUpdateMode.Never);
            txtKitnum.DataBindings.Clear();
            txtKitnum.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "KitNum", true, DataSourceUpdateMode.Never);
            txtNation.DataBindings.Clear();
            txtNation.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "Nation", true, DataSourceUpdateMode.Never);
            cmbRole.DataBindings.Clear();
            cmbRole.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "RoleName", true, DataSourceUpdateMode.Never);
            dtpBirthday.DataBindings.Clear();
            dtpBirthday.DataBindings.Add("Value", dgvPlayerInfor.DataSource, "Birthday", true, DataSourceUpdateMode.Never);
            cmbGender.DataBindings.Clear();
            cmbGender.DataBindings.Add("Text", dgvPlayerInfor.DataSource, "GenderName", true, DataSourceUpdateMode.Never);
        }

        public void LoadImage(PictureBox pic)
        {
            try { 
                int index = dgvPlayerInfor.CurrentCell.RowIndex;//lấy ra chỉ số của row đang đc chọn
                                                                //lay ra link anh

            string str_path_player = dgvPlayerInfor.Rows[index].Cells[9].Value.ToString().Trim(); //5 la thu tu cot Path
            pic.Image = Image.FromFile(paths + str_path_player);
        }
            catch {  }
        }

        public void SearchCategory()
        {
            cmbSearchPlayer.Items.Add("Name");
            cmbSearchPlayer.Items.Add("Club");
            cmbSearchPlayer.Items.Add("Role");
        }

        public DataTable SearchByName(string name)
        {
            DataTable dt = HumanDAO.Instance.SearchByName(name);
            return dt;
        }

        public DataTable SearchByClub(string club)
        {
            DataTable dt = HumanDAO.Instance.SearchByClub(club);
            return dt;
        }
        public DataTable SearchByRole(string role)
        {
            DataTable dt = HumanDAO.Instance.SearchByRole(role);
            return dt;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableAtt();
        }
        

        private void dgvPlayerInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadImage(picPlayer);
        }
        /*
        public List<HumanDTO> SearchPlayerByName(string name)
        {
            List<HumanDTO> list_player = HumanDAO.Instance.SearchHumanByName(name);
            return list_player;
        }
        */

        private void UpdatePlayer()
        {
            string human_name = txtPlayerName.Text;
            string human_gender_id = GenderDAO.Instances.GetGenderID(cmbGender.Text);
            DateTime human_birthday = dtpBirthday.Value;
            string human_nation = txtNation.Text;
            int index = dgvPlayerInfor.CurrentCell.RowIndex;//lấy ra chỉ số của row đang đc chọn
            string h_id = dgvPlayerInfor.Rows[index].Cells[10].Value.ToString().Trim(); //loi o day

            int player_role = RoleDAO.Instances.GetRoleId(cmbRole.Text);
            int player_kitnum = int.Parse(txtKitnum.Text);
            try
            {
                HumanDTO hm = new HumanDTO(human_name, human_gender_id, human_birthday, human_nation, h_id);
                PlayerDTO pl = new PlayerDTO(h_id, player_role, player_kitnum);
                if (HumanDAO.Instance.UpdateHuman(hm) && PlayerDAO.Instance.UpdatePlayer(pl))
                {
                    MessageBox.Show("Update Done!!!");
                }
            }
            catch { }
            DisableAtt();
            LoadAllPlayerInfor();
            Binding();
        }

        private void btnSearchPlayer_Click(object sender, EventArgs e)
        {
            if(cmbSearchPlayer.Text == "Name")
            {
                dgvPlayerInfor.DataSource = SearchByName(txtSearchPlayer.Text);
            }
            else if(cmbSearchPlayer.Text == "Role")
            {
                dgvPlayerInfor.DataSource = SearchByRole(txtSearchPlayer.Text);
            }
            else if(cmbSearchPlayer.Text == "Club")
            {
                dgvPlayerInfor.DataSource = SearchByClub(txtSearchPlayer.Text);
            }

            Binding();
            LoadImage(picPlayer);
        }

        private void btnShowAllPlayer_Click(object sender, EventArgs e)
        {
            LoadAllPlayerInfor();
            LoadImage(picPlayer);
            Binding();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdatePlayer();  
        }

        private void grbPlayerDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
