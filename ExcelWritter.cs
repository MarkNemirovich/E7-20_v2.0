using System;
using System.IO;
using System.Linq;
using GemBox.Spreadsheet;

namespace DM6500Remote
{
    internal class ExcelWritter
    {
        private readonly string _date = DateTime.Today.ToShortDateString().Replace(':', '_');
        private readonly string _directory;
        private readonly string _fileName;
        private int _numberOfMeasurement;
        private int _line;
        private ExcelFile _exelFile;
        private ExcelWorksheet _exelSheet;
        private string[] _title;
        private int _listNumber = 0;
        static ExcelWritter()
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }
        public ExcelWritter(string directory, string fileName)
        {
            _directory = directory;
            _fileName = fileName;
            _exelFile = new ExcelFile();

            var list = Directory.GetFiles(_directory);
            Array.Sort(list);
            foreach (string file in list)
            {
                if (file.Contains($"{_fileName}_{_date}_№{_numberOfMeasurement}") == true)
                {
                    int start = file.IndexOf('№')+1;
                    int end = file.IndexOf(".xlsx");
                    string number = file.Substring(start, end - start);
                    _numberOfMeasurement++;
                }
            }
        }
        public void CreateNewList()
        {
            _line = 0;
            _exelSheet = _exelFile.Worksheets.Add($"{_fileName}_№{_listNumber}");
            _exelSheet.Cells[_line, 0].Value = "Time";
            _exelSheet.Cells[_line, 1].Value = "Current";
            _exelSheet.Cells[_line, 2].Value = "Voltage";
            _line++;
            _listNumber++;
        }
        public void AddLine(double[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                _exelSheet.Cells[_line, i].Value = data[i];
            }
            _line++;
        }
        public void SaveFile()
        {

            _exelFile.Save($"{_directory}/{_fileName}_{_date}_№{_numberOfMeasurement}.xlsx");
        }
    }
}
