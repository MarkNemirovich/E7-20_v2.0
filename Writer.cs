using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace E7_20_v2._0
{
    class Writer
    {
        private StreamWriter _writer;
        private bool isInitialized = false;

        public Writer(string path, string fileName)
        {
            try
            {
                string fullPath = $"{path}\\{fileName}.txt";
                var file = File.Open(fullPath, FileMode.OpenOrCreate);
                file.Position = 0;
                file.Close();
                _writer = new StreamWriter(fullPath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Init()
        {
            if (isInitialized == false)
            {
                _writer.WriteLine();
                isInitialized = true;
            }
        }

        public void Write(List<double> data)
        {
            string output = "";
            foreach (double information in data)
                output += data.ToString();
            //if (_sigma)
            //{
            //    output = $"{_f,-10}{_data[0, 0],15:f5}{_data[0, 1],15:f5}{_data[0, 2],15:f5}{_data[0, 3],15:f5}" +
            //        $"{_data[1, 0],15:f5}{_data[1, 1],15:f5}{_data[1, 2],15:f5}{_data[1, 3],15:f5}";
            //}
            //else
            //{
            //    output = $"{_f,-10}{_data[0, 0],15}{_data[1, 0],15}";
            //}
            output = output.Replace('.', ',');  // для переноса в эксель табы и запятые
            _writer.WriteLine(output); // в конечный файл числа
        }
        public void Write(string line)
        {
            _writer.WriteLine(line);
        }

            public void Finish()
        {
            isInitialized = false;
            _writer.Close();
        }

    }
}
