using Economy.Domain.Entities.API_Object;
using System;

namespace Economy.AppCore.Helper
{
    public static class Validations
    {
        public static void ValidateEmptyFields(string username, string password, string email, string number)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(number))
            {
                throw new ArgumentException("You must fill all the fields");
            }
        }
        public static void ValidateEmptyFields(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("You must fill all the fields");
            }
        }
        public static int VerificationNumberAndEmail(Number number, Email email)
        {
            if (number.valid == true && email.syntax_valid == true)
            {
                return 1;
            }
            return 0;
        }
    }
}
