using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCode.DTO;
using System.Data;

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
            string query = @" exec InsertHumanInfor @humanid , @gender_id , @club_id , @human_name , @birthday , @nation , @path";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { hm.Human_id, hm.Gender_id, hm.Club_id, hm.Name, hm.Birthday, hm.Nation, hm.Path_img });

            return result > 0;
        }
        
        public bool UpdateHuman( HumanDTO human)
        {
            string query = @"exec UpdateHuman @human_name , @human_gender_id , @human_birthday , @human_nation , @human_id";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { human.Name, human.Gender_id, human.Birthday, human.Nation, human.Human_id });
            return result > 0;
        }

        /*
        public List<HumanDTO> SearchHumanByName(string name)
        {
            List<HumanDTO> list = new List<HumanDTO>();
            string query = string.Format(@"	select Row_number() over(order by h.HumanID) as OrderingNumber, h.Name, h.Birthday, (YEAR(GETDATE()) - YEAR(h.Birthday)) as Age,
                                            g.GenderName, c.ClubName, r.RoleName, h.Nation, p.KitNum, h.Path
                                            from HumanInformation as h, Club as c, Player as p, Role as r, Gender as g
                                            where h.HumanID = p.PlayerID and h.Human_ClubID = c.ClubID and h.GenderID = g.GenderID
                                            and p.RoleID = r.RoleID and h.Name like N'%{0}'", name);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HumanDTO player = new HumanDTO(item);
                list.Add(player);
            }
            return list;
        }
        */
        /*-------------------------------------------------------------------------------*/
        public DataTable SearchByName(string name)
        {
            string query = string.Format(@"	select Row_number() over(order by h.HumanID) as OrderingNumber, h.Name, h.Birthday, (YEAR(GETDATE()) - YEAR(h.Birthday)) as Age,
                                            g.GenderName, c.ClubName, r.RoleName, h.Nation, p.KitNum, h.Path
                                            from HumanInformation as h, Club as c, Player as p, Role as r, Gender as g
                                            where h.HumanID = p.PlayerID and h.Human_ClubID = c.ClubID and h.GenderID = g.GenderID
                                            and p.RoleID = r.RoleID and h.Name like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable SearchByClub(string club)
        {
            string query = string.Format(@"	select Row_number() over(order by h.HumanID) as OrderingNumber, h.Name, h.Birthday, (YEAR(GETDATE()) - YEAR(h.Birthday)) as Age,
                                            g.GenderName, c.ClubName, r.RoleName, h.Nation, p.KitNum, h.Path
                                            from HumanInformation as h, Club as c, Player as p, Role as r, Gender as g
                                            where h.HumanID = p.PlayerID and h.Human_ClubID = c.ClubID and h.GenderID = g.GenderID
                                            and p.RoleID = r.RoleID and c.ClubName like N'%{0}%'", club);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
        public DataTable SearchByRole(string role)
        {
            string query = string.Format(@"	select Row_number() over(order by h.HumanID) as OrderingNumber, h.Name, h.Birthday, (YEAR(GETDATE()) - YEAR(h.Birthday)) as Age,
                                            g.GenderName, c.ClubName, r.RoleName, h.Nation, p.KitNum, h.Path
                                            from HumanInformation as h, Club as c, Player as p, Role as r, Gender as g
                                            where h.HumanID = p.PlayerID and h.Human_ClubID = c.ClubID and h.GenderID = g.GenderID
                                            and p.RoleID = r.RoleID and r.RoleName like N'%{0}%'", role);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }
    }
}
