using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson5
{
    class Account
    {
        private string login;
        private string password;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public Account(string login, string password)
        {
            this.login = login;
            this.password = password;

        }


        public bool Check()
        {
            bool flag = true;
            if (login.Length > 10 || login.Length < 2 || Char.IsDigit(login[0]))
            {
                return false;

            }
            else
            {
                foreach (char e in login)
                {
                    if (Char.IsLetterOrDigit(e)) continue;
                    else
                    {

                        flag = false;
                        break;
                    }
                }

            }


            return flag;
        }

        public bool CheckRegex()
        {
            Regex reg = new Regex(@"^[A-Za-z]{1}\w{1,9}",RegexOptions.ExplicitCapture);
            //return reg.Equals(login) ? true : false;
            return reg.IsMatch(login) ? true : false;
        }



    }
}
