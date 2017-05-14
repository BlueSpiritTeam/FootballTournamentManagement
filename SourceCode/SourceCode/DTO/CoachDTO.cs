using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class CoachDTO : HumanDTO
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

        public CoachDTO(string cid)
        {
            this.Coach_id = cid;
        }

        /*
        public CoachDTO(string cid, string gid, string clubid, string n, DateTime bd, string nt, string p)
        {
            this.Coach_id = cid;
            this.Gender_id = gid;
            this.Club_id = cid;
            this.Name = n;
            this.Birthday = bd;
            this.Nation = nt;
            this.Path_img = p;
        }
        */
        
        public CoachDTO(DataRow row)
        {
            this.Coach_id = (string)row["CoachID"].ToString();
            //this.Gender_id = (string)row["GenderName"].ToString();
            //this.Club_id = (string)row["ClubID"].ToString();
            //this.Name = (string)row["Name"].ToString();
            //this.Birthday = DateTime.Parse(row["Birthday"].ToString());
            //this.Nation = (string)row["Nation"].ToString();
            //this.Path_img = (string)row["Path"].ToString();
        }
        
    }
}
