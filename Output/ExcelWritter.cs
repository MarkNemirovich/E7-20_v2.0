using System;
using System.IO;
using OfficeOpenXml;

namespace E7_20_v2._0
{
    internal class ExcelWriter : IDisposable
    {
        private readonly FileDirectory fileDirectory;
        private readonly ExcelPackage exelFile;
        private readonly ExcelWorksheet exelSheet;
        private bool isDisposed;
        private int lineNumber;
        private int lineWidth;
        public ExcelWriter(string directory, string fileName)
        {
            fileDirectory = new FileDirectory(directory, fileName);
            exelFile = new ExcelPackage();
            exelSheet = exelFile.Workbook.Worksheets.Add($"{fileDirectory.GetShortName}");
            lineNumber = 1;
        }
        public void FillTheTitle(string[] data)
        {
            int column = 1;
            foreach (string cell in data)
            {
                exelSheet.Cells[lineNumber, column].Value = cell;
                column++;
            }
            lineWidth = column - 1; // cause start from 1 in Excel
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
            string filePath = fileDirectory.GetFullName;
            using (Stream stream = File.Create(filePath))
            {
                if (exelFile != null)
                {
                    if (lineNumber > 2)
                    {
                        exelFile.SaveAs(stream);
                        exelFile.Dispose();
                        stream.Close();
                        return;
                    }
                }
            }
            File.Delete(filePath);
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
        ~ExcelWriter() => Dispose(false);
    }
}