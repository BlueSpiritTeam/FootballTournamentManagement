using SourceCode.DAO;
using SourceCode.DTO;
using SourceCode.Helper;
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
    public partial class frmMatchSchedule : Form
    {
        private List<MatchDTO> list = new List<MatchDTO>();
        public frmMatchSchedule()
        {
            InitializeComponent();
            LoadMatches();
        }

        

        #region methods
        private void Create()
        {

            list = CreateSchedule.Instance.Create();

            if (list == null)
            {
                MessageBox.Show("Not enough clubs to create match schedule", "Notification");
                this.Hide();
                frmTournament tournament = new frmTournament();
                tournament.ShowDialog();
                this.Close();
                return;
            }

            dgvMatchResult.DataSource = list;
            SaveToDataBase();


            dgvMatchResult.Columns[5].HeaderText = "Match ID";
            dgvMatchResult.Columns[0].HeaderText = "Date";
            dgvMatchResult.Columns[1].HeaderText = "Time";
            dgvMatchResult.Columns[2].HeaderText = "Home";
            dgvMatchResult.Columns[4].HeaderText = "Stadium";
            dgvMatchResult.Columns[3].HeaderText = "Away";


            dgvMatchResult.Columns[5].DisplayIndex = 0;
            dgvMatchResult.Columns[0].DisplayIndex = 1;
            dgvMatchResult.Columns[1].DisplayIndex = 2;
            dgvMatchResult.Columns[4].DisplayIndex = 3;
            dgvMatchResult.Columns[2].DisplayIndex = 4;
            dgvMatchResult.Columns[3].DisplayIndex = 5;


            dgvMatchResult.Columns[5].Width = 75;
            dgvMatchResult.Columns[4].Width = 200;

            dgvMatchResult.Columns[2].Width = 70;
            dgvMatchResult.Columns[3].Width = 70;
        }

        private void LoadMatches()
        {
            list.Clear();
            list = MatchDAO.Instance.LoadAllMatches();

            dgvMatchResult.DataSource = list;


            dgvMatchResult.Columns[5].HeaderText = "Match ID";
            dgvMatchResult.Columns[0].HeaderText = "Date";
            dgvMatchResult.Columns[1].HeaderText = "Time";
            dgvMatchResult.Columns[2].HeaderText = "Home";
            dgvMatchResult.Columns[4].HeaderText = "Stadium";
            dgvMatchResult.Columns[3].HeaderText = "Away";


            dgvMatchResult.Columns[5].DisplayIndex = 0;
            dgvMatchResult.Columns[0].DisplayIndex = 1;
            dgvMatchResult.Columns[1].DisplayIndex = 2;
            dgvMatchResult.Columns[4].DisplayIndex = 3;
            dgvMatchResult.Columns[2].DisplayIndex = 4;
            dgvMatchResult.Columns[3].DisplayIndex = 5;


            dgvMatchResult.Columns[5].Width = 75;
            dgvMatchResult.Columns[4].Width = 200;

            dgvMatchResult.Columns[2].Width = 70;
            dgvMatchResult.Columns[3].Width = 70;

            dgvMatchResult.ClearSelection();
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to re-create new schedule?","Notification",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                list.Clear();
                MatchDAO.Instance.Delete_All();
                Create();
            }
        }

        private void SaveToDataBase()
        {
            for(int i=0;i<list.Count;i++)
            {
                MatchDAO.Instance.Insert_Match(list[i]);
            }
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMatchResult.RowCount==0)
                return;

            frmMatchSchedule.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmMatchSchedule.ActiveForm.Width = 955;
            frmMatchSchedule.ActiveForm.Update();

            dgvMatchResult.Enabled = false;
            pnlFooter.Visible = false;
        }
        private bool check_input()
        {
            if (dtpNewMatchDate.Value == null)
                return false;
            if (numericUpDown_hh.Value == 0 && numericUpDown_mm.Value == 0)
                return false;

            if (dtpNewMatchDate.Value < DateTime.Now.Date)
                return false;


            return true;
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                MatchDTO match_updated = new MatchDTO();

                match_updated = list[dgvMatchResult.CurrentCell.RowIndex];

                match_updated.Match_date = dtpNewMatchDate.Value;

                int h = (int)numericUpDown_hh.Value;
                int m = (int)numericUpDown_mm.Value;


                match_updated.Match_time = new TimeSpan(h, m, 0);
                frmMatchSchedule.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
                frmMatchSchedule.ActiveForm.Width = 701;
                frmMatchSchedule.ActiveForm.Update();
                MatchDAO.Instance.Update_Match(match_updated);
                dgvMatchResult.Enabled = true;

                MessageBox.Show("Match selected was updated.");
                pnlFooter.Visible = true;
            }
            else
                MessageBox.Show("Input wrong!!!");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            frmMatchSchedule.ActiveForm.StartPosition = FormStartPosition.CenterScreen;
            frmMatchSchedule.ActiveForm.Width = 701;
            frmMatchSchedule.ActiveForm.Update();
            dgvMatchResult.Enabled = true;
            pnlFooter.Visible = true;
        }

        #endregion

        
    }
}
