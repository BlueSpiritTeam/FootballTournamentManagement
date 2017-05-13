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
        private static ClubDTO clubs = new ClubDTO(); //De lay du kieu
        private static List<GenderDTO> list_gender = new List<GenderDTO>();

        public frmRegister()
        {
            InitializeComponent();
            pnlCoachName.Visible = false;
            LoadGender();
        }

        #region methods
        
        private void LoadGender()
        {
            // lay vao list_gender trong ham LoadGender() cua DAO vao List<>
            list_gender = GenderDAO.Instances.LoadGender();

            foreach(GenderDTO item in list_gender)
            {
                ListViewItem lvit = new ListViewItem(item.Gender_id);
                lvit.SubItems.Add(item.Gender_name);

                cmbGenderCoach.Items.Add(lvit);
            }
        }

        #endregion

        #region events
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGeneral general = new frmGeneral();
            general.ShowDialog();
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            txtCoachNameShow.Enabled = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            frmRegister.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmRegister.ActiveForm.Width = 1310;       
            frmRegister.ActiveForm.Update();
            panelAddInfor.Visible = false;
            bunifuTransition.ShowSync(panelAddInfor);
            tabControlAddInfor.SelectedIndex = 1;
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            frmRegister.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmRegister.ActiveForm.Width = 1310;
            //frmRegister.ActiveForm.Location = new Point(0, 0);
            //frmRegister.ActiveForm.Visible = false;
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
        #endregion
    }
}
