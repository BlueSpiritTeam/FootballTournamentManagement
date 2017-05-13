using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    class GenderDAO
    {
        private static GenderDAO instances;

        internal static GenderDAO Instances
        {
            get
            {
                return instances;
            }

            set
            {
                instances = value;
            }
        }

        public GenderDAO()
        { }

        public List<GenderDTO> LoadGender() //load Gender tu GenderDTO va tra ve mot List<> cac thuoc tinh cua gender
        {
            List<GenderDTO> list_gender = new List<GenderDTO>();
            //ket noi va chay cau truy van
            DataTable data = DataProvider.Instance.ExcuteQuery("LoadGender");

            foreach (DataRow item in data.Rows)
            {
                GenderDTO gender = new GenderDTO(item);
                list_gender.Add(gender); //add gender vao List<>
            }
            return list_gender; //tra ve mot List<> gender
        }
    }
}
