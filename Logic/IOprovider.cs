using System;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Threading;
using System.Xml.Linq;

namespace E7_20_v2._0
{
    class IOProvider : IDisposable
    {
        private readonly SerialPort port;
        public delegate void Pack(byte[] pack);
        public event Pack ProvidePack;
        private Thread virtualSender;
        private bool isWorking;
        private bool isDisposed;
        public static string[] GetPorts => SerialPort.GetPortNames();

        public IOProvider(string name)
        {
            try
            {
                port = new SerialPort(name, 9600, Parity.None, 8, StopBits.One)
                {
                    ReadTimeout = 500,
                    WriteTimeout = 500,
                    ReadBufferSize = Constants.SIZE
                };
                if (name != "VirtualCOM")
                {
                    port.DataReceived += new SerialDataReceivedEventHandler(ReceiveData);  // создание делегата на прием
                }
                isWorking = true;
            }
            catch { throw new Exception("No port with such name!"); }
        }
        public void Start()
        {
            try
            {
                if (port.PortName == "VirtualCOM")
                {
                    virtualSender = new Thread(VirtualSender);
                    virtualSender.Start();
                    return;
                }
            }
            catch { throw new Exception("Breaking start!"); }
            try
            {
                if (port.IsOpen == false)
                    port.Open();
            }
            catch { throw new Exception("Breaking open!"); }
        }
        public void Finish()
        {
            if (port.PortName == "VirtualCOM")
            {
                if (virtualSender != null)
                    virtualSender.Abort();
                return;
            }
            try
            {
                if (port.IsOpen == true)
                {
                    port.DataReceived -= new SerialDataReceivedEventHandler(ReceiveData);
                    port.Close();
                }
            }
            catch { throw new Exception("Empty port!"); }
        }
        public void SendData(byte message)
        {
            byte[] pack = new byte[1] { message };
            if (port.PortName == "VirtualCOM")
            {
                return;
            }
            port.Write(pack, 0, 1);
        }
        private void ReceiveData(byte[] sender)
        {
            ProvidePack?.Invoke(sender);
        }
        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] bytes = new byte[Constants.SIZE];
            if (port.BytesToRead >= Constants.SIZE)
            {
                port.Read(bytes, 0, Constants.SIZE);
                if (bytes[0] == 170 & bytes[1] == 0 & bytes[2] == 0)
                    ProvidePack?.Invoke(bytes);
                port.DiscardInBuffer();
            }
        }
        private void VirtualSender()
        {
            while (isWorking)
            {
                var buffer = new byte[Constants.SIZE] { 170, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
                ReceiveData(buffer);
                Thread.Sleep(Constants.DELAY);
            }
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
                isWorking = true;
                Finish();
            }
            isDisposed = true;
        }

        ~IOProvider() => Dispose(false);
    }
}
