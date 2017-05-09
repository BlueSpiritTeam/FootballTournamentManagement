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

namespace SourceCode
{
    public partial class frmChangeRules : Form
    {
        private static RuleDTO rules = new RuleDTO(); // sử dụng nhiều lần
        private static List<TypeGoalDTO> list_typegoal = new List<TypeGoalDTO>();

        public static RuleDTO Rules
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


            //set giá trị từ database vào các view
            max_age.Value = Rules.Max_age;
            min_age.Value = Rules.Min_age;
            min_player.Value = Rules.Min_player;
            max_player.Value = Rules.Max_player;
            win_score.Value = Rules.Score_win;
            draw_score.Value = Rules.Score_draw;
            lose_score.Value = Rules.Score_lose;
        }

        private void LoadTypeGoal()
        {
            list_typegoal = TypeGoalDAO.Instance.LoadTypeGoal();

            foreach(TypeGoalDTO item in list_typegoal)
            {
                ListViewItem lvit = new ListViewItem(item.Type_id);
                lvit.SubItems.Add(item.Type_name);

                listView_typeGoal.Items.Add(lvit);
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

        #endregion
    }
}
