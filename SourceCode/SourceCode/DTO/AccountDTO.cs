using SourceCode.DAO;
using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SourceCode.DTO
{
    class AccountDTO
    {
        private string username;
        private string password;
 
         public string Username
         {
             get
             {
                 return username;
             }
 
             set
             {
                 username = value;
             }
         }
 
         public string Password
         {
             get
             {
                 return password;
             }
 
             set
             {
                 password = value;
             }
         }
 
         public AccountDTO() { }
 
         public AccountDTO(string uname, string pw)
         {
             this.Username = uname;
             this.Password = pw;
         }
 
         public string HashLoginDTO(string pw)
         {
 
             byte[] temp = ASCIIEncoding.ASCII.GetBytes(pw);
             byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
 
             string hasPass = "";
 
             foreach (byte item in hasData)
             {
                 hasPass += item;
             }
             return hasPass;
         } 
    }
}
