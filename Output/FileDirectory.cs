using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace E7_20_v2._0
{
    internal class FileDirectory
    {
        private readonly string _directory;
        private readonly string _fileName;
        public FileDirectory(string directory, string fileName)
        {
            _directory = directory;
            _fileName = fileName;
        }
        private int SetFileNumber()
        {
            var files = Directory.GetFiles(_directory);
            var appropriateFiles = from file in files
                        where file.Contains($"{_fileName}_{SetDate()}")
                          let startIndex = file.IndexOf('№') + 1
                          let finishIndex = file.IndexOf(".xlsx")
                          select file.Substring(startIndex, (finishIndex-startIndex));
            int[] numbers = new int[Directory.GetFiles(_directory).Length];
            int count = 0;
            foreach(string file in appropriateFiles)
            {
                if (Int32.TryParse(file, out numbers[count]))
                    count++;
            }
            Array.Sort(numbers);
            int zeros = Array.LastIndexOf(numbers, (int)0);
            int numberOfMeasurement = 0;
            for (int i = zeros; i < count+zeros; i++)
            {
                if (numberOfMeasurement == numbers[i])
                    numberOfMeasurement++;
                else
                    break;
            }
            return numberOfMeasurement;
        }
        private string SetDate()
        {
            string date = DateTime.Today.ToShortDateString();
            return StyleFormatter.ChangeDataSeparator(date);
        }
        public string GetShortName => _fileName;
        public string GetFullName => $"{_directory}/{_fileName}_{SetDate()}_№{SetFileNumber()}.xlsx";
    }
}
