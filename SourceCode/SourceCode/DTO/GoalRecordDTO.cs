using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    class GoalRecordDTO
    {
        private string player_score_id;
        private string player_assist_id;
        private uint round_id;
        private uint type_goal_id;
        private string time_to_goal;

        public string Player_score_id
        {
            get
            {
                return player_score_id;
            }

            set
            {
                player_score_id = value;
            }
        }

        public string Player_assist_id
        {
            get
            {
                return player_assist_id;
            }

            set
            {
                player_assist_id = value;
            }
        }

        public uint Round_id
        {
            get
            {
                return round_id;
            }

            set
            {
                round_id = value;
            }
        }

        public uint Type_goal_id
        {
            get
            {
                return type_goal_id;
            }

            set
            {
                type_goal_id = value;
            }
        }

        public string Time_to_goal
        {
            get
            {
                return time_to_goal;
            }

            set
            {
                time_to_goal = value;
            }
        }

        public GoalRecordDTO()
        {

        }

        public GoalRecordDTO(string sid, string aid, uint rid, uint tgid, string ttg)
        {
            this.Player_score_id = sid;
            this.Player_assist_id = aid;
            this.Round_id = rid;
            this.Type_goal_id = tgid;
            this.Time_to_goal = ttg;
        }

        public GoalRecordDTO(DataRow row)
        {
            this.Player_score_id = (string)row["PlayerScoreID"].ToString();
            this.Player_assist_id = (string)row["PlayerAssistID"].ToString();
            this.Round_id = uint.Parse(row["RoundID"].ToString());
            this.Type_goal_id = uint.Parse(row["TypeGoalID"].ToString());
            this.Time_to_goal = (string)row["TimeToGoal"].ToString();

        }
    }
}
