using System;
using System.Xml.Linq;

namespace E7_20_v2._0
{
    internal class VirtualDevice
    {
        private VirtualGrasper _dataGenerator;
        private int _dataAmount;
        public VirtualDevice(VirtualGrasper dataGenerator, int dataAmount)
        {
            _dataGenerator = dataGenerator;
            _dataAmount = dataAmount;
        }
        public bool GetData(out int f, out double[] main, out double[] sub)
        {
            f = GetF();
            main = new double[_dataAmount];
            sub = new double[_dataAmount];
            if (f == -1)
                return false;
            if (_dataGenerator.ReadBuffer(_dataAmount, out byte[][] output) == false)
                return false;
            Calculate(output, ref main, ref sub);
            return true;
        }
        private int GetF()
        {
            if (_dataGenerator.GetLastData(out byte[] data) == false)
                return -1;
            int newF = 0;
            try
            {
                newF = Convert.ToInt32(data[4]);
                newF += Convert.ToInt32(data[5] << 8);
                newF *= (int)Math.Pow(10.0, data[6]);
            }
            catch
            {
                newF = -1;
            }
            return newF;
        }
        private void Calculate(byte[][] input, ref double[] main, ref double[] sub)
        {
            for (int i = 0; i < _dataAmount; i++)    // считывает, что набралось в буффере
            {
                main[i] = CountData(input[i], 16);
                sub[i] = CountData(input[i], 12);
            }
        }
        private double CountData(byte[] input, int index)
        {
            double param = input[index];
            param += input[index + 1] << 8;
            if (input[index + 2] > 0x80)
            {
                param += (input[index + 2] - 0xFF - 1) << 16;
            }
            else
            {
                param += (input[index + 2] << 16);
            }
            if (input[index + 3] > 0x80)
            {
                param *= Math.Pow(10.0, input[index + 3] - 0xFF - 1);
            }
            else
            {
                param *= Math.Pow(10.0, input[index + 3]);
            }
            return param;
        }
    }
}
