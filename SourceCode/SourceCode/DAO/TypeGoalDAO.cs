using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    public class TypeGoalDAO
    {
        private static TypeGoalDAO instance;

        public static TypeGoalDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TypeGoalDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public TypeGoalDAO()
        {

        }


        #region methods

        public List<TypeGoalDTO> LoadTypeGoal()
        {
            List<TypeGoalDTO> list = new List<TypeGoalDTO>();

            DataTable data = DataProvider.Instance.ExcuteQuery("LoadTypeGoal");

            foreach(DataRow item in data.Rows)
            {
                TypeGoalDTO type = new TypeGoalDTO(item);
                list.Add(type);
            }

            return list;
        }

       public bool DeleteType(string id)
        {
            int temp;
            int.TryParse(id, out temp);


            string query = "exec DeleteTypeGoal @TypeGoalID";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {temp});

            return result > 0;
        }

        #endregion
    }
}
