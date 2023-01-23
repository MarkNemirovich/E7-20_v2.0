using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace E7_20_v2._0
{
    internal class CurieMachine : BaseDevice
    {
        public double GetProgress => CalculateTime();
        private RealGrasper _dataExchanger;
        private int _measuresDone;
        private int _measuresAmount;
        private int _delay;
        public CurieMachine(string portName, string direcroty, string fileName, ModeCommands[] modes, int amount, double delay) : base(direcroty, fileName, modes)
        {
            _measuresDone = 0;
            _measuresAmount = amount;
            _delay = (int)(1000 * delay);
            _dataExchanger = new RealGrasper(portName);
            IsWorking = true;
            var workerTHread = new Thread(StartWork);
            workerTHread.Start();
        }
        private async void StartWork()
        {
            int _f;
            do
            {
                _f = _dataExchanger.GetFrequency();
            } while (_f == -1);
            IsDataChanged = true;
            do
            {
                await MakeMeasurement();
                Thread.Sleep(_delay);
            } while (IsWorking);
            Break();
        }
        public async void MakeMeasurement()
        {
            List<double> outputData = new List<double>(2);
            double[] main = new double[0];
            double[] sub = new double[0];
            outputData.Add(_f);
            foreach (var mode in _modes)
            {
                if (IsWorking == false)
                    break;
                switch (mode)
                {
                    case ModeCommands.C:
                    case ModeCommands.L:
                    case ModeCommands.R:
                    case ModeCommands.Z:
                        if (_lastSwitchMode != mode)
                            ChangeMode((byte)mode);
                        _lastSwitchMode = mode;
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
            IsDataChanged = true;
            _measuresDone++;
            if (_measuresDone == _measuresAmount)
            {
                IsWorking = false;
            }
        }
        private bool GetData(out double[] main, out double[] sub)
        {
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
        sealed protected override void ChangeMode(byte message)
        {
            _dataExchanger.ChangeMode(message);
        }
        sealed protected override void Break()
        {
            base.Break();
            _dataExchanger.Break();
        }
        private double CalculateTime()
        {
            return 0;
        }
    }
}
