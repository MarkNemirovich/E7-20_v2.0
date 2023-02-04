using System;
using System.IO;
using System.Linq;

namespace E7_20_v2._0
{
    internal class FileDirectory
    {
        private readonly string directory;
        private readonly string fileName;
        public FileDirectory(string directory, string fileName)
        {
            this.directory = directory;
            this.fileName = fileName;
        }
        private int SetFileNumber()
        {
            var files = Directory.GetFiles(directory);
            var appropriateFiles = from file in files
                        where file.Contains($"{fileName}_{SetDate()}")
                          let startIndex = file.IndexOf('№') + 1
                          let finishIndex = file.IndexOf(".xlsx")
                          select file.Substring(startIndex, (finishIndex-startIndex));
            int[] numbers = new int[Directory.GetFiles(directory).Length];
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
        public string GetShortName => fileName;
        public string GetFullName => $"{directory}/{fileName}_{SetDate()}_№{SetFileNumber()}.xlsx";
    }
}
