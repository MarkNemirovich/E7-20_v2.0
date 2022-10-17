using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace E7_20_v2._0
{

    class SerialPortHandler
    {
        private SerialPort _port;
        private Queue<byte> _pack = new Queue<byte>(22);

        public delegate void Pack(byte[] pack);
        public event Pack providePack;

        private Writer _writer;

        public SerialPortHandler()
        {
        }
        public SerialPortHandler(string name)
        {
            _port = new SerialPort(name, 9600, Parity.None, 8, StopBits.One);
            _port.ReadTimeout = 500;
            _port.WriteTimeout = 500;
            _port.ReadBufferSize = 22;  // размер буфера!!!
            _port.DataReceived += new SerialDataReceivedEventHandler(ReceiveData);  // создание делегата на прием
            _writer = new Writer(@"C:\Users\Markus\OneDrive\Рабочий стол", "File");
        }
        public string[] GetPorts => SerialPort.GetPortNames();
        public int GetSize => (_port == null ? 0 : _port.ReadBufferSize);
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
            if (_port.IsOpen == true)
                _port.Close();
        }
        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] bytes = new byte[22];
            if (_port.BytesToRead >= 22)
            {
                _port.Read(bytes, 0, 22);
                if (bytes[0] == 170 & bytes[1] == 0 & bytes[2] == 0)
                {
                    providePack?.Invoke(_pack.ToArray());
                }
                _port.DiscardInBuffer();
            }
        }
    }
}
