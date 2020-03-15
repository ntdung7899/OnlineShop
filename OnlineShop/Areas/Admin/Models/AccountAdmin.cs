using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class AccountAdmin
    {
        public AccountAdmin()
        {

        }
        string strUser = "admin";
        string passA = "nimda";
        public bool login(string userName, string password)
        {
            if (userName == "" || password == "")
            {
                return false;
            }
            if (userName.Equals(strUser) && password.Equals(passA))
            {               
                return true;
            }
            return false;
        }
    }
}