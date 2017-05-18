using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class PlayerDTO : HumanDTO
    {
        private string player_id;
        private int role_id;
        private int goalnumber;
        private int goalassist;
        private int kitnum;

        public string Player_id
        {
            get
            {
                return player_id;
            }

            set
            {
                player_id = value;
            }
        }

        public int Role_id
        {
            get
            {
                return role_id;
            }

            set
            {
                role_id = value;
            }
        }

        public int Goalnumber
        {
            get
            {
                return goalnumber;
            }

            set
            {
                goalnumber = value;
            }
        }

        public int Goalassist
        {
            get
            {
                return goalassist;
            }

            set
            {
                goalassist = value;
            }
        }

        public int Kitnum
        {
            get
            {
                return kitnum;
            }

            set
            {
                kitnum = value;
            }
        }


        public PlayerDTO()
        {

        }
        
        public PlayerDTO(string pid, string name, string gender, string clubid, int role_id, DateTime birth, string nation, int goal, int assist, int kit)
        {
            this.Player_id = pid;
            this.Name = name;
            this.Gender_id = gender;
            this.Club_id = clubid;
            this.Role_id = role_id;
            this.Birthday = birth;
            this.Nation = nation;
            this.Goalnumber = goal;
            this.Goalassist = assist;
            this.Kitnum = kit;
        }
        public PlayerDTO(string pid, int r, int k)
        {
            this.Player_id = pid;
            this.Role_id = r;
            this.Kitnum = k;
        }
        public PlayerDTO(string pid, int roleid, int gn, int gas, int k)
        {
            this.Player_id = pid;
            this.Role_id = roleid;
            this.Goalnumber = gn;
            this.Goalassist = gas;
            this.Kitnum = k;
        }


        public PlayerDTO(DataRow row)
        {

            this.Player_id = (string)(row["PlayerID"].ToString());
            int temp;

            int.TryParse(row["RoleID"].ToString(), out temp);
            this.Role_id = temp;

            int.TryParse(row["GoalNumber"].ToString(), out temp);
            this.Goalnumber = temp;

            int.TryParse(row["AssistNumber"].ToString(), out temp);
            this.Goalassist = temp;

            int.TryParse(row["KitNum"].ToString(), out temp);
            this.Kitnum = temp;
        }
    }
}
