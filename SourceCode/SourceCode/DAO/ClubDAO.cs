using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode.DAO
{
    public class ClubDAO
    {
        //tao sigleton parttern
        private static ClubDAO instance;

        public static ClubDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ClubDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public ClubDAO ()
        {

        }

        #region

        public List<ClubDTO> LoadAllClubs()
        {
            List<ClubDTO> list = new List<ClubDTO>();
            //ket noi va chay cau truy van
            DataTable data = DataProvider.Instance.ExcuteQuery("LoadClubInfor");

            foreach(DataRow item in data.Rows)
            {
                ClubDTO club = new ClubDTO(item);

                list.Add(club);
            }

            return list;
        }

        public bool InsertNewClub(ClubDTO club)
        {
            string query = "exec InsertClub @club_id , @club_name , @stadium_name , @path";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {club.Club_id, club.Club_name, club.Stadium, club.Path});

            return result > 0;
        }
        #endregion
    }
}
