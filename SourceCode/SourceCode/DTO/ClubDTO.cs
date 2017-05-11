using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class ClubDTO
    {
        private string club_id;
        private string club_name;
        private string stadium;
        private uint point;

        public string Club_id
        {
            get
            {
                return club_id;
            }

            set
            {
                club_id = value;
            }
        }

        public string Club_name
        {
            get
            {
                return club_name;
            }

            set
            {
                club_name = value;
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

        public uint Point
        {
            get
            {
                return point;
            }

            set
            {
                point = value;
            }
        }

        public ClubDTO() { }

        public ClubDTO(string cid, string cname, string s,uint p)
        {
            this.Club_id = cid;
            this.Club_name = cname;
            this.Stadium = s;
            this.Point = p;
        }

        public ClubDTO(DataRow row)
        {
            this.Club_id = (string)row["ClubID"].ToString();
            this.Club_name = (string)row["ClubName"].ToString();
            this.Stadium = (string)row["StadiumName"].ToString();
            this.Point = uint.Parse(row["TotalPoint"].ToString());
        }
    }
}
