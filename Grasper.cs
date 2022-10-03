using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E7_20_v2._0
{
    class Grasper
    {
        public int _bufferSize;
        public Queue<byte[]> _data;
        public Queue<byte> _pack;
        public bool _RecivedStartByte;
        public SpeedMode _speedMode;

        public Grasper(int bufferSize, int measuresAmount, SpeedMode speedMode)
        {
            _bufferSize = bufferSize;
            _speedMode = speedMode;
            _data = new Queue<byte[]>(measuresAmount);
            _pack = new Queue<byte>(_bufferSize);
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
                if (_pack.Count == _bufferSize)
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
