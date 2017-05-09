using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    class PlayerDTO
    {
        private string player_id;
        private uint role_id;
        private uint goal_num;
        private uint assist_num;
        private uint kit_num;
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

        public uint Role_id
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

        public uint Goal_num
        {
            get
            {
                return goal_num;
            }

            set
            {
                goal_num = value;
            }
        }

        public uint Assist_num
        {
            get
            {
                return assist_num;
            }

            set
            {
                assist_num = value;
            }
        }

        public uint Kit_num
        {
            get
            {
                return kit_num;
            }

            set
            {
                kit_num = value;
            }
        }

        public PlayerDTO(){ }

        public PlayerDTO(string pid, uint rid,  uint gnum, uint anum, uint knum)
        {
            this.Player_id = pid;
            this.Role_id = rid;
            this.Goal_num = gnum;
            this.Assist_num = anum;
            this.Kit_num = knum;
        }

        public PlayerDTO(DataRow row)
        {
            this.Player_id = (string)row["PlayerID"].ToString();
            this.Role_id = uint.Parse(row["RoleID"].ToString());
            this.Goal_num = uint.Parse(row["GoalNumber"].ToString());
            this.Assist_num = uint.Parse(row["AssistNumber"].ToString());
            this.Kit_num = uint.Parse(row["KitNum"].ToString());
        }
    }
}
