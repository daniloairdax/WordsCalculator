using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Helpers
{
    public static class TextHelper
    {
        public static int CountWordsFromText(string text)
        {
            int spaceCount = 0;
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            if (!String.IsNullOrWhiteSpace(text))
            {
                spaceCount = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            }          

            return spaceCount;
        }
    }
}
