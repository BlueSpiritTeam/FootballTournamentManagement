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
    public partial class frmMatchRecording : Form
    {
        private static RuleDTO match_rule = RuleDAO.Instance.LoadRules();
        private static int A = 0;
        private static int B = 0;
        private static MatchDTO match = new MatchDTO();
        private static List<TypeGoalDTO> typegoal = TypeGoalDAO.Instance.LoadTypeGoal();
        private List<MatchDTO> list = new List<MatchDTO>();
        public frmMatchRecording()
        {
            InitializeComponent();
            if (list != null)
                LoadMatches();
            LoadTypeGoalToComboBox();
        }

       

        #region methods

        private void LoadMatches()
        {
            list.Clear();
            list = MatchDAO.Instance.LoadAllMatches();

            dgv_match.DataSource = list;


            dgv_match.Columns[5].HeaderText = "Match ID";
            dgv_match.Columns[0].HeaderText = "Date";
            dgv_match.Columns[1].HeaderText = "Time";
            dgv_match.Columns[2].HeaderText = "Home";
            dgv_match.Columns[4].HeaderText = "Stadium";
            dgv_match.Columns[3].HeaderText = "Away";


            dgv_match.Columns[5].DisplayIndex = 0;
            dgv_match.Columns[0].DisplayIndex = 1;
            dgv_match.Columns[1].DisplayIndex = 2;
            dgv_match.Columns[4].DisplayIndex = 3;
            dgv_match.Columns[2].DisplayIndex = 4;
            dgv_match.Columns[3].DisplayIndex = 5;


            dgv_match.Columns[5].Width = 75;
            dgv_match.Columns[4].Width = 200;

            dgv_match.Columns[2].Width = 70;
            dgv_match.Columns[3].Width = 70;

            dgv_match.ClearSelection();
        }

        private DataTable list_players_BelongToMach(string a, string b)
        {
            return PlayerDAO.Instance.LoadPlayersByClubID(a, b);
        }

        private void LoadPlayerToComboBox(string a, string b)
        {
            DataTable data_A = list_players_BelongToMach(a,b);
            DataTable data_B = list_players_BelongToMach(a,b);

            comboBox_score.DataSource = data_A.DefaultView;
            comboBox_assitance.DataSource = data_B.DefaultView;

            comboBox_score.DisplayMember = "Name";
            comboBox_assitance.DisplayMember = "Name";
            comboBox_score.ValueMember = "ID";
            comboBox_assitance.ValueMember = "ID";

        }

        #endregion

        #region events

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTournament tournament = new frmTournament();
            tournament.ShowDialog();
            this.Close();
        }
        private void btn_score_Click(object sender, EventArgs e)
        {
            panel_detailrecord.Visible = true;
            btn_finishrecord.Visible = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_finishrecord.Visible = true;
            panel_detailrecord.Visible = false;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            PlayerDAO.Instance.UpdateGoal(comboBox_score.SelectedValue.ToString());
            if (checkbox_assistance.Checked == true)
                PlayerDAO.Instance.UpdateAssistance(comboBox_assitance.SelectedValue.ToString());

            if (HumanDAO.Instance.check_belongto_aclub(comboBox_score.SelectedValue.ToString(), match.Home_club_name.ToString()) == true)
            {
                A++;
                lbA.Text = A.ToString();
            }
            else
            {
                B++;
                lbB.Text = B.ToString();
            }

            btn_finishrecord.Visible = true;
            panel_detailrecord.Visible = false;
            checkbox_assistance.Checked = false;
        }

        private void checkbox_assistance_OnChange(object sender, EventArgs e)
        {
            if (comboBox_assitance.Visible == false)
                comboBox_assitance.Visible = true;
            else
                comboBox_assitance.Visible = false;
        }

        private void btn_finishrecord_Click(object sender, EventArgs e)
        {
            MatchRecordDTO record = new MatchRecordDTO(match.Match_id, lbA.Text + ":" + lbB.Text);

            if (MatchRecordDAO.Instance.Insert_A_MatchRecord(record))
            {
                UpdateClubDetail();                
                MessageBox.Show("Done");
            }

            frmMatchRecording.ActiveForm.Width = 690;
            frmMatchRecording.ActiveForm.Update();

            dgv_match.Enabled = true;
            pnlFooter.Visible = true;
        }

        private void UpdateClubDetail()
        {
            DetailClubDTO Club_A = ClubDAO.Instance.GetDetailClub(match.Home_club_name);
            DetailClubDTO Club_B = ClubDAO.Instance.GetDetailClub(match.Guest_club_name);

            Club_A.Wingoal += A;
            Club_A.Losegoal += B;
            Club_A.Offset = Club_A.Wingoal - Club_A.Losegoal;

            Club_B.Wingoal += A;
            Club_B.Losegoal += B;
            Club_B.Offset = Club_B.Wingoal - Club_B.Losegoal;


            if (A == B)
            {
                Club_A.Total_point += match_rule.Score_draw;
                Club_A.Numberdraw++;

                Club_B.Total_point += match_rule.Score_draw;
                Club_B.Numberdraw++;

            }
            else
            {
                if(A>B)
                {
                    Club_A.Total_point += match_rule.Score_win;
                    Club_A.Numberwin++;

                    Club_B.Total_point += match_rule.Score_lose;
                    Club_B.Numberlose++;
                }
                else
                {
                    Club_B.Total_point += match_rule.Score_win;
                    Club_B.Numberwin++;

                    Club_A.Total_point += match_rule.Score_lose;
                    Club_A.Numberlose++;
                }
            }

            ClubDAO.Instance.UpdateDetailClub(Club_A);
            ClubDAO.Instance.UpdateDetailClub(Club_B);

        }

        private void LoadTypeGoalToComboBox()
        {
            foreach(TypeGoalDTO item in typegoal)
            {
                comboBox_typegoal.Items.Add(item);
            }
            comboBox_typegoal.DisplayMember = "type_name";
            comboBox_typegoal.ValueMember = "type_id";
            comboBox_typegoal.SelectedIndex = 0;
        }

        private bool check_MatchRecordAlready(MatchDTO match)
        {
            if (MatchRecordDAO.Instance.Check_A_MatchRecord(match.Match_id) == true)
                return true;
            return false;
        }

        private void frmMatchRecording_Load(object sender, EventArgs e)
        {

        }

        private void dgv_match_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MatchDTO match = new MatchDTO();
                match = list[dgv_match.CurrentCell.RowIndex];
                this.contextMenuStrip.Show(this.dgv_match, e.Location);
                this.contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void recordThisMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            match = list[dgv_match.CurrentCell.RowIndex];
            if (check_MatchRecordAlready(match) == true)
            {
                if (MessageBox.Show("This match was recorded. Do you want to do it again?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            frmMatchRecording.ActiveForm.Width = 1126;
            frmMatchRecording.ActiveForm.Update();

            lb_homeclub.Text = match.Home_club_name;
            lb_awayclub.Text = match.Guest_club_name;
            LoadPlayerToComboBox(match.Home_club_name, match.Guest_club_name);

            dgv_match.Enabled = false;
            pnlFooter.Visible = false;


        }
        #endregion
    }
}
