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
        private static RuleDTO rules = new RuleDTO();
        public static RuleDTO Rules;

        public string path_img_club = ""; //lay file path cua club
        public string path_img_coach = "";
        public string path_img_player = "";
        public frmRegister()
        {
            InitializeComponent();
            pnlCoachName.Visible = false;
            LoadGenderIntoCombobox(cmbGenderCoach);
            LoadGenderIntoCombobox(cmbGenderPlayer);
            LoadRolesIntoCombobox(cmbRole);
            LoadRules();
        }

        #region methods
        private void LoadRules()
        {
            Rules = RuleDAO.Instance.LoadRules(); // load tât cả các rule vào đối tượng Rules đc tạo static ở trên
        }
        private void LoadGenderIntoCombobox(ComboBox cb)
        {
            // lay vao list_gender trong ham LoadGender() cua DAO vao List<>
            list_gender = GenderDAO.Instances.LoadAllGender();
            foreach(GenderDTO item in list_gender)
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
        int number_of_club = 1;
        private void AddClub()
        {
            if (number_of_club == 1)
            {
                if (CheckTextbox_Club() == false)
                {
                    string club_id = txtClubID.Text;
                    string club_name = txtClubName.Text;
                    string stadium = txtStadiumName.Text;
                    string path = path_img_club;

                    ClubDTO club = new ClubDTO(club_id, club_name, stadium, path);
                    if (ClubDAO.Instance.InsertNewClub(club))
                    {
                        ClubDAO.Instance.InitializeDetailClub(club_id);
                        MessageBox.Show("Succesflly", "Notification", MessageBoxButtons.OK);
                        number_of_club = 0;
                        btnAddCoach.Enabled = true;
                        btnCancelAll.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("Input wrong or be the same", "Error!!!", MessageBoxButtons.OK);
                
            }
            else
                MessageBox.Show("You must be add coach and list player to this club", "Error!!!", MessageBoxButtons.OK);
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

        int number_of_coach = 0;
        public void AddCoach()
        {
            if (number_of_coach == 0)
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
                    string coach_id = "C_" + txtClubID.Text;

                    //add data vao bang HumanInformation
                    HumanDTO hm = new HumanDTO(human_id, gender_id, clubid, name_coach, birthday_coach, nation_coach, path_coach);
                    //add data vao bảng Coach
                    CoachDTO c = new CoachDTO(coach_id);
                    if (HumanDAO.Instance.InsertNewHuman(hm) && CoachDAO.Instance.InsertNewCoach(c))
                    {
                        number_of_coach = 1;
                        MessageBox.Show("Succesflly add coach", "Notification", MessageBoxButtons.OK);
                    }
                    pnlCoachName.Visible = true;
                    txtCoachNameShow.Text = txtCoachNameInsert.Text;
                }
                else
                    MessageBox.Show("Input wrong or be the same", "Error!!!", MessageBoxButtons.OK);  
            }
            else
                MessageBox.Show("Coach is already", "Error!!!", MessageBoxButtons.OK);
        }

        public bool CheckTextbox_Player()
        {
            if (txtPlayerName.Text == "")
                return true;
            if (txtNationOfPlayer.Text == "")
                return true;
            if (txtKitnum.Text == "")
                return true;
            return false;
        }
        public bool CheckAge()
        {
            if (Rules.Min_age <= DateTime.Now.Year - dtpBirthdayPlayer.Value.Year && DateTime.Now.Year - dtpBirthdayPlayer.Value.Year <= Rules.Max_age)
                return true;
            return false;
        }
        int P_ID = 1; //bien check dieu kien cua player and ordering number
        public void AddPlayer()
        {
            if (P_ID <= Rules.Max_player)
            {
                if (CheckTextbox_Player() == false)
                {
                    string humanid = "P_" + txtClubID.Text + "_" + P_ID.ToString();
                    string gender_id = GenderDAO.Instances.GetGenderID(cmbGenderPlayer.Text);
                    string clubid = txtClubID.Text;
                    string name_player = txtPlayerName.Text;
                    DateTime birthday_player = dtpBirthdayPlayer.Value;
                    string nation_player = txtNationOfPlayer.Text;
                    string path_player = path_img_player;

                    string player_id = "P_" + txtClubID.Text + "_" + P_ID.ToString();
                    int role = RoleDAO.Instances.GetRoleId(cmbRole.Text);
                    int goal_number = 0;
                    int ass_number = 0;
                    int kitnum = int.Parse(txtKitnum.Text);

                    
                    //add data vao bang HumanInformation
                    HumanDTO hm = new HumanDTO(humanid, gender_id, clubid, name_player, birthday_player, nation_player, path_player);
                    PlayerDTO p = new PlayerDTO(player_id, role, goal_number, ass_number, kitnum);
                    if (HumanDAO.Instance.InsertNewHuman(hm) && PlayerDAO.Instance.InsertNewPlayer(p))
                    {
                        MessageBox.Show("Succesflly add player", "Notification", MessageBoxButtons.OK);

                        txtPlayerName.Text = "";
                        txtNationOfPlayer.Text = "";
                        txtKitnum.Text = "";
                        picPlayer.Image = null;
                    }

                    this.dgvRegister.Rows.Add(P_ID, player_id, name_player, cmbRole.Text, nation_player);
                    P_ID++;
                }
                else
                {
                    MessageBox.Show("Input wrong or be the same", "Error!!!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Number of player form "+ Rules.Min_player.ToString() + " to "+ Rules.Max_player.ToString(), "Error!!!", MessageBoxButtons.OK);
            }
        }

        #endregion
        /*-------------------------------------------------*/
        #region events
        private void frmRegister_Load(object sender, EventArgs e)
        {
            btnFinish.Enabled = false;
            txtCoachNameShow.Enabled = false;
            btnAddCoach.Enabled = false;
            btnAddNewPlayers.Enabled = false;
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            //default
            cmbGenderCoach.Text = "Male";
            frmRegister.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmRegister.ActiveForm.Width = 1310;
            frmRegister.ActiveForm.Update();
            panelAddInfor.Visible = false;
            bunifuTransition.ShowSync(panelAddInfor);
            tabControlAddInfor.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddNewPlayers.Enabled = true;
            btnAddCoach.Enabled = false;

            txtCoachNameInsert.Clear();
            txtNationOfCoach.Clear();

            frmRegister.ActiveForm.Width = 850;
            frmRegister.ActiveForm.Update();
        }

        private void btnCancelAddPlayer_Click(object sender, EventArgs e)
        {
            if (P_ID < Rules.Min_player)
                MessageBox.Show("Number of player form " + Rules.Min_player.ToString() + " to " + Rules.Max_player.ToString(), "Error!!!", MessageBoxButtons.OK);
            else
            {
                frmRegister.ActiveForm.Width = 850;
                frmRegister.ActiveForm.Update();
                btnFinish.Enabled = true;
            }
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
                }
            }
            //ClubDAO.Instance.ChooImage(open, picLogoTeam, path_img);
        }
        
        private void btnSaveClub_Click(object sender, EventArgs e)
        {
            
            if (CheckClubId() == true)
            {
                AddClub();
            }    
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
            //enable and default
            txtClubplayer.Enabled = false;
            txtClubplayer.Text = txtClubName.Text;
            cmbGenderPlayer.Text = "Male";
            cmbRole.Text = "GoalKeeper";

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
            picPlayer.InitialImage = null;
        }

        private void btnSaveNewPlayer_Click(object sender, EventArgs e)
        {
            if (CheckAge() == true)
                AddPlayer();
            else
            {
                MessageBox.Show("Age of player form " + Rules.Min_age.ToString() + " to " + Rules.Max_age.ToString(), "Error!!!", MessageBoxButtons.OK);
                dtpBirthdayPlayer.Focus();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGeneral general = new frmGeneral();
            general.ShowDialog();
            this.Close();
        }
        

        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGeneral general = new frmGeneral();
            general.ShowDialog();
            this.Close();
        }

        #endregion
    }
}
