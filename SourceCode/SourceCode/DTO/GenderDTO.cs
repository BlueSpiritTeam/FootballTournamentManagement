using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    class GenderDTO
    {
        private string gender_id;
        private string gender_name;

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

        public string Gender_name
        {
            get
            {
                return gender_name;
            }

            set
            {
                gender_name = value;
            }
        }

        public GenderDTO() { }

        public GenderDTO(string gid,string gname)
        {
            this.Gender_id = gid;
            this.Gender_name = gname;
        }

        public GenderDTO(DataRow row)
        {
            this.Gender_id = (string)row["GenderID"].ToString();
            this.Gender_name = (string)row["GenderName"].ToString();
        }
    }
}
