using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace turtle.Utils
{
    class CounterEmails
    {

        public static String countEmails(String value)
        {   
            int count=0;
            for (int i=0;i<value.Length;i++) 
            {
                if (value.Substring(i,1).Equals("@"))
                    count++; 
            }
            return Convert.ToString(count);
        }
    }
}
