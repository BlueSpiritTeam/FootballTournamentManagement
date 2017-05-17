using SourceCode.Views;
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
    public partial class frmTournament : Form
    {
        public frmTournament()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGeneral general = new frmGeneral();
            general.ShowDialog();
            this.Close();
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMatchSchedule match_schedule = new frmMatchSchedule();
            match_schedule.ShowDialog();
            this.Close();
        }

        private void btn_recording_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMatchRecording recording = new frmMatchRecording();
            recording.ShowDialog();
            this.Close();
        }
    }
}
