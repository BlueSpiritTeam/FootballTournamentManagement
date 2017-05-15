using System;
using System.Collections.Generic;
using System.Linq;
using SourceCode.DTO;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }
          public bool Login(AccountDTO login)
        {

            string hashPass = login.HashPassAccountDTO(login.Password);
            
            string query = "select * from dbo.Login where username = @username and password = '"+hashPass+"' ";
            
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[]{login.Username});

            return result.Rows.Count > 0;
        }
    }
}
