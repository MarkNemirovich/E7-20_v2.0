﻿using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace E7_20_v2._0
{
    internal class FileDirectory
    {
        private readonly string _directory;
        private readonly string _fileName;
        private CultureInfo ci = CultureInfo.InstalledUICulture;
        public FileDirectory(string directory, string fileName)
        {
            this._directory = directory;
            this._fileName = fileName;
        }

        private int SetFileNumber()
        {
            var list = Directory.GetFiles(_directory).Where(name => name.Contains($"{_fileName}_{SetDate()}")).ToArray();
            Array.Sort(list);
            int numberOfMeasurement = 0;
            for (int i = 0; i < list.Length; i++)
            {
                int start = list[i].IndexOf('№') + 1;
                int end = list[i].IndexOf(".xlsx");
                if (end - start <= 0)
                    continue;
                string number = list[i].Substring(start, end - start);
                Int32.TryParse(number, out int n);
                if (n == numberOfMeasurement)
                    numberOfMeasurement++;
                else
                    break;
            }
            return numberOfMeasurement;
        }
        private string SetDate()
        {
            string date = DateTime.Today.ToShortDateString();
            switch (ci.TwoLetterISOLanguageName)
            {
                case "ru-RU":
                    date = date.Replace(':', '_');
                    break;
                case "en-US":
                case "en-UK":
                    date = date.Replace('\\', '_');
                    break;
            }
            return date;
        }
        public string GetShortName => _fileName;
        public string GetFullName => $"{_directory}/{_fileName}_{SetDate()}_№{SetFileNumber()}.xlsx";
    }
}
