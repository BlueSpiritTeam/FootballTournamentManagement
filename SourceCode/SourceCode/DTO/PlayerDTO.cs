using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    class PlayerDTO : Human
    {
        private string player_id;
        private string role;
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

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
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

        public PlayerDTO(string pid, string name, string gender, string clubid, string role, DateTime birth, string nation, int goal, int assist, int kit)
        {
            this.Player_id = pid;
            this.Name = name;
            this.Gender = gender;
            this.Club_id = clubid;
            this.Role = role;
            this.Birthday = birth;
            this.Nation = nation;
            this.Goalnumber = goal;
            this.Goalassist = assist;
            this.Kitnum = kit;
        }

    }
}
