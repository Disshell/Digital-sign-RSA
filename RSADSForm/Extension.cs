using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryRSA
{
    public static class Extension
    {
        public static Int64[] ToInt64(this char[] charText)
        {
            Int64 [] result = new Int64 [charText.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = charText[i];
            }
            return result;
        }

        public static string IntToString(this Int64[] intText)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < intText.Length; i++)
            {
                result.Append((char)intText[i]);
            }
            return result.ToString();
        }
    }
}
