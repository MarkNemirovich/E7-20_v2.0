using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace E7_20_v2._0
{
    class Grasper
    {
        private SerialPortHandler _port;
        public Queue<byte[]> _data;
        public SpeedMode _speedMode;
        protected Writer _writer;
        private int _measuresAmount;

        public Grasper(SerialPortHandler port, int measuresAmount, SpeedMode speedMode, string path)
        {
            _port = port;
            _measuresAmount = measuresAmount;
            _speedMode = speedMode;
            _data = new Queue<byte[]>(10);
            _port.Start();
            _writer = new Writer(path);

            _port.providePack += GetPack;
        }
        private void GetPack(byte[] newPack)
        {
            _data.Enqueue(newPack);
            if (_data.Count > 20)
                _data.Dequeue();
        }
        private void SendByte()
        {

        }
        protected int GetF()
        {
            if (_data.Count <= 0)
            {
                return -1;
            }
            var current = _data.Peek();
            if (current.Length != 22)
            {
                return -1;
            }
            int f = Convert.ToInt32(current[4]);
            f += Convert.ToInt32(current[5] << 8);
            f *= (int)Math.Pow(10.0, current[6]);
            return f;
        }
        public void WriteData()
        {
            var data = new List<double>();
            data.Add(GetF());
            _writer.Write(data);
        }
        protected double[] LayOutMeasurement(byte[] measurement)
        {
            double[] output = new double[2];
            output[0] = CountData(measurement, 16);
            output[1] = CountData(measurement, 12);
            return output;
        }
        private double CountData(byte[] currentData, int index)
        {
            double param = currentData[index];
            param += currentData[index + 1] << 8;
            if (currentData[index + 2] > 0x80)
            {
                param += (currentData[index + 2] - 0xFF - 1) << 16;
            }
            else
            {
                param += (currentData[index + 2] << 16);
            }
            if (currentData[index + 3] > 0x80)
            {
                param *= Math.Pow(10.0, currentData[index + 3] - 0xFF - 1);
            }
            else
            {
                param *= Math.Pow(10.0, currentData[index + 3]);
            }
            return param;
        }
        public void Finish()
        {
            _writer.Finish();
        }
    }
}
