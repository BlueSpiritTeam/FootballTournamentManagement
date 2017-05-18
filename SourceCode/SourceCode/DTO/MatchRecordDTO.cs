using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class MatchRecordDTO
    {
        private int matchid;
        private string home_club_ratio;
   
        public int Matchid
        {
            get
            {
                return matchid;
            }

            set
            {
                matchid = value;
            }
        }

        public string Home_club_ratio
        {
            get
            {
                return home_club_ratio;
            }

            set
            {
                home_club_ratio = value;
            }
        }

        public MatchRecordDTO() { }

        public MatchRecordDTO(int id, string ratio)
        {
            this.Matchid = id;
            this.Home_club_ratio = ratio;
        }

        public MatchRecordDTO(DataRow row)
        {
            this.Matchid = (int)row["MatchID"];
            this.Home_club_ratio = (string)row["HomeClubRatio"].ToString();

        }
    }
}
