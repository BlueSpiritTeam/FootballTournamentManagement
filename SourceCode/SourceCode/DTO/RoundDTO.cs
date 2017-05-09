using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SourceCode.DTO
{
    class RoundDTO
    {
        private uint round_num;

        public uint Round_num
        {
            get
            {
                return round_num;
            }

            set
            {
                round_num = value;
            }
        }

        public RoundDTO() { }

        public RoundDTO(uint rdnum)
        {
            this.Round_num = rdnum;
        }

        public RoundDTO(DataRow row)
        {
            this.Round_num = uint.Parse(row["RoundNumber"].ToString());
        }
    }
}
