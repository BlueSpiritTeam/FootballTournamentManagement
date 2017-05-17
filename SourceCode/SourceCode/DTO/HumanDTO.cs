﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    public /*abstract*/ class HumanDTO
    {
        protected string human_id;
        protected string gender_id;
        private string human_clubid;
        protected string name;
        protected DateTime birthday;
        protected string nation;
        protected string path_img;

        #region properties
        public string Gender_id
        {
            get
            {
                return gender_id;
            }

            set
            {
                gender_id = value;
            }
        }

        

        public string Name
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

        public DateTime Birthday
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

        public string Nation
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
        public string Path_img
        {
            get
            {
                return path_img;
            }

            set
            {
                path_img = value;
            }
        }

        public string Human_id
        {
            get
            {
                return human_id;
            }

            set
            {
                human_id = value;
            }
        }

        protected string Human_clubid
        {
            get
            {
                return human_clubid;
            }

            set
            {
                human_clubid = value;
            }
        }
        #endregion

        public HumanDTO() { }

        public HumanDTO(string hid, string gid, string cid, string n, DateTime bd, string nt, string p)
        {
            this.Human_id = hid;
            this.Gender_id = gid;
            this.Human_clubid = cid;
            this.Name = n;
            this.Birthday = bd;
            this.Nation = nt;
            this.Path_img = p;
        }

        public HumanDTO(DataRow row)
        {
            this.Human_id = (string)row["CoachID"].ToString();
            this.Gender_id = (string)row["GenderName"].ToString();
            this.Human_clubid = (string)row["Human_ClubID"].ToString();
            this.Name = (string)row["Name"].ToString();
            this.Birthday = DateTime.Parse(row["Birthday"].ToString());
            this.Nation = (string)row["Nation"].ToString();
            this.Path_img = (string)row["Path"].ToString();
        }
    }
}
