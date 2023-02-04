using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading;

namespace E7_20_v2._0
{
    class DataGrasper : IGrasperOperations, IDisposable
    {
        private readonly Stack<byte[]> data; // Check is there can be .net 4.0 installed and use ConcurrentStack<byte[]>
        private readonly IOProvider port;
        private bool isDisposed;
        public DataGrasper(string portName)
        {
            data= new Stack<byte[]>(Constants.STACK_SIZE);
            port = new IOProvider(portName);
            port.ProvidePack += AddToPack;
            isDisposed = false;
            port.Start();
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
            lock (data)
            {
                if (data.Count > 0)
                    lastData = data.Peek();
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
            lock (data)
            {
                if (data.Count > 0)
                    output = data.Pop();
            }
            return output != null;
        }
        private void AddToPack(byte[] newPack)
        {
            lock (data)
            {
                data.Push(newPack);
            }
        }
        private void Send(byte command)
        {
            port.SendData(command);
            lock (data)
            {
                data.Clear();
            }
            do
            {
                Thread.Sleep(Constants.DELAY);
            } while (GetFrequency() <= 0);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;
            if (disposing)
            {
                port.ProvidePack -= AddToPack;
                port.Finish();
            }
            isDisposed = true;
        }
        ~DataGrasper() => Dispose(false);
    }
}
