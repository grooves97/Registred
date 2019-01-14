using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration
{
    public class Sign_Up
    {
        private string _userLogin;
        private string _userName;
        private string _userSurname;
        private string _userPassword;
        private string _userPasswordConfirm;
        private string _userEmail;
        private string _userPhone;
        private string _userVerifyCode;

        public string GetUserLogin()
        {
            return _userLogin;
        }
        public void SetUserLogin(string userLogin)
        {
            _userLogin = userLogin;
        }
        public string GetUserName()
        {
            return _userName;
        }
        public void SetUserName(string userName)
        {
            _userName = userName;
        }
        public string GetUserSurname()
        {
            return _userSurname;
        }
        public void SetUserSurnames(string userSurname)
        {
            _userSurname = userSurname;
        }
        public string GetUserPassword()
        {
            return _userPassword;
        }
        public void SetUserPassword(string userPassword)
        {
            _userPassword = userPassword;
        }
        public string GetPasswordConfirm()
        {
            return _userPasswordConfirm;
        }
        public void SetPasswordConfirm(string userPasswordConfirm)
        {
            _userPasswordConfirm = userPasswordConfirm;
        }
        public string GetUserEmail()
        {
            return _userEmail;
        }
        public void SetUserEmail(string userEmail)
        {
            _userEmail = userEmail;
        }
        public string GetUserPhone()
        {
            return _userPhone;
        }
        public void SetUserPhone(string userPhone)
        {
            _userPhone = userPhone;
        }
        public string GetUserVerifyCode()
        {
            return _userLogin;
        }
        public void SetUserVerifyCode(string userVerifyCode)
        {
            _userVerifyCode = userVerifyCode;
        }

        public void UserLogin()
        {
            Console.WriteLine("Enter your name");
            _userName = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            _userSurname = Console.ReadLine();
            Console.WriteLine("Enter your login");
            _userLogin = Console.ReadLine();
        }

        public void Password()
        {
           
            Console.WriteLine("Enter your password");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    _userPassword += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _userPassword.Length > 0)
                    {
                        _userPassword = _userPassword.Substring(0, (_userPassword.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);


            Console.WriteLine("Confirm your password");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    _userPasswordConfirm += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _userPassword.Length > 0)
                    {
                        _userPassword = _userPassword.Substring(0, (_userPassword.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            } while (true);

        }


        public void ComparePass()
        {
            while (true)
            {
                if (_userPassword.Equals(_userPasswordConfirm))
                {
                    Console.WriteLine("Password was succesfully confirm");
                    break;
                }
                else
                {
                    Console.WriteLine("Password did not match");
                    Console.WriteLine("Please try again to enter password");
                    Password();
                }
            }
        }


        public void EmailAndPhone()
        {
            Console.WriteLine("Enter your email");
            _userEmail = Console.ReadLine();
            while (true)
            {
                if (!_userEmail.Contains('@') || !_userEmail.Contains('.'))
                {
                    Console.WriteLine("Email entered incorrectly");
                    Console.WriteLine("Please try again");
                    _userEmail = Console.ReadLine();
                }
                break;
            }
            Console.Clear();

            Console.WriteLine("Enter your phone number");
            _userPhone = Console.ReadLine();

            Console.ReadLine();
        }


        public void CodeVerify(string codeNumber)
        {
            Console.WriteLine("Enter verify code");
            _userVerifyCode = Console.ReadLine();
            while (true)
            {
                if (_userVerifyCode == codeNumber)
                {
                    Console.WriteLine("Congratulations you have successfully registered");
                    break;
                }
                else
                {
                    Console.WriteLine("Code did not match, please try again");
                    _userVerifyCode = Console.ReadLine();
                }
            }

          
        }
    }
}






