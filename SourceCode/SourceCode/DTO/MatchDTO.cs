using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SourceCode.DTO
{
    class MatchDTO
    {
        private uint match_id;
        private DateTime match_date;
        private string match_time;      //khai báo lại kiểu time giùm tao!
        private string home_club_name;
        private string guest_club_name;
        private string stadium;

        public uint Match_id
        {
            get
            {
                return match_id;
            }

            set
            {
                match_id = value;
            }
        }

        public DateTime Match_date
        {
            get
            {
                return match_date;
            }

            set
            {
                match_date = value;
            }
        }

        public string Match_time
        {
            get
            {
                return match_time;
            }

            set
            {
                match_time = value;
            }
        }

        public string Home_club_name
        {
            get
            {
                return home_club_name;
            }

            set
            {
                home_club_name = value;
            }
        }

        public string Guest_club_name
        {
            get
            {
                return guest_club_name;
            }

            set
            {
                guest_club_name = value;
            }
        }

        public string Stadium
        {
            get
            {
                return stadium;
            }

            set
            {
                stadium = value;
            }
        }

        public MatchDTO() { }

        public MatchDTO(uint mid, DateTime mdate, string mtime, string hcname, string gcname, string s)
        {
            this.Match_id = mid;
            this.Match_date = mdate;
            this.Match_time = mtime;
            this.Home_club_name = hcname;
            this.Guest_club_name = gcname;
            this.Stadium = s;
        }

        public MatchDTO(DataRow row)
        {
            this.Match_id = uint.Parse(row["MatchID"].ToString());
            this.Match_date = DateTime.Parse(row["MacthDate"].ToString());
            this.Match_time = (string)row["MatchTime"].ToString();
            this.Home_club_name = (string)row["HomeClubName"].ToString();
            this.Guest_club_name = (string)row["GuestClubName"].ToString();
            this.Stadium = (string)row["Stadium"].ToString();
        }
    }
}
