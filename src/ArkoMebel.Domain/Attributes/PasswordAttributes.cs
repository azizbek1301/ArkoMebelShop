﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ArkoMebel.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]

    public class PasswordAttributes : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            string password = value.ToString();

            if (Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z\d\s]).{7,}$"))
            {
                return true;
            }

            return false;
        }
    }
}
