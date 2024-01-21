using System.ComponentModel.DataAnnotations;

namespace ArkoMebel.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class EmailAttributes : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return false;
            string email = value.ToString();
            if (System.Text.RegularExpressions.Regex.IsMatch(email, @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$"))
            {
                return true;
            }
            return false;
        }
    }
}
