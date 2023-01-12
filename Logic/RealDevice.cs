using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace E7_20_v2._0
{
    internal class RealDevice : BaseDevice, IMeasurement
    {
        private RealGrasper _dataExchanger;
        private Direction _changeDirection;
        private int _endFrequency;
        public RealDevice(string portName, string direcroty, string fileName, int startFrequency, int endFrequency, SpeedMode speed, ModeCommands[] modes) : base(direcroty, fileName, modes)
        {
            SetInitialMode(speed, startFrequency);
            _endFrequency = endFrequency;
            if (speed == SpeedMode.Fast)
            {
                if (startFrequency > endFrequency)
                    _changeDirection = Direction.LEFT;
                else
                    _changeDirection = Direction.RIGHT;
            }
            else
            {
                if (startFrequency > endFrequency)
                    _changeDirection = Direction.DOWN;
                else
                    _changeDirection = Direction.UP;
            }
            _dataExchanger = new RealGrasper(portName);
        }
        public bool MakeMeasurement()
        {
            int tempF = _f;
            List<double> outputData = new List<double>(2);
            double[] main = new double[0];
            double[] sub = new double[0];
            while (tempF == _f)
            {
                outputData.Add(_f); 
                Thread.Sleep(Constants.DELAY);
            }
            foreach (var mode in _modes)
            {
                switch (mode)
                {
                    case ModeCommands.modeC:
                    case ModeCommands.modeL:
                    case ModeCommands.modeR:
                    case ModeCommands.modeZ:
                        ChangeMode((byte)mode);
                        while (GetData(out main, out sub) == false)
                            Thread.Sleep(Constants.DELAY);
                        outputData.Add(main.Average());
                        break;
                    default:
                        outputData.Add(sub.Average());
                        break;
                }
            }
            WriteLine(outputData.ToArray());
            if (_f == _endFrequency)
            {
                return false;
            }
            _dataExchanger.ChangeFrequency((byte)_changeDirection);
            return true;
        }
        public bool GetData(out double[] main, out double[] sub)
        {
            _f = _dataExchanger.GetFrequency();
            main = new double[Constants.MEASURES_AMOUNT];
            sub = new double[Constants.MEASURES_AMOUNT];
            byte[] data = new byte[Constants.SIZE];
            for (int i = 0; i < Constants.MEASURES_AMOUNT; i++)
            {
                while (_dataExchanger.GetLastData(out data) == false)
                    Thread.Sleep(Constants.DELAY);
                Calculate(data, ref main[i], ref sub[i]);
            }
            return true;
        }
        sealed protected override void SetInitialMode(SpeedMode speed, int target) 
        {
            do
            {
                ChangeFrequency(_f, target, speed);
            } while (_f != target);
        }
        sealed protected override void ChangeMode(byte message) 
        {
            _dataExchanger.NewMode(message);
        }
        public new void Break()
        {
            base.Break();
            _dataExchanger.Break();
        }
        private void ChangeFrequency(int currentFrequency, int targetFrequency, SpeedMode mode)
        {
            if (mode == SpeedMode.Fast)
            {
                if (currentFrequency > targetFrequency)
                    _dataExchanger.ChangeFrequency((byte)Direction.LEFT);
                if (currentFrequency < targetFrequency)
                    _dataExchanger.ChangeFrequency((byte)Direction.RIGHT);
            }
            else
            {
                if (currentFrequency > targetFrequency)
                    _dataExchanger.ChangeFrequency((byte)Direction.DOWN);
                if (currentFrequency < targetFrequency)
                    _dataExchanger.ChangeFrequency((byte)Direction.UP);
            }
        }
    }
}
