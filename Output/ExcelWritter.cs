using System;
using System.IO;
using OfficeOpenXml;

namespace E7_20_v2._0
{
    internal class ExcelWritter : IDisposable
    {
        private readonly FileDirectory fileDirectory;
        private readonly ExcelPackage exelFile;
        private readonly ExcelWorksheet exelSheet;
        private bool isDisposed;
        private int lineNumber;
        private int lineWidth;
        private bool isSaved;
        public ExcelWritter(string directory, string fileName)
        {
            fileDirectory = new FileDirectory(directory, fileName);
            exelFile = new ExcelPackage();
            exelSheet = exelFile.Workbook.Worksheets.Add($"{fileDirectory.GetShortName}");

        }
        public void FillTheTitle(string[] data)
        {
            lineNumber = 1;
            int column = 1;
            foreach (string cell in data)
            {
                exelSheet.Cells[lineNumber, column].Value = cell;
                column++;
            }
            lineWidth = column - 1; // cause start from 1
            lineNumber++;
        }
        public void AddLine(double[] data)
        {
            if (data.Length != lineWidth)
                exelSheet.Cells[lineNumber, 1].Value = "Incorrect data";
            else
                for (int i = 0; i < data.Length; i++)
                {
                    exelSheet.Cells[lineNumber, i+1].Value = data[i];
                }
            lineNumber++;
        }
        public void Save()
        {
            using (Stream stream = File.Create(fileDirectory.GetFullName))
            {
                if (exelFile != null)
                {
                    exelFile.SaveAs(stream);
                    exelFile.Dispose();
                    isSaved = true;
                }
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;
            if (disposing)
            {
                Save();
            }
            isDisposed = true;
        }
        ~ExcelWritter() => Dispose(false);
    }
}
