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
        private string path;
        #region properties
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

        public string Path
        {
            get
            {
                return path;
            }

            set
            {
                path = value;
            }
        }


        #endregion
        public ClubDTO() { }

        //this.Path(chu hoa la ntn)
        public ClubDTO(DataRow row)
        {
            this.Club_id = (string)row["ClubID"].ToString();
            this.Club_name = (string)row["ClubName"].ToString();
            this.Stadium = (string)row["StadiumName"].ToString();
            this.Path = (string)row["Path"].ToString();
        }

        public ClubDTO(string club_id, string club_name, string stadium, string path)
        {
            this.club_id = club_id;
            this.club_name = club_name;
            this.stadium = stadium;
            this.path = path;
        }

        public ClubDTO(string clubname, string stadium, string id)
        {
            this.club_name = clubname;
            this.stadium = stadium;
            this.club_id = id;
        }
    }
}
