using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    public class ClubDAO
    {
        private static ClubDAO instance;

        public static ClubDAO Instance
        {
            get
            {
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public ClubDAO ()
        {

        }

        #region

        public List<ClubDTO> LoadAllClubss()
        {
            List<ClubDTO> list = new List<ClubDTO>();

            DataTable data = DataProvider.Instance.ExcuteQuery("LoadAllClub");

            foreach(DataRow item in data.Rows)
            {
                ClubDTO club = new ClubDTO(item);

                list.Add(club);
            }

            return list;
        }

        #endregion
    }
}
