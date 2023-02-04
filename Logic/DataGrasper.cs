using System;
using System.Collections.Generic;
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
        public void ChangeMode(byte command) => Send(command);
        public int GetFrequency()
        {
            byte[] lastData = null;
            lock (data)
            {
                lastData = data.Count > 0 ? data.Peek() : null;
            }
            if (lastData == null) return -1;
            try
            {
                int f = lastData[4] + (lastData[5] << 8);
                f *= (int)Math.Pow(10.0, lastData[6]);
                return f;
            }
            catch { return -1; }
        }
        public void ChangeFrequency(byte command) => Send(command);
        public bool GetLastData(out byte[] output)
        {
            lock (data)
            {
                output = data.Count > 0 ? data.Pop() : null;
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