using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.Helper
{
    public class CreateSchedule
    {
        private static CreateSchedule instance;

        public static CreateSchedule Instance
        {
            get
            {
                return instance;
            }

            set
            {
                instance = value;
            }
        }

        public CreateSchedule()
        {

        }

        public List<MatchDTO> Create()
        {
            List<MatchDTO> list = new List<MatchDTO>();


            return list;
        }

    }
}
