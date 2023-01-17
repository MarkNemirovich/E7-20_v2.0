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
            _f = _dataExchanger.GetFrequency();
            SetInitialMode(startFrequency);
        }
        public bool MakeMeasurement()
        {
            List<double> outputData = new List<double>(2);
            double[] main = new double[0];
            double[] sub = new double[0];
            outputData.Add(_f); 
            foreach (var mode in _modes)
            {
                switch (mode)
                {
                    case ModeCommands.C:
                    case ModeCommands.L:
                    case ModeCommands.R:
                    case ModeCommands.Z:
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
        sealed protected override void SetInitialMode(int target) 
        {
            while (true)
            {
                _f = _dataExchanger.GetFrequency();
                if (_f == target)
                    break;
                ChangeFrequency(_f, target);
            } 
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
        private void ChangeFrequency(int currentFrequency, int targetFrequency)
        {
            var changeDirection = Direction.RIGHT;
            if (currentFrequency > targetFrequency)
                changeDirection = Direction.LEFT;
            _dataExchanger.ChangeFrequency((byte)changeDirection);
        }
    }
}
