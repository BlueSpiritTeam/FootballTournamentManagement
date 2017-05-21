using SourceCode.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            string hashPass = login.HashLoginDTO(login.Password);



            string query = "select * from dbo.Account where username = @username and pass = '" + hashPass + "' ";
            //sua cho nay
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { login.Username });

            return result.Rows.Count > 0;
        }
    }
}
