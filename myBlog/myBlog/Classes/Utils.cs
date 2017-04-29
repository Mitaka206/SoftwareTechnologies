using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myBlog.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLen = 200)
        {
            if (text == null || text.Length <= maxLen)
            {
                return text;
            }
            else
            {
                var shortText = text.Substring(0, maxLen) + "...";

                return shortText;
            }
        }
    }
}