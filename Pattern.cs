using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    internal class Pattern
    {
        
        public static string User_Name = "^[A-Z]{1}[a-z]{2,9}$";

        public bool validateUserName(string UserName)
        {
            return Regex.IsMatch(UserName, User_Name);
        }
        
    }
}
