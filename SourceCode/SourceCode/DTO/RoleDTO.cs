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
        private uint role_id;
        private string role_name;

        public uint Role_id
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

        public RoleDTO(uint rid, string rname)
        {
            this.Role_id = rid;
            this.Role_name = rname;
        }

        public RoleDTO(DataRow row)
        {
            this.Role_id = uint.Parse(row["RoleID"].ToString());
            this.Role_name = (string)row["RoleName"].ToString();
        }
    }
}
