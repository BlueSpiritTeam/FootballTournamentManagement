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
    public partial class frmRegister : Form
    {
        private static List<ClubDTO> list_clubs = new List<ClubDTO>(); //De lay du kieu
        public static List<GenderDTO> list_gender = new List<GenderDTO>();
        public static List<RoleDTO> list_roles = new List<RoleDTO>();
        public static List<CoachDTO> list_coach = new List<CoachDTO>();
        public string path_img_club = ""; //lay file path cua club
        public string path_img_coach = "";
        public string path_img_player = "";
        public frmRegister()
        {
            InitializeComponent();
            pnlCoachName.Visible = false;
            LoadGender();
            LoadRoles();
        }
        
        private void LoadGender()
        {
            // lay vao list_gender trong ham LoadGender() cua DAO vao List<>
            list_gender = GenderDAO.Instances.LoadAllGender();

            foreach(GenderDTO item in list_gender)
            {
                //trong thang list_gender no da co Male va Female roi.
                cmbGenderCoach.Items.Add(item.Gender_name);
                cmbGenderPlayer.Items.Add(item.Gender_name);
            }
        }

        private void LoadRoles()
        {
            list_roles = RoleDAO.Instances.LoadAllRoles();
            foreach (RoleDTO item in list_roles)
            {
                cmbRole.Items.Add(item.Role_name);
            }
        }

        private bool CheckClubId()
        {
            list_clubs = ClubDAO.Instance.LoadAllClubs();
            foreach(ClubDTO item in list_clubs)
            {
                if (txtClubID.Text == item.Club_id)
                    return false;
            }
            return true;
        }

        private bool CheckTextbox_Club()
        {
            if (txtClubID.TextLength != 3)
                return true;
            if (txtClubName.Text == "")
                return true;
            if (txtStadiumName.Text == "")
                return true;
            return false;
        }
        private void AddClub()
        {
            if (CheckTextbox_Club() == false)
            {
                string club_id = txtClubID.Text;
                string club_name = txtClubName.Text;
                string stadium = txtStadiumName.Text;
                string path = path_img_club;

                ClubDTO club = new ClubDTO(club_id, club_name, stadium, path);
                if(ClubDAO.Instance.InsertNewClub(club))
                {
                    MessageBox.Show("Succesflly", "Notification", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Input wrong or be the same", "Error!!!", MessageBoxButtons.OK);
        }

        private bool CheckTextboxCoach()
        {
            if (txtCoachNameInsert.Text == "")
                return true;
            if (txtNationOfCoach.Text == "")
                return true;
            else
                return false;
         }
        
        public void AddCoach()
        {
            if (CheckTextboxCoach() == false)
            {
                string human_id = "C_" + txtClubID.Text;
                string gender_id = GenderDAO.Instances.GetGenderID(cmbGenderCoach.Text);
                string clubid = txtClubID.Text;
                string name_coach = txtCoachNameInsert.Text;
                DateTime birthday_coach = dtpBirthdayCoach.Value;
                string nation_coach = txtNationOfCoach.Text;
                string path_coach = path_img_coach;

                //add data vao bang HumanInformation
                HumanDTO hm = new HumanDTO(human_id, gender_id, clubid, name_coach, birthday_coach, nation_coach, path_coach);
                
                if (CoachDAO.Instance.InsertNewHuman(hm))
                {
                    MessageBox.Show("Succesflly", "Notification", MessageBoxButtons.OK);
                }
                //add data vao bảng Coach
                CoachDTO c = new CoachDTO(human_id);
                if (CoachDAO.Instance.InsertNewCoach(c))
                {
                    MessageBox.Show("Succesflly", "Notification", MessageBoxButtons.OK);
                }
            }
            else
                MessageBox.Show("Input wrong or be the same", "Error!!!", MessageBoxButtons.OK);
        }
        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtCoachNameShow.Enabled = false;
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            frmRegister.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmRegister.ActiveForm.Width = 1310;
            frmRegister.ActiveForm.Update();
            panelAddInfor.Visible = false;
            bunifuTransition.ShowSync(panelAddInfor);
            tabControlAddInfor.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmRegister.ActiveForm.Width = 850;
            frmRegister.ActiveForm.Update();
        }

        private void btnCancelAddPlayer_Click(object sender, EventArgs e)
        {
            frmRegister.ActiveForm.Width = 850;
            frmRegister.ActiveForm.Update();
        }
        
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            //cach goi ham tu ClubDAO khong lay dc link URL cua anh.
            // nen muon lay url chi con cach code lai ham trong nay
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.png)|*.png|All Files(*.*)|*.";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    //lay file trong resource cua minh
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    string CorrectFileName = System.IO.Path.GetFileName(open.FileName);
                    //copy anh vao file Images

                    if (!System.IO.File.Exists(paths + "\\Images\\" + CorrectFileName))
                        System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFileName);
                    else
                    {
                        System.IO.File.Delete(paths + "\\Images\\" + CorrectFileName);
                        System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFileName);
                    }
                    
                    picLogoTeam.Image = Image.FromFile(paths + "\\Images\\" + CorrectFileName);
                    path_img_club = "\\Images\\" + CorrectFileName;
                    MessageBox.Show("Successfully Upload");
                }
            }
            //ClubDAO.Instance.ChooImage(open, picLogoTeam, path_img);
        }
        
        private void btnSaveClub_Click(object sender, EventArgs e)
        {
            if(CheckClubId() == true)
                AddClub();
            else
                MessageBox.Show("Club ID already", "Error!!!", MessageBoxButtons.OK);
        }

        private void btnChooseCoachImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.png)|*.png|All Files(*.*)|*.";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    string CorrectFileName = System.IO.Path.GetFileName(open.FileName);

                    if (!System.IO.File.Exists(paths + "\\Images\\" + CorrectFileName))
                        System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFileName);
                    else
                    {
                        System.IO.File.Delete(paths + "\\Images\\" + CorrectFileName);
                        System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFileName);
                    }

                    picCoach.Image = Image.FromFile(paths + "\\Images\\" + CorrectFileName);
                    path_img_coach = "\\Images\\" + CorrectFileName;
                }
            }
        }

        private void btnAddNewPlayers_Click(object sender, EventArgs e)
        {
            frmRegister.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmRegister.ActiveForm.Width = 1310;
            frmRegister.ActiveForm.Update();
            panelAddInfor.Visible = false;
            bunifuTransition.ShowSync(panelAddInfor);
            tabControlAddInfor.SelectedIndex = 1;
        }

        private void btnChoosePlayerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.png)|*.png|All Files(*.*)|*.";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    string CorrectFileName = System.IO.Path.GetFileName(open.FileName);

                    if (!System.IO.File.Exists(paths + "\\Images\\" + CorrectFileName))
                        System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFileName);
                    else
                    {
                        System.IO.File.Delete(paths + "\\Images\\" + CorrectFileName);
                        System.IO.File.Copy(open.FileName, paths + "\\Images\\" + CorrectFileName);
                    }

                    picPlayer.Image = Image.FromFile(paths + "\\Images\\" + CorrectFileName);
                    path_img_player = "\\Images\\" + CorrectFileName;
                }
            }
        }

        private void btnSaveCoach_Click(object sender, EventArgs e)
        {
            AddCoach();
        }
    }
}
