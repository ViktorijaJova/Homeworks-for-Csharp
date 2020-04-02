using System;
using System.Collections.Generic;
using System.Text;

namespace Sedc.Class06.Excersises.Buissnis.Services
{
    public class ValidationService
    {

       public bool ValidateEmail(string email)
        {
            if (!email.Contains("@"))
            {
                return false;
            }

            string[] emailParts = email.Split('@');
            if(emailParts.Length != 2)
            {
                return false;
            }

            if(emailParts[emailParts.Length-1].Length <= 6 && !emailParts[emailParts.Length-1].Contains('.'))
            {
                return false;
            }

            return true;
        }

        public bool ValidatePassword(string password)
        {
            if(password.Length < 8)
            {
                return false;
            }

            char[] passwordParts = password.ToCharArray();
            int countUpperLetters = 0;
            int countDigits = 0;
            foreach(char part in passwordParts)
            {
                if (char.IsWhiteSpace(part))
                {
                    return false;
                }

                if (char.IsUpper(part))
                {
                    countUpperLetters++;
                }
                if (char.IsDigit(part))
                {
                    countDigits++;
                }
            }
            return countUpperLetters !=0 && countDigits !=0;

        }




    }
}
