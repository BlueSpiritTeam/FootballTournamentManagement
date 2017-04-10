using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footbal.Database
{
    public class Db
    {
        public Db()
        {
           this.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["DbConnection"];
        }

        public Db(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }

        public int UpdateTeam(Team team)
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = new SqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    //tranh Sql enjection
                    //cmd.CommandText = "UPDATE Team SET TeamName='" + team.Name + "' WHERE TeamId=" + team.Id;
                    cmd.CommandText = "UPDATE Team SET TeamName=@teamName, Stadium=@Stadium WHERE TeamId='" + team.Id.ToString() + "'" ;
                    cmd.Parameters.Add(new SqlParameter("@teamName", team.Name));
                    cmd.Parameters.Add(new SqlParameter("@Stadium", team.Stadium));
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    return result;
                }
            }
        }
        public int CreateTeam(Team team)
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                int result = 0;
                conn.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT Team(TeamName) VALUES(@teamName)";
                    cmd.Parameters.Add(new SqlParameter("@teamName", team.Name));
                    result = cmd.ExecuteNonQuery();
                    conn.Close();                  
                }
                conn.Close();
                return result;
            }
        }
        public DataSet GetTeams()
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM Team"))
                {
                    cmd.Connection = conn;
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    var ds = new DataSet();
                    adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adapter.Fill(ds);
                    return ds;
                }
               
            }
        }

        public DataSet GetTeam(int teamId)
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM Team WHERE (TeamId = " + teamId + ")"))
                {
                    cmd.Connection = conn;
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    var ds = new DataSet();
                    adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }
      
        public int ExcuteNonQuery(string sql)
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            {
                int resultCount = 0;
                conn.Open();
                using (var cmd = new SqlCommand(sql))
                {
                    cmd.Connection = conn;
                    resultCount = cmd.ExecuteNonQuery();                  
                }
                conn.Close();
                return resultCount;
            }
        }

        public int DeleteTeam(int teamId)
        {
            if (teamId < 1)
                return 0; //should use "throw new exception"
           return this.ExcuteNonQuery("DELETE Team WHERE teamId =" + teamId);
        }
        public DataSet Query(string sql)
        {
            using (var conn = new SqlConnection(this.ConnectionString))
            { 
                using (var cmd = new SqlCommand(sql))
                {
                    cmd.Connection = conn;
                    var adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    var ds = new DataSet();
                    adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }

      
    }
}