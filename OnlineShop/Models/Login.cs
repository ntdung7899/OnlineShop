using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Login
    {
        public class UserLogin
        {
            private string strName = "";
            private string strPass = "";
            public UserLogin()
            {

            }
            public UserLogin(string strN, string P)
            {
                UserName = strN;
                PassWord = P;
            }
            public string UserName
            {
                get { return strName; }
                set
                {
                    if (value.Length != 0)
                        strName = value;
                    else
                        return;
                }
            }
            public string PassWord
            {
                get { return strPass; }
                set
                {
                    if (value.Length != 0)
                        strPass = value;
                    else
                        return;
                }
            }
        }
    }
}