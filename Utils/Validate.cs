using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace turtle.Utils
{
    class Validate
    {
        public static Boolean isString(String value)
        {
            Regex pattern = new Regex(@"[a-zA-Z]+");
            if (pattern.IsMatch(value))
            {
                return true;
            }
            return false;
        }

        public static Boolean isNumeric(String value)
        {
            Regex pattern = new Regex(@"[0-9]+");
             if (pattern.IsMatch(value))
             {
                 return true;
             }
            return false;
        }

        public static Boolean isVarChar(String value)
        {

            Regex pattern = new Regex(@"[a-zA-Z0-9]+");
             if (pattern.IsMatch(value))
             {
                 return true;
             }
            return false;
        }

        public static Boolean isEmailAddress(String value)
        {
            Regex pattern = new Regex(@"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,3})$");
            if (pattern.IsMatch(value))
            {
                return true;
            }
            return false;
        }

        public static Boolean isFloat(String value)
        {
            Regex pattern = new Regex(@"[0-9]+.[0-9]+");
            if (pattern.IsMatch(value))
            {
                return true;
            }
            return false;
        }

       
    }
}
