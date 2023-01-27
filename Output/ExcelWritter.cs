using System;
using System.IO.Packaging;
using System.IO;
using GemBox.Spreadsheet;
using OfficeOpenXml;
using Org.BouncyCastle.Crypto.Digests;

namespace E7_20_v2._0
{
    internal class ExcelWritter
    {
        private readonly FileDirectory _fileDirectory;
        private readonly ExcelPackage _exelFile;
        private readonly OfficeOpenXml.ExcelWorksheet _exelSheet;
        private int _lineNumber;
        private int _lineWidth;
        static ExcelWritter()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }
        public ExcelWritter(string directory, string fileName)
        {
            _fileDirectory = new FileDirectory(directory, fileName);
            _exelFile = new ExcelPackage();
            _exelSheet = _exelFile.Workbook.Worksheets.Add($"{_fileDirectory.GetShortName}");

        }
        public void FillTheTitle(string[] data)
        {
            _lineNumber = 1;
            int column = 1;
            foreach (string cell in data)
            {
                _exelSheet.Cells[_lineNumber, column].Value = cell;
                column++;
            }
            _lineWidth = column - 1; // cause start from 1
            _lineNumber++;
        }
        public void AddLine(double[] data)
        {
            if (data.Length != _lineWidth)
                _exelSheet.Cells[_lineNumber, 1].Value = "Incorrect data";
            else
                for (int i = 0; i < data.Length; i++)
                {
                    _exelSheet.Cells[_lineNumber, i+1].Value = data[i];
                }
            _lineNumber++;
        }
        public void Save()
        {
            if (_lineNumber > 1)
            {
                using (Stream stream = File.Create(_fileDirectory.GetFullName))
                {
                    _exelFile.SaveAs(stream);
                    stream.Close();
                }
            }
        }
    }
}
