using System;
using System.Collections.Generic;

namespace E7_20_v2._0
{
    class RealGrasper : IOoperations
    {
        private Stack<byte[]> _data;
        private IOprovider _port;
        public RealGrasper(string portName)
        {
            _data= new Stack<byte[]>(Constants.BUFFER_LIMIT);
            _port = new IOprovider(portName);
            _port.ProvidePack += GetPack;
            _port.Start();
        }
        public bool NewMode(byte command)
        {
            _port.SendData(command);
            lock (_data)
            {
                _data.Clear();
            }
            return true;
        }
        public int GetFrequency()
        {
            byte[] lastData = null;
            int f = -1;
            lock (_data)
            {
                lastData = _data.Peek();
            }
            try
            {
                f = Convert.ToInt32(lastData[4]);
                f += Convert.ToInt32(lastData[5] << 8);
                f *= (int)Math.Pow(10.0, lastData[6]);
            }
            catch { }
            return f;
        }
        public bool ChangeFrequency(byte command)
        {
            int f = GetFrequency();
            if (f == Constants.MAIN_FREQUENCES[Constants.MAIN_FREQUENCES.Length - 1])
            {
                Break();
                return false;
            }
            _port.SendData(command);
            return true;
        }
        public bool GetLastData(out byte[] output)
        {
            output = null;
            lock (_data)
            {
                if (_data.Count > 0)
                {
                    output = _data.Pop();
                }
            }
            return output != null;
        }
        public void Break()
        {
            _port.ProvidePack -= GetPack;
            _port.Finish();
        }
        private void GetPack(byte[] newPack)
        {
            lock (_data)
            {
                if (_data.Count >= Constants.BUFFER_LIMIT)
                    _data.Clear();
                _data.Push(newPack);
            }
        }
    }
}
