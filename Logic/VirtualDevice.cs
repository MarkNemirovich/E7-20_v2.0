using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace E7_20_v2._0
{
    internal class VirtualDevice : BaseDevice, IMeasurement
    {
        private VirtualGrasper _dataExchanger;
        private Direction _changeFrequencyCommand;
        private int _startFrequency;
        private int _endFrequency;
        public VirtualDevice(string direcroty, string fileName, int startFrequency, int endFrequency, SpeedMode speedMode, ModeCommands[] modes) : base(direcroty, fileName, modes)
        {
            _startFrequency = startFrequency;
            _endFrequency = endFrequency;
            if (speedMode == SpeedMode.Fast)
            {
                if (startFrequency > endFrequency)
                    _changeFrequencyCommand = Direction.LEFT;
                else
                    _changeFrequencyCommand = Direction.RIGHT;
            }
            else
            {
                if (startFrequency > endFrequency)
                    _changeFrequencyCommand = Direction.DOWN;
                else
                    _changeFrequencyCommand = Direction.UP;
            }
            _dataExchanger = new VirtualGrasper(startFrequency);
            SetInitialFrequency();
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
            _dataExchanger.ChangeFrequency((byte)_changeFrequencyCommand);
            _f = _dataExchanger.GetFrequency();
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
        public new void Break()
        {
            base.Break();
            _dataExchanger.Break();
        }
        sealed protected override void ChangeMode(byte message)
        {
            _dataExchanger.NewMode(message);
        }
        private void SetInitialFrequency()
        {
            _f = _startFrequency;
        }
    }
}
