using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationLibraryDemo
{
    public class LoginUser
    {

        private string _userName;
        public string UserName
        {
            set { _userName = value; }
            get { return _userName; }   
        }

        private string _password;
        public string Password {
            set //
            {
                _password = value; 
            }
            private get { return _password; }

        }

        private bool _changePwd;

        public bool ChangePassword
        {
            get { return _changePwd; }
            set { 
                _changePwd = value;
                if (_changePwd==true) {
                    Console.WriteLine("Enter Your old password");
                    string old = Console.ReadLine();
                    if (Password==old)
                    {
                        Console.WriteLine("Now enter your new password");
                        Password = Console.ReadLine();
                        Console.WriteLine("Password changed successfully....");
                    }

                }

            }
        }

    }
}
