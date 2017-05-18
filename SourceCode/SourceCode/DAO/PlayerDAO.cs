using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    public class PlayerDAO
    {
        //tao sigleton parttern
        private static PlayerDAO instance;

        public static PlayerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PlayerDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public PlayerDAO()
        {

        }

        public bool InsertNewPlayer(PlayerDTO player)
        {
            string query = "exec InsertPlayer @player_id , @role_id , @goal_number , @assist_number , @kitnum";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { player.Player_id, player.Role_id,player.Goalnumber, player.Goalassist, player.Kitnum});

            return result > 0;
        }

        public DataTable LoadPlayer()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("LoadPlayerInformation");
            return data;
        }

        public bool UpdatePlayer(PlayerDTO player)
        {
            string query = "exec UpdatePlayer @player_id , @role_id , @kitnum";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { player.Player_id, player.Role_id, player.Kitnum });
            return result > 0;
        }
    }
}
