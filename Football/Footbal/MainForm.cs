using Footbal.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Footbal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //var db = new Db();
            //db.GetTeams();

            var db = new Db("Server=LOUIS-PC\\SQLEXPRESS;Database=Football;Uid=football;Pwd=football;");

            //var t = new Team();
            //t.Name = "";

            //var t2 = new Team
            //{
            //    Name = "",
            //    TeamId = 2,
            //};
            
            //update
           /* db.CreateTeam(new Team
            {
                Name = "Khuong"
            });

            db.UpdateTeam(new Team{
                Name =DateTime.Now.ToString(),
                Id = 3              
            });
            */
            /*
            var ds = db.Query("SELECT TeamName FROM Team");

            //check null
            if(ds != null && ds.Tables.Count == 1 && ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    if(dr[0] == null || dr[0] == DBNull.Value)
                    {
                        
                    }
                }
            }
            */
        }
        
        private void btAddTeam_Click(object sender, EventArgs e)
        {
            var dlg = new UI.AddTeam();
            dlg.ShowDialog();
        }
       
       
        private void btUppdateTeam_Click(object sender, EventArgs e)
        {
            var dlg = new UI.TeamList();
            dlg.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
