﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public class CoachDTO : HumanDTO
    {
        private string coach_id;
        public string Coach_id
        {
            get
            {
                return coach_id;
            }

            set
            {
                coach_id = value;
            }
        }


        //construtor
        public CoachDTO()
        {
            
        }

        public CoachDTO(string cid)
        {
            this.Coach_id = cid;
        }


        public CoachDTO(DataRow row)
        { 
            this.Coach_id = (string)row["CoachID"].ToString();
        }
        
    }
}
