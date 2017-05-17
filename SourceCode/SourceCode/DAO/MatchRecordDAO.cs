using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
   public class MatchRecordDAO
    {
        private static MatchRecordDAO instance;

        public static MatchRecordDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MatchRecordDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public MatchRecordDAO()
        {

        }

        public bool Check_A_MatchRecord(int id)
        {
            string query = "exec Check_A_MatchRecord @MatchID";

            int result = (int)DataProvider.Instance.ExcuteScalar(query, new object[] { id });

            if (result == 0)
                return false;
            return true;
        }
        public bool Insert_A_MatchRecord(MatchRecordDTO record)
        {
            string query = "exec Insert_A_MatchRecord @MatchID , @HomeClubRatio";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { record.Matchid, record.Home_club_ratio });


            return result > 0;
        }
    }
}
