using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    public class CoachDAO
    {
        //tao sigleton parttern
        private static CoachDAO instance;

        public static CoachDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CoachDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CoachDAO()
        {

        }

        #region methods

        public bool InsertNewCoach( CoachDTO coach)
        {
            string query = "exec InsertCoach @coach_id";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {coach.Coach_id });

            return result > 0;
        }

        public List<CoachDTO> LoadCoach()
        {
            List<CoachDTO> list = new List<CoachDTO>();
            //ket noi va chay cau truy van
            DataTable data = DataProvider.Instance.ExcuteQuery("LoadCoach");

            foreach (DataRow item in data.Rows)
            {
                CoachDTO coach = new CoachDTO(item);
                list.Add(coach);
            }

            return list;
        }
        #endregion
    }
}
