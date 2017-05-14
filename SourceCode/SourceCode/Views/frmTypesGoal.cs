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

namespace SourceCode.Views
{
    public partial class frmTypesGoal : Form
    {
        public frmTypesGoal()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangeRules ChangeRule = new frmChangeRules();
            ChangeRule.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(check_input()==false)
            {
                MessageBox.Show("Input please!!!", "Notification");
            }
            else
            {
                //khoi tao 1 typeGoal
                TypeGoalDTO temp = new TypeGoalDTO(txt_TypeGoalID.Text, txt_GoalName.Text);
                if (TypeGoalDAO.Instance.InsertType(temp))
                    MessageBox.Show("Done!!!", "Notification");
                else
                {
                    MessageBox.Show("ID exist!!!");
                }
            }
        }

        private bool check_input()
        {
            if (txt_TypeGoalID.Text == "")
                return false;
            if (txt_GoalName.Text == "")
                return false;
            return true;
        }
    }
}
