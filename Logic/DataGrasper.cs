using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading;

namespace E7_20_v2._0
{
    class DataGrasper : IOoperations
    {
        private readonly Stack<byte[]> _data; // Check is there can be .net 4.0 installed and use ConcurrentStack<byte[]>
        private readonly IOprovider _port;
        public DataGrasper(string portName)
        {
            _data= new Stack<byte[]>(Constants.STACK_SIZE);
            _port = new IOprovider(portName);
            _port.ProvidePack += AddToPack;
            _port.Start();
        }
        public bool ChangeMode(byte command)
        {
            Send(command);
            return true;
        }
        public int GetFrequency()
        {
            byte[] lastData = null;
            int f = -1;
            lock (_data)
            {
                if (_data.Count > 0)
                    lastData = _data.Peek();
                else
                    return f;
            }
            try
            {
                f = Convert.ToInt32(lastData[4]);
                f += Convert.ToInt32(lastData[5] << 8);
                f *= (int)Math.Pow(10.0, lastData[6]);
            }
            catch { f = -1; }
            return f;
        }
        public void ChangeFrequency(byte command)
        {
            Send(command);
        }
        public bool GetLastData(out byte[] output)
        {
            output = null;
            lock (_data)
            {
                if (_data.Count > 0)
                    output = _data.Pop();
            }
            return output != null;
        }
        public void Break()
        {
            _port.ProvidePack -= AddToPack;
            _port.Finish();
        }
        private void AddToPack(byte[] newPack)
        {
            lock (_data)
            {
                _data.Push(newPack);
            }
        }
        private void Send(byte command)
        {
            _port.SendData(command);
            lock (_data)
            {
                _data.Clear();
            }
            do
            {
                Thread.Sleep(Constants.DELAY);
            } while (GetFrequency() <= 0);
        }
    }
}
