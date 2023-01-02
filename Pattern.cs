﻿using System;
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
        public static string phone_number = "[1-9]{2}[' ']?[1-9]{1}[0-9]{9}";
        public static string password = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";

        public bool validateUserName(string UserName)
        {
            return Regex.IsMatch(UserName, User_Name);
        }

        public bool validatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, phone_number);
        }
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, password);
        }
        
    }
}
