using SourceCode.DAO;
using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class frmClub : Form
    {
        List<ClubDTO> list_clubs = new List<ClubDTO>();
        public static List<GenderDTO> list_gender = new List<GenderDTO>();
        public string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
        public frmClub()
        {
            InitializeComponent();
            LoadGenderIntoCombobox(cmbGender);
            LoadData();
            BindingAtt();
        }

        public void DisableAtt()
        {
            txtClubID.Enabled = false;
            txtClubName.Enabled = false;
            txtCoach.Enabled = false;
            txtStadiumName.Enabled = false;
            txtCoachName.Enabled = false;
            txtNation.Enabled = false;
            cmbGender.Enabled = false;
        }

        public void EnableAttCoach()
        {
            txtCoachName.Enabled = true;
            txtNation.Enabled = true;
            cmbGender.Enabled = true;
        }
        public void EnableAtt()
        {
            txtClubName.Enabled = true;
            txtStadiumName.Enabled = true;
        }
        private void LoadGenderIntoCombobox(ComboBox cb)
        {
            list_gender = GenderDAO.Instances.LoadAllGender();
            foreach(GenderDTO item in list_gender)
            {
                cb.Items.Add(item.Gender_name);
            }
            
        }
        public void LoadData()
        {
            DataTable dt = ClubDAO.Instance.LoaClubs();
            dgvListClubs.DataSource = dt;
        }
        
        public void LoadAllPlayerForClub(string ID)
        {
            DataTable dt = ClubDAO.Instance.LoadAllPlayerForClub(ID);
            dgvTeamPlayer.DataSource = dt;
        }

        public void BindingAtt()
        {
            //binding club
            txtClubID.DataBindings.Clear();
            txtClubID.DataBindings.Add("Text", dgvListClubs.DataSource, "ClubID", true, DataSourceUpdateMode.Never);
            txtClubName.DataBindings.Clear();
            txtClubName.DataBindings.Add("Text", dgvListClubs.DataSource, "ClubName", true, DataSourceUpdateMode.Never);
            txtCoach.DataBindings.Clear();
            txtCoach.DataBindings.Add("Text", dgvListClubs.DataSource, "CoachName", true, DataSourceUpdateMode.Never);
            txtStadiumName.DataBindings.Clear();
            txtStadiumName.DataBindings.Add("Text", dgvListClubs.DataSource, "StadiumName", true, DataSourceUpdateMode.Never);

            //binding coach
            txtCoachName.DataBindings.Clear();
            txtCoachName.DataBindings.Add("Text", dgvListClubs.DataSource, "CoachName", true, DataSourceUpdateMode.Never);
            cmbGender.DataBindings.Clear();
            cmbGender.DataBindings.Add("Text", dgvListClubs.DataSource, "CoachGender", true, DataSourceUpdateMode.Never);
            dtpBirthday.DataBindings.Clear();
            dtpBirthday.DataBindings.Add("Value", dgvListClubs.DataSource, "CoachBirthday", true, DataSourceUpdateMode.Never);
            txtNation.DataBindings.Clear();
            txtNation.DataBindings.Add("Text", dgvListClubs.DataSource, "CoachNation", true, DataSourceUpdateMode.Never);
        }
        private void UpdateClubInfor()
        {  
            string club_name = txtClubName.Text;
            string stadium = txtStadiumName.Text;
            string clubID = txtClubID.Text;

            try
            {
                ClubDTO club = new ClubDTO(club_name, stadium, clubID);
                if (ClubDAO.Instance.UpdateClub(club))
                    MessageBox.Show("Update Done!!!","Notification", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Update fail","Notification", MessageBoxButtons.OK);
            }
            catch { }

            LoadData();
            BindingAtt();
        }

        private void UpdateHumanInfor()
        {
            string human_name = txtCoachName.Text;
            string human_gender_id = GenderDAO.Instances.GetGenderID(cmbGender.Text);
            DateTime human_birthday = dtpBirthday.Value;
            string human_nation = txtNation.Text;
            string h_id = "C_" + txtClubID.Text;
            try
            {
                HumanDTO hm = new HumanDTO(human_name, human_gender_id, human_birthday, human_nation, h_id);
                if (HumanDAO.Instance.UpdateHuman(hm))
                {
                    MessageBox.Show("Update Done!!!", "Notification",MessageBoxButtons.OK);
                }
            }
            catch { }
        }
        private void btnCoachInfor_Click(object sender, EventArgs e)
        {
            frmClub.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmClub.ActiveForm.Width = 1250;
            frmClub.ActiveForm.Update();
        }

        private void frmTeam_Load(object sender, EventArgs e)
        {
            btnSaveTeamInfor.Enabled = false;
            DisableAtt();
            LoadImage(picLogoTeam, 5);
            LoadAllPlayerForClub(txtClubID.Text);
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
            EnableAtt();
        }

        private void btnSaveTeamInfor_Click(object sender, EventArgs e)
        {
            DisableAtt();
            UpdateClubInfor();
        }

        public void LoadImage(PictureBox pic, int IndexCells)
        {
            try
            {
                int index = dgvListClubs.CurrentCell.RowIndex;//lấy ra chỉ số của row đang đc chọn
                string str_Path;
                //lay ra link anh
                str_Path = dgvListClubs.Rows[index].Cells[IndexCells].Value.ToString().Trim(); //5 la thu tu cot Path
                pic.Image = Image.FromFile(paths + str_Path);
            }
            catch { }

        }
        //hien thi anh khi bam vao tung dong
        private void dgvListClubs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmClub.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmClub.ActiveForm.Width = 840;
            frmClub.ActiveForm.Update();

            LoadImage(picLogoTeam, 5);
            LoadAllPlayerForClub(txtClubID.Text);

            LoadImage(picViewCoach, 9);
        }

        private void btnCancelViewCoach_Click(object sender, EventArgs e)
        {
            frmClub.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmClub.ActiveForm.Width = 840;
            frmClub.ActiveForm.Update();
        }

        private void btnUpdateCoachInfor_Click(object sender, EventArgs e)
        {
            EnableAttCoach();
        }

        private void btnSaveCoachInfor_Click(object sender, EventArgs e)
        {
            UpdateHumanInfor();
            LoadData();
            BindingAtt();
        }
    }
}
