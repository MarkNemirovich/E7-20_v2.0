using System;
using System.IO;
using System.Linq;
using System.Text;

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
            StringBuilder sb = new StringBuilder();
            sb.Append(fileName);
            sb.Append("_");
            sb.Append(SetDate());
            string fileNameWithDate = sb.ToString();
            var appropriateFiles = from file in files
                                   where file.Contains($"{fileNameWithDate}")
                                   let startIndex = file.IndexOf('№') + 1
                                   let finishIndex = file.IndexOf(".xlsx")
                                   select file.Substring(startIndex, (finishIndex - startIndex));
            int count = 0;
            int[] numbers = new int[files.Length];
            foreach (var file in appropriateFiles)
            {
                if (Int32.TryParse(file, out numbers[count]))
                    count++;
            }
            Array.Sort(numbers);
            int zeros = Array.LastIndexOf(numbers, 0);
            int numberOfMeasurement = 0;
            for (int i = zeros; i < count + zeros; i++)
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
        public string GetFullName
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(directory);
                sb.Append(Path.DirectorySeparatorChar);
                sb.Append(fileName);
                sb.Append("_"); ;
                sb.Append(SetDate());
                sb.Append("_№"); ;
                sb.Append(SetFileNumber());
                sb.Append(".xlsx");
                return sb.ToString();
            }
        }
    }
}
