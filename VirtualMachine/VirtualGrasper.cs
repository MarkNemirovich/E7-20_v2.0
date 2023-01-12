using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace E7_20_v2._0
{
    internal class VirtualGrasper : IOoperations
    {
        private Random _rand;
        private Stack<byte[]> _data;
        private Thread creatorThread;
        private bool isWork = false;

        public VirtualGrasper()
        {
            _rand = new Random();
            _data = new Stack<byte[]>(Constants.BUFFER_LIMIT);
            creatorThread = new Thread(CreateNewData);
            isWork = true;
            creatorThread.Start();
        }
        public bool GetLastData(out byte[] output)
        {
            output = null;
            bool finded = false;
            lock (_data)
            {
                if (_data.Count > 0)
                {
                    output = _data.Peek();
                    finded = true;
                }
            }
            return finded;
        }
        public bool NewMode(byte command)
        {
            ClearData();
            return true;
        }

        public bool ChangeFrequency(byte command)
        {
            ClearData();
            return true;
        }
        public void Break()
        {
            isWork = false;
        }
        private void CreateNewData()
        {
            while (isWork)
            {
                int len = _data.Count;
                if (len >= Constants.BUFFER_LIMIT)
                {
                    ClearData();
                    continue;
                }
                byte[] output = new byte[Constants.SIZE];
                output[0] = 0xAA;
                output[1] = 0;
                for (int i = 2; i < Constants.SIZE; i++)
                    output[i] = (byte)_rand.Next(0, 256);
                lock (_data)
                {
                    _data.Push(output);
                }                
                Thread.Sleep(Constants.DELAY);
            }
        }
        private void ClearData()
        {
            lock (_data)
            {
                _data.Clear();
            }
        }
    }
}
