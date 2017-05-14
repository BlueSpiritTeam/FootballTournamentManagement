using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SourceCode.DTO
{
    public class RoleDTO
    {
        private int role_id;
        private string role_name;

        public string Role_name
        {
            get
            {
                return role_name;
            }

            set
            {
                role_name = value;
            }
        }

        public int Role_id
        {
            get
            {
                return role_id;
            }

            set
            {
                role_id = value;
            }
        }

        public RoleDTO() { }

        public RoleDTO(string rname, int rid)
        {
            this.Role_name = rname;
            this.Role_id = rid;
        }

        public RoleDTO(DataRow row)
        {
            int temp;
            this.Role_name = (string)row["RoleName"].ToString();  
            int.TryParse(row["RoleID"].ToString(), out temp);
            this.Role_id = temp;
        }
    }
}
