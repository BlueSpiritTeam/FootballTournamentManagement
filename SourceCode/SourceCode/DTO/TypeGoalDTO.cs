using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class TypeGoalDTO
    {
        private string type_id;
        private string type_name;


        #region properties
        public string Type_id
        {
            get
            {
                return type_id;
            }

            set
            {
                type_id = value;
            }
        }

        public string Type_name
        {
            get
            {
                return type_name;
            }

            set
            {
                type_name = value;
            }
        }

        #endregion


        public TypeGoalDTO()
        {

        }

        public TypeGoalDTO( string id, string name)
        {
            this.Type_id = id;
            this.Type_name = name;
        }

        public TypeGoalDTO(DataRow row)
        {
            this.Type_id = (string)row["TypeGoalID"].ToString();
            this.Type_name = (string)row["TypeGoalName"].ToString();
        }
    }
}
