using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace E7_20_v2._0
{
    class RealGrasper : IOoperations
    {
        private Stack<byte[]> _data;
        protected Modes _modes;
        protected Params _parameters;
        protected SpeedMode _speedMode;
        private IOprovider _port;
        private int _measuresAmount;
        private int _startFrequency;
        private int _f;

        /// <summary>
        /// Machine interface for work with a device
        /// </summary>
        /// <param name="portName">portName</param>
        /// <param name="measuresAmount">measuresAmount</param>
        /// <param name="speedMode">speedMode</param>
        /// <param name="modes">modes</param>
        /// <param name="parameters">parameters</param>
        public RealGrasper(string portName, int measuresAmount, int startFrequency, SpeedMode speedMode, Modes modes, Params parameters)
        {
            _measuresAmount = measuresAmount;
            _startFrequency= startFrequency;
            _speedMode = speedMode;
            _modes = modes;
            _parameters = parameters;
            _port = new IOprovider(portName);
            _port.ProvidePack += GetPack;
            _port.Start();
            SetInitialFrequency();
        }
        private void GetPack(byte[] newPack)
        {
            _data.Add(newPack);
            if (_data.Count > _measuresAmount)
                Shift();
        }
        private void Shift()
        {
            byte[][] temp = new byte[Constants.BUFFER_LIMIT - _measuresAmount][];
            for (int i = 0; i < Constants.BUFFER_LIMIT - _measuresAmount; i++)
                temp[i] = _data[i];
            _data = temp.ToList();
        }
        private void SetInitialFrequency()
        {
            _f = GetFrequency();
            while (_f == _startFrequency)
            {
                if (_f > _startFrequency)
                {
                    _port.SendData((byte)Direction.LEFT);
                }
                else
                    _port.SendData((byte)Direction.RIGHT);
            }
        }
        public bool NewMode(byte command)
        {
            return true;
        }
        public bool ChangeFrequency()
        {
            int f = GetFrequency();
            if (f == Constants.MAIN_FREQUENCES[Constants.MAIN_FREQUENCES.Length - 1])
            {
                _port.Finish();
                return false;
            }
            _f = f;
            _port.SendData((byte)_speedMode);
            return true;
        }
        private int GetFrequency()
        {
            int f = -1;            
            try
            {
                if (GetLastData(out byte[] data))
                {
                    f = Convert.ToInt32(data[4]);
                    f += Convert.ToInt32(data[5] << 8);
                    f *= (int)Math.Pow(10.0, data[6]);
                }
                _f = f;
            }
            catch
            {
                throw new Exception("Cannot calculate the frequency");
            }
            return _f;
        }
        public bool GetLastData(out byte[] output)
        {
            output = null;
            int count = _data.Count;
            if (count > 0)
            {
                lock (_data)
                {
                    byte[][] temp = new byte[count - 1][];
                    output = _data[count - 1];
                    for (int i = 0; i < count - 1; i++)
                        temp[i] = _data[i];
                    _data = temp.ToList();
                    return true;
                }
            }
            return false;
        }
        public bool ReadBuffer(int length, out byte[][] output)
        {
            output = null;
            int count = _data.Count;
            if (count > _measuresAmount)
            {
                lock (_data)
                {
                    for (int i = _measuresAmount-1; i >= 0; i--)
                    {
                        GetLastData(out byte[] line);
                        output[i] = line;
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
