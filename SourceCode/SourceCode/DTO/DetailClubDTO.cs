using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class DetailClubDTO
    {
        private string clubid;
        private int total_point;
        private int numberwin;
        private int numberlose;
        private int numberdraw;
        private int offset;
        private int wingoal;
        private int losegoal;


        #region properties
        public string Clubid
        {
            get
            {
                return clubid;
            }

            set
            {
                clubid = value;
            }
        }

        public int Total_point
        {
            get
            {
                return total_point;
            }

            set
            {
                total_point = value;
            }
        }

        public int Numberlose
        {
            get
            {
                return numberlose;
            }

            set
            {
                numberlose = value;
            }
        }

        public int Numberwin
        {
            get
            {
                return numberwin;
            }

            set
            {
                numberwin = value;
            }
        }

        public int Numberdraw
        {
            get
            {
                return numberdraw;
            }

            set
            {
                numberdraw = value;
            }
        }

        public int Offset
        {
            get
            {
                return offset;
            }

            set
            {
                offset = value;
            }
        }

        public int Wingoal
        {
            get
            {
                return wingoal;
            }

            set
            {
                wingoal = value;
            }
        }

        public int Losegoal
        {
            get
            {
                return losegoal;
            }

            set
            {
                losegoal = value;
            }
        }

        #endregion


        public DetailClubDTO()
        {

        }


        public DetailClubDTO(string cludid, int total_point, int numberwin, int numberlose, int numberdraw, int offset, int wingoal, int losegoal)
        {
            this.Clubid = clubid;
            this.Total_point = total_point;
            this.Numberwin = numberwin;
            this.Numberlose = numberlose;
            this.Numberdraw = numberdraw;
            this.Offset = offset;
            this.Wingoal = wingoal;
            this.Losegoal = losegoal;
        }

        public DetailClubDTO(DataRow row)
        {
            this.Clubid = (string)row["ClubID"].ToString();
            this.Total_point = (int)row["TotalPoint"];
            this.Numberwin = (int)row["NumberOfWinMatch"];
            this.Numberlose = (int)row["NumberOfLoseMatch"];
            this.Numberdraw = (int)row["NumberOfDrawMatch"];
            this.Offset = (int)row["Offset"];
            this.Wingoal = (int)row["TotalWinGoal"];
            this.Losegoal = (int)row["TotalLoseGoal"];
        }
    }
}
