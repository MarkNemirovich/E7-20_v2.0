using System;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Threading;
using System.Xml.Linq;

namespace E7_20_v2._0
{
    class IOprovider
    {
        private readonly SerialPort _port;
        public delegate void Pack(byte[] pack);
        public event Pack ProvidePack;
        private Thread _virtualSender;
        public static string[] GetPorts => SerialPort.GetPortNames();

        public IOprovider(string name)
        {
            try
            {
                _port = new SerialPort(name, 9600, Parity.None, 8, StopBits.One)
                {
                    ReadTimeout = 500,
                    WriteTimeout = 500,
                    ReadBufferSize = Constants.SIZE
                };
                if (name != "VirtualCOM")
                {
                    _port.DataReceived += new SerialDataReceivedEventHandler(ReceiveData);  // создание делегата на прием
                }
            }
            catch { throw new Exception("No port with such name!"); }
        }
        public void Start()
        {
            if (_port.PortName == "VirtualCOM")
            {
                _virtualSender = new Thread(VirtualSender);
                _virtualSender.Start();
                return;
            }
            try
            {
                if (_port.IsOpen == false)
                    _port.Open();
            }
            catch { throw new Exception("Empty port!"); }
        }
        public void Finish()
        {
            if (_port.PortName == "VirtualCOM")
            {
                if (_virtualSender != null)
                    _virtualSender.Abort();
                return;
            }
            try
            {
                if (_port.IsOpen == true)
                {
                    _port.DataReceived -= new SerialDataReceivedEventHandler(ReceiveData);
                    _port.Close();
                }
            }
            catch { throw new Exception("Empty port!"); }
        }
        public void SendData(byte message)
        {
            byte[] pack = new byte[1] { message };
            if (_port.PortName == "VirtualCOM")
            {
                return;
            }
            _port.Write(pack, 0, 1);
        }
        private void ReceiveData(byte[] sender)
        {
            ProvidePack?.Invoke(sender);
        }
        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] bytes = new byte[Constants.SIZE];
            if (_port.BytesToRead >= Constants.SIZE)
            {
                _port.Read(bytes, 0, Constants.SIZE);
                if (bytes[0] == 170 & bytes[1] == 0 & bytes[2] == 0)
                    ProvidePack?.Invoke(bytes);
                _port.DiscardInBuffer();
            }
        }
        private void VirtualSender()
        {
            while (true)
            {
                var buffer = new byte[Constants.SIZE] { 170, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
                ReceiveData(buffer);
                Thread.Sleep(Constants.DELAY);
            }
        }
    }
}
