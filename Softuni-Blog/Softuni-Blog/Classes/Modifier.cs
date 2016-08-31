using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softuni_Blog.Classes
{
    public class Modifier
    {
        public static string ReduceText(string text, int maxLength = 300)
        {
            if (text == null || text.Length <= maxLength)
            {
                return text;
            }
            var shortText = text.Substring(0, maxLength) + "...";
            return shortText;
        }
    }
}