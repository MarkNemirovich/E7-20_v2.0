using System;
using GemBox.Spreadsheet;

namespace E7_20_v2._0
{
    internal class ExcelWritter
    {
        private FileDirectory _fileDirectory;
        private ExcelFile _exelFile;
        private ExcelWorksheet _exelSheet;
        private int _lineNumber;
        private int _lineWidth;
        static ExcelWritter()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }
        public ExcelWritter(string directory, string fileName)
        {            
            _exelFile = new ExcelFile();
            _fileDirectory = new FileDirectory(directory, fileName);
            _exelSheet = _exelFile.Worksheets.Add($"{_fileDirectory.GetShortName}");
        }
        public void FillTheTitle(Modes interestedModes)
        {
            _lineNumber = 0;
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
        }
        public void AddLine(double[] data)
        {
            if (data.Length != _lineWidth+1) // +1 - it is f
                _exelSheet.Cells[_lineNumber, 0].Value = "Incorrect data";
            else
                for (int i = 0; i < data.Length; i++)
                {
                    _exelSheet.Cells[_lineNumber, i].Value = data[i];
                }
            _lineNumber++;
        }
        public void Save()
        {
            _exelFile.Save(_fileDirectory.GetFullName);
        }
    }
}
