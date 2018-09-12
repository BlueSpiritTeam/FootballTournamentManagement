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

        public DataTable LoadPlayersByClubID(string a, string b)
        {
            string query = "exec LoadPlayerBelongToMatch @ClubID_A , @ClubID_B";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { a, b });
            return data;
        }

        public bool UpdateGoal(string id)
        {
            string query = "exec UpdateGoalPlayer @PlayerID";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id });

            return result > 0;
        }

        public bool UpdateAssistance(string id)
        {
            string query = "exec UpdateAssistance @PlayerID";

            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { id });

            return result > 0;
        }

        public DataTable ListPlayerToScore()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("ListPlayerToScore");
            return dt;
        }
    }
}
