using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Xml.Linq;

namespace E7_20_v2._0
{

    class IOprovider
    {
        private SerialPort _port = new SerialPort("VirtualPort", 9600, Parity.None, 8, StopBits.One);
        public delegate void Pack(byte[] pack);
        public event Pack ProvidePack;
        public static string[] GetPorts => SerialPort.GetPortNames();

        public IOprovider(string name)
        {
            try
            {
                _port = new SerialPort(name, 9600, Parity.None, 8, StopBits.One);
                _port.ReadTimeout = 500;
                _port.WriteTimeout = 500;
                _port.ReadBufferSize = Constants.SIZE;
                _port.DataReceived += new SerialDataReceivedEventHandler(ReceiveData);  // создание делегата на прием
            }
            catch
            {
                throw new Exception("No port with such name!");
            }
        }
        public void Start()
        {
            try
            {
                if (_port.IsOpen == false)
                    _port.Open();
            }
            catch
            {
                throw new Exception("Empty port!");
            }
        }
        public void Finish()
        {
            try
            {
                if (_port.IsOpen == true)
                _port.Close();
            }
            catch
            {
                throw new Exception("Empty port!");
            }
        }
        public void SendData(byte message)
        {
            byte[] pack = new byte[1] { message }; 
            _port.Write(pack, 0, 1);
        }
        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] bytes = new byte[Constants.SIZE];
            if (_port.BytesToRead >= Constants.SIZE)
            {
                _port.Read(bytes, 0, Constants.SIZE);
                if (bytes[0] == 170 & bytes[1] == 0 & bytes[2] == 0)
                {
                    ProvidePack?.Invoke(bytes);
                }
                _port.DiscardInBuffer();
            }
        }
        ~IOprovider()
        {
            Finish();
        }
    }
}
