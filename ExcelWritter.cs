using System;
using System.IO;
using System.Linq;
using E7_20_v2._0;
using GemBox.Spreadsheet;

namespace DM6500Remote
{
    internal class ExcelWritter
    {
        private FileDirectory _fileDirectory;
        private ExcelFile _exelFile;
        private ExcelWorksheet _exelSheet;
        private int _lineNumber;
        private int _lineWidth = 0;
        private int _listNumber = 0;
        static ExcelWritter()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }
        public ExcelWritter(string directory, string fileName)
        {            
            _exelFile = new ExcelFile();
            _fileDirectory = new FileDirectory(directory, fileName);
        }
        public void CreateNewList(Modes interestedModes)
        {
            _exelSheet = _exelFile.Worksheets.Add($"{_fileDirectory.GetShortName}_№{_listNumber}");
            _lineNumber = 0;
            FillTheTitle(interestedModes);
        }
        private void FillTheTitle(Modes interestedModes)
        {
            int column = 0;
            _exelSheet.Cells[_lineNumber, column].Value = "f";
            foreach (var mode in interestedModes._modes)
            {
                if (mode.Value)
                {
                    column++;
                    _exelSheet.Cells[_lineNumber, column].Value = mode.Key;
                }
            }
            _lineWidth = column;
            _lineNumber++;
            _listNumber++;
        }
        public void AddLine(double[] data)
        {
            if (data.Length != _lineWidth+1) // +1 - it is f
                _exelSheet.Cells[_lineNumber, 0].Value = "No data here";
            else
                for (int i = 0; i <= data.Length; i++)
                {
                    _exelSheet.Cells[_lineNumber, i].Value = data[i];
                }
            _lineNumber++;
        }
        ~ExcelWritter()
        {
            _exelFile.Save(_fileDirectory.GetFullName);
        }
    }
}
