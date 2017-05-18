using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    public class GenderDAO
    {
        private static GenderDAO instance;

        internal static GenderDAO Instances
        {
            get
            {
                if (instance == null)
                    instance = new GenderDAO(); // phai co cai nay moi dc khong no null là khong dc 

                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public GenderDAO()
        { }

        #region methods
        public List<GenderDTO> LoadAllGender() //load Gender tu GenderDTO va tra ve mot List<> cac thuoc tinh cua gender
        {
            //dinh nghia mot List<Gender>
            List<GenderDTO> list_gender = new List<GenderDTO>();
            //DataTable de ExecuteQuery
            DataTable data = DataProvider.Instance.ExcuteQuery("LoadGender");

            //lay ra tung dong trong DataRow
            foreach (DataRow item in data.Rows)
            {
                GenderDTO gender = new GenderDTO(item);
                list_gender.Add(gender); //add gender vao List<>
            }
            return list_gender; //tra ve mot List<> gender
        }

        public string GetGenderID(string gender)
        {
            if (gender == "Female")
                return "F";
            else
                return "M";
        }

        #endregion
    }
}
