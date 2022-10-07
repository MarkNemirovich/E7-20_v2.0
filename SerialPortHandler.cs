using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace E7_20_v2._0
{

    class SerialPortHandler
    {
        private SerialPort Port;
        public SerialPortHandler()
        {
        }
        public SerialPortHandler(string name)
        {
            Port = new SerialPort(name, 9600, Parity.None, 8, StopBits.One);
            Port.ReadTimeout = 500;
            Port.WriteTimeout = 500;
            Port.ReadBufferSize = 22;  // размер буфера!!!
            Port.DataReceived += new SerialDataReceivedEventHandler(ReceiveData);  // создание делегата на прием
        }
        public string[] GetPorts => SerialPort.GetPortNames();
        public int GetSize => (Port == null ? 0 : Port.ReadBufferSize);
        public void Start()
        {
            if (Port.IsOpen == false)
                Port.Open();
        }
        public void Finish()
        {
            if (Port.IsOpen == true)
                Port.Close();
        }
        private void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            Console.WriteLine(Port.ReadExisting());
        }
    }
}
