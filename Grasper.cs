using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E7_20_v2._0
{
    class Grasper
    {
        private SerialPortHandler _port;
        private int _portSize;
        public Queue<byte[]> _data;
        public Queue<byte> _pack;
        public bool _RecivedStartByte;
        public SpeedMode _speedMode;

        public Grasper(SerialPortHandler port, int measuresAmount, SpeedMode speedMode)
        {
            _port = port;
            _portSize = _port.GetSize;
            _speedMode = speedMode;
            _data = new Queue<byte[]>(measuresAmount);
            _pack = new Queue<byte>(_portSize);
        }

        public void ReadByte(byte newByte)
        {
            if (_RecivedStartByte == false)
            {
                if (newByte == 0xAA)
                {
                    _pack.Clear();
                    _pack.Enqueue(newByte);
                    _RecivedStartByte = true;
                }
            }
            else
            {
                if (_pack.Count == _portSize)
                {
                    _data.Enqueue(_pack.ToArray());
                    _pack.Clear();
                }
                _pack.Enqueue(newByte);
            }
        }
        private void SendByte()
        {

        }
    }
}
