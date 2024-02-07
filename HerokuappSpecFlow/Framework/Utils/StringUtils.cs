using System.Text.RegularExpressions;

namespace HerokuappSpecFlow.Framework.Utils
{
    internal class StringUtils
    {
        private const string CurrencyRegex = "[^\\d.]";

        public static double GetDoubleFromString(string value)
        {
            // Replacing comma with dot before removing non-digit characters
            value = value.Replace(",", ".");
            return Convert.ToDouble(Regex.Replace(value, CurrencyRegex, ""));
        }
    }
}
