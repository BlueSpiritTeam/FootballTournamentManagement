using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    public class RuleDAO
    {
        private static RuleDAO instance; // sử dụng mọi nơi

        public static RuleDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RuleDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public RuleDAO()
        {

        }


        #region methods

        public RuleDTO LoadRules()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("LoadRuleS"); // stored procedure "LoadRules" đã đc chạy trên sql server
            foreach (DataRow item in data.Rows)
            {
                RuleDTO rule = new RuleDTO(item); // chỗ này hơi rườm rà nhưng là cách duy nhất t có thể làm
                return rule;
            }
            return null;
        }

        public bool UpdateRule(RuleDTO rule)
        {
            string query = "exec UpdateRule @MaximumAge , @MinimumAge , @MinimumNumberPlayer , @MaximumNumberPlayer , @ScoreWin , @ScoreLose , @ScoreDraw";
            int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] {rule.Max_age,rule.Min_age,rule.Min_player,rule.Max_player,rule.Score_win,rule.Score_lose,rule.Score_draw });


            return result > 0;
        }


        #endregion

    }
}
