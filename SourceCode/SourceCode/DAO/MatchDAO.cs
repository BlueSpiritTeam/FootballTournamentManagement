using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    public class MatchDAO
    {
        private static MatchDAO instance;

        public static MatchDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MatchDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public MatchDAO()
        {

        }

        #region methods
        public List<MatchDTO> LoadAllMatches()
        {
            string query = "exec Load_Matches";


            List<MatchDTO> list = new List<MatchDTO>();

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                MatchDTO match = new MatchDTO(item);
                list.Add(match);
            }

            return list;
        }

        public bool Insert_Match(MatchDTO match)
        {
            string query = "exec Insert_Matches @MatchID , @MatchDate , @MatchTime , @HomeClubName , @GuestClubName , @Stadium";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { match.Match_id, match.Match_date, match.Match_time, match.Home_club_name, match.Guest_club_name, match.Stadium });
            return result > 0;
        }

        public bool Delete_All()
        {
            string query = "exec Delete_All_Matches";

            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool Update_Match(MatchDTO match)
        {
            string query = "exec Update_Match @MatchID , @MatchDate , @MatchTime , @HomeClubName , @GuestClubName , @Stadium";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { match.Match_id, match.Match_date, match.Match_time, match.Home_club_name, match.Guest_club_name, match.Stadium });

            return result > 0;
        }
        #endregion
    }
}
