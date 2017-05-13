using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    class MatchRecordDTO
    {
        private int home_club_ratio;
        private int guest_club_ratio;

        public int Home_club_ratio
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

        public int Guest_club_ratio
        {
            get
            {
                return guest_club_ratio;
            }

            set
            {
                guest_club_ratio = value;
            }
        }

        public MatchRecordDTO() { }

        public MatchRecordDTO(int hclubratio, int gclubratio)
        {
            this.Home_club_ratio = hclubratio;
            this.Guest_club_ratio = gclubratio;
        }

        public MatchRecordDTO(DataRow row)
        {
            this.Home_club_ratio = int.Parse(row["HomeClubRatio"].ToString());
            this.Guest_club_ratio = int.Parse(row["GuestClub"].ToString());
        }
    }
}
