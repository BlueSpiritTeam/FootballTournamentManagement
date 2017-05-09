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
        private uint match_id;
        private uint home_club_ratio;
        private uint guest_club_ratio;

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

        public uint Home_club_ratio
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

        public uint Guest_club_ratio
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

        public MatchRecordDTO(uint mid, uint hclubratio, uint gclubratio)
        {
            this.Match_id = mid;
            this.Home_club_ratio = hclubratio;
            this.Guest_club_ratio = gclubratio;
        }

        public MatchRecordDTO(DataRow row)
        {
            this.Match_id = uint.Parse(row["MatchID"].ToString());
            this.Home_club_ratio = uint.Parse(row["HomeClubRatio"].ToString());
            this.Guest_club_ratio = uint.Parse(row["GuestClub"].ToString());
        }
    }
}
