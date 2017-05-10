using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class RuleDTO
    {
        private int max_age;
        private int min_age;
        private int max_player;
        private int min_player;
        private int score_win;
        private int score_draw;
        private int score_lose;

        #region properties
        public int Max_age
        {
            get
            {
                return max_age;
            }

            set
            {
                max_age = value;
            }
        }

        public int Min_age
        {
            get
            {
                return min_age;
            }

            set
            {
                min_age = value;
            }
        }

        public int Max_player
        {
            get
            {
                return max_player;
            }

            set
            {
                max_player = value;
            }
        }

        public int Min_player
        {
            get
            {
                return min_player;
            }

            set
            {
                min_player = value;
            }
        }

        public int Score_win
        {
            get
            {
                return score_win;
            }

            set
            {
                score_win = value;
            }
        }

        public int Score_draw
        {
            get
            {
                return score_draw;
            }

            set
            {
                score_draw = value;
            }
        }

        public int Score_lose
        {
            get
            {
                return score_lose;
            }

            set
            {
                score_lose = value;
            }
        }

        #endregion


        public RuleDTO()
        {
            // hàm dựng cơ bản
        }

        public RuleDTO(int a, int b, int c, int d, int e, int f, int g)
        {
            // hàm dựng cơ bản
            this.Max_age = a;
            this.Min_age = b;
            this.Max_player = c;
            this.Min_player = d;
            this.Score_win = e;
            this.Score_draw = f;
            this.Score_lose = g;
        }

        public RuleDTO(DataRow row)
        {

            // hàm dựng với datarow
            int temp;

            int.TryParse(row["MaximumAge"].ToString(), out temp);
            this.Max_age = temp;

            int.TryParse(row["MinimumAge"].ToString(), out temp);
            this.Min_age = temp;

            int.TryParse(row["MinimumNumberPlayer"].ToString(), out temp);
            this.Min_player = temp;

            int.TryParse(row["MaximumNumberPlayer"].ToString(), out temp);
            this.Max_player = temp;

            int.TryParse(row["ScoreWin"].ToString(), out temp);
            this.Score_win = temp;

            int.TryParse(row["ScoreLose"].ToString(), out temp);
            this.Score_lose = temp;

            int.TryParse(row["ScoreDraw"].ToString(), out temp);
            this.Score_draw = temp;
        }
    }
}
