using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.DAO
{
    public class ClubDAO
    {
        //tao sigleton parttern
        private static ClubDAO instance;

        public static ClubDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClubDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public ClubDAO ()
        {

        }

        #region

        public List<ClubDTO> LoadAllClubs()
        {
            List<ClubDTO> list = new List<ClubDTO>();
            //ket noi va chay cau truy van
            DataTable data = DataProvider.Instance.ExcuteQuery("LoadClubInfor");

            foreach(DataRow item in data.Rows)
            {
                ClubDTO club = new ClubDTO(item);
                list.Add(club);
            }
            return list;
        }

        public DataTable LoaClubs()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("LoadAllClubInfor");
            return data;
        }

        public DataTable LoadRankOfClub()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("LoadRankOfClub");
            return dt;
        }
        public DataTable LoadAllPlayerForClub(string ID)
        {
            //can tra ra mot DataTable, Neu dung ExcuteNonQuery() thi khong tra ra duoc, //optimize dung excuteQuery()
            string cstr = @"select Row_number() over(order by PlayerID) as OrderingPlayer, h.Name as PlayerName, r.RoleName, p.KitNum
	                        from dbo.HumanInformation as h, dbo.Club as c, dbo.Player as p, dbo.Role as r 
	                        where h.Human_ClubID = c.ClubID and h.HumanID = p.PlayerID and p.RoleID = r.RoleID and c.ClubID = '" + ID + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(cstr);
            return data;

        }
        public bool InsertNewClub(ClubDTO club)
        {
            string query = "exec InsertClub @club_id , @club_name , @stadium_name , @path";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {club.Club_id, club.Club_name, club.Stadium, club.Path});
            return result > 0;
        }

        
        public bool UpdateClub(ClubDTO club)
        {
            string query = "exec UpdateClub @club_name , @stadium_name , @club_id";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {club.Club_name , club.Stadium, club.Club_id });
            return result > 0;
        }
        
        public bool InitializeDetailClub(string id)
        {
            string query = "exec InitializeDetailClub @ClubID";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id });

            return result > 0; ;
        }

        public bool UpdateDetailClub(DetailClubDTO detail)
        {
            string query = "exec UpdateDetailClub @ClubID , @TotalPoint , @NumberOfWinMatch , @NumberOfLoseMatch , @NumberOfDrawMatch , @Offset , @TotalWinGoal , @TotalLoseGoal";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { detail.Clubid, detail.Total_point, detail.Numberwin, detail.Numberlose, detail.Numberdraw, detail.Offset, detail.Wingoal, detail.Losegoal });

            return result > 0;
        }

        public DetailClubDTO GetDetailClub(string clubid)
        {
            string query = "exec GetDetailClub @ClubID";

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { clubid });

            foreach(DataRow item in data.Rows)
            {
                DetailClubDTO detail = new DetailClubDTO(item);
                return detail;
            }
            return null;
             
        }
        #endregion
    }
}
