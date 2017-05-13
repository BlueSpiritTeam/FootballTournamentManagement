using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    class CoachDTO : Human
    {
        private string coach_id;

        public string Coach_id
        {
            get
            {
                return coach_id;
            }

            set
            {
                coach_id = value;
            }
        }

        //construtor
        public CoachDTO()
        {

        }

        public CoachDTO(string cid, string gid, string clubid, string n, DateTime bd, string nt)
        {
            this.Coach_id = cid;
            this.Gender = gid;
            this.Club_id = cid;
            this.Name = n;
            this.Birthday = bd;
            this.Nation = nt;
        }

        public CoachDTO(DataRow row)
        {
            this.Coach_id = (string)row["CoachID"].ToString();
            this.Gender = (string)row["GenderName"].ToString();
            this.Club_id = (string)row["ClubID"].ToString();
            this.Name = (string)row["Name"].ToString();
            this.Birthday = DateTime.Parse(row["Birthday"].ToString());
            this.Nation = (string)row["Nation"].ToString();
        }
    }
}
