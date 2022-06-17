using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace App.Common
{
    public static class StringExtensions
    {

        /// <summary>
        /// Checks to be sure a phone number contains 10 digits as per American phone numbers.  
        /// If 'IsRequired' is true, then an empty string will return False. 
        /// If 'IsRequired' is false, then an empty string will return True.
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="IsRequired"></param>
        /// <returns></returns>
        public static bool ValidatePhoneNumber(this string phone, bool IsRequired)
        {
            if (string.IsNullOrEmpty(phone) & !IsRequired)
                return true;

            if (string.IsNullOrEmpty(phone) & IsRequired)
                return false;

            var cleaned = phone.RemoveNonNumeric();
            if (IsRequired)
            {
                if (cleaned.Length == 10)
                    return true;
                else
                    return false;
            }
            else
            {
                if (cleaned.Length == 0)
                    return true;
                else if (cleaned.Length > 0 & cleaned.Length < 10)
                    return false;
                else if (cleaned.Length == 10)
                    return true;
                else
                    return false; // should never get here
            }
        }

        /// <summary>
        /// Removes all non numeric characters from a string
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public static string RemoveNonNumeric(this string phone)
        {
            return Regex.Replace(phone, @"[^0-9]+", "");
        }

        public static bool IsValidEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string FormatNumber(long num)
        {
            if (num >= 100000000)
            {
                return (num / 1000000D).ToString("0.#M");
            }
            if (num >= 1000000)
            {
                return (num / 1000000D).ToString("0.##M");
            }
            if (num >= 100000)
            {
                return (num / 1000D).ToString("0.#k");
            }
            if (num >= 10000)
            {
                return (num / 1000D).ToString("0.##k");
            }

            return num.ToString("#,0");
        }

        public static decimal ConvertWordToNumber(string numStr)
        {
            if (numStr.Trim().EndsWith("M"))
            {
                return Math.Round((Convert.ToDecimal(numStr.TrimEnd('M')) * 1000000), 0);
            }
            else if (numStr.Trim().EndsWith("K"))
            {
                return Math.Round((Convert.ToDecimal(numStr.TrimEnd('K')) * 1000), 0);
            }
            else return decimal.Parse(numStr);
        }

        public static string[] Convert_A_Comma_Delimited_String_To_Array(string text)
        {
            string[] splittedArray = text.Split(',');

            return splittedArray;
        }

    }
}
