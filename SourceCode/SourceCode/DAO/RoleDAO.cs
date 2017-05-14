using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;

        internal static RoleDAO Instances
        {
            get
            {
                if (instance == null)
                    instance = new RoleDAO(); // phai co cai nay moi dc khong no null là khong dc 

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public RoleDAO()
        { }

        #region methods
        public List<RoleDTO> LoadAllRoles() //load Gender tu GenderDTO va tra ve mot List<> cac thuoc tinh cua gender
        {
            List<RoleDTO> list_roles = new List<RoleDTO>();
            //ket noi va chay cau truy van
            DataTable data = DataProvider.Instance.ExcuteQuery("LoadRoles");

            foreach (DataRow item in data.Rows)
            {
                RoleDTO role = new RoleDTO(item);
                list_roles.Add(role); //add gender vao List<>
            }
            return list_roles; //tra ve mot List<> gender
        }

        public int GetRoleId(string role)
        {
            if (role == "Goalkeeper")
                return 1;
            else if (role == "Defender")
                return 2;
            else if (role == "Midfielder")
                return 3;
            else
                return 4;
        }

        #endregion
    }
}
