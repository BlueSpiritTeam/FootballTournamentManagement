using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Footbal.UI
{
    public partial class TeamList : Form
    {
        public TeamList()
        {
            InitializeComponent();
        }

        private ColumnHeader CreateListviewColumnHeader(DataColumn column)
        {
            ColumnHeader result = new ColumnHeader();
            result.Text = column.ColumnName;
            if (column.DataType == typeof(int))
            {
                result.Width = 50;
            }
            else if (column.DataType == typeof(string))
            {
                result.Width = column.MaxLength <= 50 ? 100 : 200;
            }
            return result;
        }

        private void TeamList_Load(object sender, EventArgs e)
        {
            this.LoadTeamList();
        }
        private void LoadTeamList()
        {
            var db = new Database.Db();
            //create dataset
            DataSet ds = db.GetTeams();

            // clear listview first
            listView1.Items.Clear();

            var dt = ds.Tables[0];

            //add database to list view
            if (listView1.Columns.Count == 1)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    listView1.Columns.Add(this.CreateListviewColumnHeader(column));
                }
            }
            int index = 0;
            var keyColumn = dt.PrimaryKey[0];
            var items = new List<ListViewItem>();
            foreach (DataRow row in dt.Rows)
            {
                var item = new ListViewItem();
                item.Tag = row[keyColumn];
                item.Text = (++index).ToString("000");

                foreach(DataColumn column in dt.Columns)
                {
                    item.SubItems.Add(row[column].ToString());
                }
                items.Add(item);                
            }

            this.listView1.Items.AddRange(items.ToArray());
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listView1.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            if(item == null)
            {
                this.listView1.SelectedItems.Clear();
                MessageBox.Show("Please select a team!");
            }
            else
            {
                var teamId = (int)item.Tag;
                var dlg = new UI.EditTeam();
                dlg.TeamId = teamId;
                var updatedResult = dlg.ShowDialog();
                if (updatedResult == DialogResult.OK)
                    this.LoadTeamList();
            }
        }
    }
}
