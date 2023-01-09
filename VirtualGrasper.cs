using System;
using System.Collections.Generic;
using System.Threading;

namespace E7_20_v2._0
{
    internal class VirtualGrasper : IOperations
    {
        private Random _rand;
        private List<byte[]> _data;
        private int _amount;
        private Thread creatorThread;
        public bool ChangeFrequency(SpeedMode newMode) => true;
        public bool ChangeMode(Modes newMode) => true;

        public VirtualGrasper(int amount, int delay)
        {
            _rand = new Random();
            _data = new List<byte[]>(100);
            _amount = amount;
            creatorThread = new Thread(CreateNewData);
            creatorThread.Start((object)delay);
        }
        public bool GetLastData(out byte[] output)
        {
            int index = -1;
            bool finded = false;
            output = null;
            lock (_data)
            {
                index = _data.FindLastIndex(data => data.Length == 0); // Default byte[] has length 0
                if (index > 0)
                {
                    output = _data[index];
                    _data[index] = null;
                    finded = true;
                }
            }
            return finded;
        }
        public bool ReadBuffer(int length, out byte[][] output)
        {
            byte[][] buffer = new byte[_amount][]; 
            for(int i = 0; i < _amount; i++)
            {
                if (GetLastData(out buffer[i]) == false)
                {
                    output = null;
                    return false;
                }
            }
            output = buffer;
            return true;
        }
        private void CreateNewData(object delay)
        {
            byte[] output = new byte[Constants.SIZE];
            output[0] = 0xAA;
            output[1] = 0;
            for (int i = 2; i < Constants.SIZE; i++)
                output[i] = (byte)_rand.Next(0, 256);
            lock(_data)
            {
                _data.Add(output);
                if (_data.Count >= 100)
                    Shift();
            }
            Thread.Sleep(Convert.ToInt32(delay));
        }
        private void Shift()
        {
            for (int i = 0; i < 100 - _amount; i++)
                _data[i] = _data[i + _amount];
            for (int i = 100 - _amount; i < 100; i++)
                _data[i] = null;
        }
    }
}
