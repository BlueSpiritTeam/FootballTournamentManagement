using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    class HumandInformationDTO
    {
        private string humand_id;
        private string gender_id;
        private string club_id;
        private string name;
        private DateTime birthday;
        private string nation;

        public string Humand_id
        {
            get
            {
                return humand_id;
            }

            set
            {
                humand_id = value;
            }
        }

        public string Gender_id
        {
            get
            {
                return gender_id;
            }

            set
            {
                gender_id = value;
            }
        }

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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public string Nation
        {
            get
            {
                return nation;
            }

            set
            {
                nation = value;
            }
        }

        public HumandInformationDTO() { }
        
        public HumandInformationDTO(string hid, string gid, string cid, string n, DateTime bd, string nt)
        {
            this.Humand_id = hid;
            this.Gender_id = gid;
            this.Club_id = cid;
            this.Name = n;
            this.Birthday = bd;
            this.Nation = nt;
        }

        public HumandInformationDTO(DataRow row)
        {
            this.Humand_id = (string)row["HumandID"].ToString();
            this.Gender_id = (string)row["GenderID"].ToString();
            this.Club_id = (string)row["ClubID"].ToString();
            this.Name = (string)row["Name"].ToString();
            this.Birthday = DateTime.Parse(row["Birthday"].ToString());
            this.Nation = (string)row["Nation"].ToString();
        }
    }
}
