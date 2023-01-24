using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace E7_20_v2._0
{
    internal class CurieMachine : BaseMachine
    {
        private readonly DataGrasper _dataExchanger;
        private int _measuresDone;
        private readonly int _measuresAmount;
        private readonly int _delay;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="direcroty"></param>
        /// <param name="fileName"></param>
        /// <param name="modes"></param>
        /// <param name="amount"></param>
        /// <param name="delay"></param>
        public CurieMachine(string portName, string direcroty, string fileName, ModeCommands[] modes, int amount, double delay) : base(direcroty, fileName, modes)
        {
            _measuresDone = 0;
            _measuresAmount = amount;
            _delay = (int)(1000 * delay);
            _dataExchanger = new DataGrasper(portName);
            IsWorking = true;
            var workerTHread = new Thread(StartWork);
            workerTHread.Start();
        }
        private void StartWork()
        {
            do
            {
                _f = _dataExchanger.GetFrequency();
            } while (_f <= 0);
            StartTime = DateTime.UtcNow;
            do
            {
                MakeMeasurement();
            } while (IsWorking);
            Break();
        }
        public void MakeMeasurement()
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
                        GetData(out main, out sub);
                        outputData.Add(main.Average());
                        break;
                    default:
                        outputData.Add(sub.Average());
                        break;
                }
            }
            var outputThread = new Thread(WriteLine);
            outputThread.Start(outputData.ToArray());
            IsDataChanged = true;
            _measuresDone++;
            if (_measuresDone >= _measuresAmount)
            {
                IsWorking = false;
            }
        }
        private void GetData(out double[] main, out double[] sub)
        {
            main = new double[Constants.MEASURES_AMOUNT];
            sub = new double[Constants.MEASURES_AMOUNT];
            byte[] data;
            for (int i = 0; i < Constants.MEASURES_AMOUNT; i++)
            {
                while (_dataExchanger.GetLastData(out data) == false)
                    Thread.Sleep(Constants.DELAY);
                Calculate(data, ref main[i], ref sub[i]);
            }
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
        sealed protected override double CalculateTime()
        {
            var processTime = DateTime.UtcNow - StartTime;
            StartTime = DateTime.UtcNow;
            return processTime.TotalMilliseconds * (_measuresAmount-_measuresDone) / 1000;
        }
    }
}
