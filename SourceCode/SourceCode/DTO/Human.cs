using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    abstract class Human
    {
        protected string gender;
        protected string club_id;
        protected string name;
        protected DateTime birthday;
        protected string nation;

        protected string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        protected string Club_id
        {
            get
            {
                return club_id;
            }

            set
            {
                club_id = value;
            }
        }

        protected string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        protected DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        protected string Nation
        {
            get
            {
                return nation;
            }

            set
            {
                nation = value;
            }
        }        
     
    }
}
