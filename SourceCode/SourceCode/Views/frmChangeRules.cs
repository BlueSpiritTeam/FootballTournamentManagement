using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SourceCode.DAO;
using SourceCode.DTO;
using SourceCode.Views;

namespace SourceCode
{
    public partial class frmChangeRules : Form
    {
        //khai bao mot RuleDTO
        private static RuleDTO rules = new RuleDTO(); // sử dụng nhiều lần
        private static List<TypeGoalDTO> list_typegoal = new List<TypeGoalDTO>();

        public static RuleDTO Rules //khai bao Rule 
        {
            get
            {
                return rules;
            }

            set
            {
                rules = value;
            }
        }

        public frmChangeRules()
        {
            InitializeComponent();
            LoadRules();
            LoadTypeGoal();
        }



        #region methods
        private void LoadRules()
        {
            Rules = RuleDAO.Instance.LoadRules(); // load tât cả các rule vào đối tượng Rules đc tạo static ở trên
            Set_Controll_Value();   
        }

        private void Set_Controll_Value()
        {
            max_age.Value = Rules.Max_age;
            min_age.Value = Rules.Min_age;
            min_player.Value = Rules.Min_player;
            max_player.Value = Rules.Max_player;
            win_score.Value = Rules.Score_win;
            draw_score.Value = Rules.Score_draw;
            lose_score.Value = Rules.Score_lose;
        }

        private void Default_Value()
        {
            max_age.Value = 45;
            min_age.Value = 16;
            min_player.Value = 16;
            max_player.Value = 45;
            win_score.Value = 3;
            draw_score.Value = 1;
            lose_score.Value = 0;
        }

        private void LoadTypeGoal()
        {
            list_typegoal = TypeGoalDAO.Instance.LoadTypeGoal();

            //xe mot TypeGoal trong list_typegoal
            foreach(TypeGoalDTO item in list_typegoal)
            {
                ListViewItem lvit = new ListViewItem(item.Type_id);
                lvit.SubItems.Add(item.Type_name);

                listView_typeGoal.Items.Add(lvit);
            }
        }

        private void UpdateRule()
        {
            RuleDTO temp = new RuleDTO((int)max_age.Value, (int)min_age.Value, (int)max_player.Value, (int)min_player.Value, (int)win_score.Value, (int)draw_score.Value, (int)lose_score.Value);
            if(RuleDAO.Instance.UpdateRule(temp))
            {
                MessageBox.Show("Done!!!");
            }
        }

        private void Del_TypeGoal()
        {
            string id = listView_typeGoal.SelectedItems[0].Text;

            if(TypeGoalDAO.Instance.DeleteType(id))
            {
                MessageBox.Show("Delete Successfully", "Notification", MessageBoxButtons.OK);
                listView_typeGoal.Items.Clear();
                LoadTypeGoal();
            }
            else
            {
                MessageBox.Show("Delete Fail", "Error", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGeneral general = new frmGeneral();
            general.ShowDialog();
            this.Close();
        }

        private void btnDefaultRules_Click(object sender, EventArgs e)
        {
            Default_Value();
        }

        private void btnUpdateRules_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to update rules?","Notification",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                UpdateRule();
            }
        }

        private void btnAddTypeOfGoals_Click(object sender, EventArgs e)
        {
            frmTypesGoal TypeGoal = new frmTypesGoal();
            TypeGoal.ShowDialog();
        }

        private void btnDeleteTypeOfGoals_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to delete type of a goal?","Notification", MessageBoxButtons.YesNo)==DialogResult.Yes)
                Del_TypeGoal();
        }

        
        #endregion


    }
}
