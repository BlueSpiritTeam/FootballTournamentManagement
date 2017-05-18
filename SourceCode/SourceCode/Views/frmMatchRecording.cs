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

        private List<MatchDTO> list = new List<MatchDTO>();
        public frmMatchRecording()
        {
            InitializeComponent();
            if (list != null)
                LoadMatches();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTournament tournament = new frmTournament();
            tournament.ShowDialog();
            this.Close();
        }

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

        private void dgv_match_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                MatchDTO match = new MatchDTO();
                match = list[dgv_match.CurrentCell.RowIndex];
                this.contextMenuStrip.Show(this.dgv_match, e.Location);
                this.contextMenuStrip.Show(Cursor.Position);
            }
        }

        private void recordThisMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MatchDTO match = list[dgv_match.CurrentCell.RowIndex];
            if (check_MatchRecordAlready(match)==true)
            {
                if (MessageBox.Show("This match was recorded. Do you want to do it again?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            frmMatchRecording.ActiveForm.Width = 1126;
            frmMatchRecording.ActiveForm.Update();
                    
            lb_homeclub.Text = match.Home_club_name;
            lb_awayclub.Text = match.Guest_club_name;

            LoadTypeGoalToComboBox();

            dgv_match.Enabled = false;
            pnlFooter.Visible = false;
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
            btn_finishrecord.Visible = true;
            panel_detailrecord.Visible = false;
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
            dgv_match.Enabled = true;
            pnlFooter.Visible = true;
        }

        private void LoadPlayersToComboBox(ComboBox cb)
        {

        }

        private void LoadTypeGoalToComboBox()
        {
            // TODO: This line of code loads data into the 'typeGoal._TypeGoal' table. You can move, or remove it, as needed.
            this.typeGoalTableAdapter.Fill(this.typeGoal._TypeGoal);
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
    }
}
