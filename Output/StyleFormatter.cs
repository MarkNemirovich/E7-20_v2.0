using System;
using System.Globalization;

namespace E7_20_v2._0
{
    internal static class StyleFormatter
    {
        private static readonly CultureInfo regionStyle = CultureInfo.InstalledUICulture;
        public static string ChangeDoubleSeparator(string input)
        {
            switch (regionStyle.TwoLetterISOLanguageName)
            {
                case "en-US":
                case "en-UK":
                    return input.Replace(',', '.');
                case "ru-RU":
                default:
                    return input.Replace('.', ',');
            }
        }
        public static string ChangeDataSeparator(string input)
        {
            switch (regionStyle.TwoLetterISOLanguageName)
            {
                case "en-US":
                case "en-UK":
                    return input.Replace('\\', '_');
                case "ru-RU":
                default:
                    return input.Replace(':', '_');
            }
        }
    }
}