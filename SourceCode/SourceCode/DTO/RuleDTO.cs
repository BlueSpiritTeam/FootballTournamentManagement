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
        private uint max_age;
        private uint min_age;
        private uint max_player;
        private uint min_player;
        private uint score_win;
        private uint score_draw;
        private uint score_lose;

        #region properties
        public uint Max_age
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

        public uint Min_age
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

        public uint Max_player
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

        public uint Min_player
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

        public uint Score_win
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

        public uint Score_draw
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

        public uint Score_lose
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

        public RuleDTO(uint a, uint b, uint c, uint d, uint e, uint f, uint g)
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
            uint temp;

            uint.TryParse(row["MaximumAge"].ToString(), out temp);
            this.Max_age = temp;

            uint.TryParse(row["MinimumAge"].ToString(), out temp);
            this.Min_age = temp;

            uint.TryParse(row["MinimumNumberPlayer"].ToString(), out temp);
            this.Min_player = temp;

            uint.TryParse(row["MaximumNumberPlayer"].ToString(), out temp);
            this.Max_player = temp;

            uint.TryParse(row["ScoreWin"].ToString(), out temp);
            this.Score_win = temp;

            uint.TryParse(row["ScoreLose"].ToString(), out temp);
            this.Score_lose = temp;

            uint.TryParse(row["ScoreDraw"].ToString(), out temp);
            this.Score_draw = temp;
        }
    }
}
