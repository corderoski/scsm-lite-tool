using System;
using System.Text.RegularExpressions;

namespace SCSMTool.Framework
{
    public class StringUtil
    {

        public static String NewID()
        {
            return Guid.NewGuid().ToString("D").Replace(" ", "").Replace("-", "_").Replace("&", "and");
        }

        public static bool IsValidVersionString(string text)
        {
            var reg = new Regex(@"\d+(?:\.\d+)+");

            var match = reg.Match(text);
            return !match.Success;
        }

    }
}
