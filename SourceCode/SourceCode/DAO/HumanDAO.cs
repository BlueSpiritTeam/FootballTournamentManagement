using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCode.DTO;

namespace SourceCode.DAO
{
    public class HumanDAO
    {
        private static HumanDAO instance;

        public static HumanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HumanDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public HumanDAO() { }

        public bool InsertNewHuman(HumanDTO hm)
        {
            string query = "exec InsertClub @human_id, @gender_id, @club_id, @human_name, @birthday, @nation, @path";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {hm.Human_id});

            return result > 0;
        }
    }
}
