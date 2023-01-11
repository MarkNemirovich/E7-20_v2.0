using System;
using System.Linq;
using System.Threading;

namespace E7_20_v2._0
{
    internal class VirtualGrasper : IOoperations
    {
        private Random _rand;
        private byte[][] _data;
        private int _measuresAmount;
        private Thread creatorThread;
        public bool ChangeFrequency() => true;

        public VirtualGrasper(int amount, int delay = 10)
        {
            _rand = new Random();
            _data = new byte[0][];
            _measuresAmount = amount;
            creatorThread = new Thread(CreateNewData);
            creatorThread.Start((object)delay);
        }
        public bool GetLastData(out byte[] output)
        {
            int index = -1;
            bool finded = false;
            output = null;
            byte[][] snapshot;
            lock (_data)
            {
                snapshot = _data;
            }
            index = snapshot.Length-1;
            if (index > 0)
            {
                output = snapshot[index];
                byte[][] temp = new byte[index][];
                for (int i = 0; i < index; i++)
                    temp[i] = snapshot[i];
                snapshot = temp;
                finded = true;
            }
            lock (_data)
            {
                 _data = snapshot;
            }
            return finded;
        }
        public bool NewMode(byte command)
        {
            _data = new byte[0][];
            return true;
        }
        public bool ReadBuffer(int length, out byte[][] output)
        {
            byte[][] buffer = new byte[_measuresAmount][]; 
            for(int i = 0; i < _measuresAmount; i++)
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
            while (true)
            {
                byte[] output = new byte[Constants.SIZE];
                output[0] = 0xAA;
                output[1] = 0;
                for (int i = 2; i < Constants.SIZE; i++)
                    output[i] = (byte)_rand.Next(0, 256);
                var temp = new byte[_data.Length + 1][];
                int len = _data.Length;
                lock (_data)
                {
                    for (int i = 0; i < len; i++)
                        temp[i] = _data[i];
                    temp[len] = output;
                    _data = temp;
                }
                if (len >= Constants.BUFFER_LIMIT)
                    Shift();
                Thread.Sleep(Convert.ToInt32(delay));
            }
        }
        private void Shift()
        {
            byte[][] temp = new byte[Constants.BUFFER_LIMIT - _measuresAmount][];
            lock (_data)
            {
                for (int i = 0; i < Constants.BUFFER_LIMIT - _measuresAmount; i++)
                    temp[i] = _data[i + _measuresAmount];
                _data = temp;
            }
        }
    }
}
