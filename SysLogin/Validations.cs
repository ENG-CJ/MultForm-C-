using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogin
{
    internal class  Validations
    {
        public static bool IsValidUser(string username,string ExistingUser, string password, string ExistingPasscode)
        {
            return username == ExistingUser && password == ExistingPasscode;
        }
        public static bool IsBlank(string username, string password)
        {
            return username == "" || password == "";   
        }

        public static bool IsBlank(string username, string Email,string Password,string confirmPassowrd)
        {
            return username == "" || Email == "" || Password=="" || confirmPassowrd=="";
        }

        public static bool IsConfirmed(string CurrentPassword, string PrevPassword)
        {
            return !CurrentPassword.Equals(PrevPassword); 
        }

       // valid email
        public static bool IsValidEmail(string email)
        {
            return email.StartsWith("@gmail.com") || !email.EndsWith("@gmail.com");
        }
        public static bool  MaxLength(string password)
        {
            return password.Length!=7;
        }
        
        
    }
}
