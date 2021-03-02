using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace TestingAssignment2.Models
{
    public class StringOp
    {
        //1
        public static string UpperCase(string str)
        {
            str = str.ToUpper();
            Console.WriteLine($"Uppercase: {str}");
            return str;
        }

        //2
        public static string LowerCase(string str)
        {
            str = str.ToLower();
            Console.WriteLine($"Uppercase: {str}");
            return str;
        }

        //3
        public static string TitleCase(string str)
        {
            str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            return str;
        }

        //4
        public static string InLower(string str)
        {
            foreach (char input in str)
            {
                if (Char.IsLower(input))
                   return str;
            }
            return str; ;
        }
    
        //5
        public static string FirstUpper(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                str = char.ToUpper(str[0]) + str.Substring(1);
            }
            return str;           
        }

        //6
        public static bool HasNumeric(string str)
        {
            int i = 0;
            return int.TryParse(str, out i);
        }

        //7
        public static string InUpper(string str)
        {
            foreach (char input in str)
            {
                if (Char.IsUpper(input))
                    return str;
            }
            return str; ;
        }

        //8
        public static string RemoveLast(string str)
        {
            str = str.Remove(str.Length - 1);
            return str;
        } 

        //9
        public static string WordCount(string str)
        {
            str = str.Length.ToString();
            return str;
        }

        //10
        public static int ConvertToInt(string str)
        {
            int i = int.Parse(str);
            return i;
        }
    }
}