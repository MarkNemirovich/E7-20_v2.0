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
        private int _portSize;
        public Queue<byte[]> _data;
        public bool _RecivedStartByte;
        public SpeedMode _speedMode;

        public Grasper(SerialPortHandler port, int measuresAmount, SpeedMode speedMode)
        {
            _port = port;
            _portSize = _port.GetSize;
            _speedMode = speedMode;
            _data = new Queue<byte[]>(measuresAmount);
            _port.providePack += GetPack;
            _port.Start();
        }
        private void GetPack(byte[] newPack)
        {
            _data.Enqueue(newPack);
        }
        private void SendByte()
        {

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
    }
}
