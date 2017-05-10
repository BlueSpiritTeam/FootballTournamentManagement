using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SourceCode.DTO
{
    class RoleDTO
    {
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

        public RoleDTO() { }

        public RoleDTO(string rname)
        {
            this.Role_name = rname;
        }

        public RoleDTO(DataRow row)
        {
            this.Role_name = (string)row["RoleName"].ToString();
        }
    }
}
