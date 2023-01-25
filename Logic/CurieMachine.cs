using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace E7_20_v2._0
{
    internal class CurieMachine : BaseMachine
    {
        private readonly int _measuresAmount;
        private readonly int _delay;
        private int _measuresDone;
        public CurieMachine(string portName, string direcroty, string fileName, ModeCommands[] modes, int amount, double delay) :
            base(portName, direcroty, fileName, modes, "time")
        {
            _measuresDone = 0;
            _measuresAmount = amount;
            _delay = (int)(1000 * delay);
            Start();
        }
        sealed protected override void StartWork()
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
        sealed protected override void MakeMeasurement()
        {
            var startTime = DateTime.UtcNow;
            List<double> outputData = new List<double>(2);
            double main = 0;
            double sub = 0;
            outputData.Add(_measuresDone * _delay);

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
                        outputData.Add(main);
                        break;
                    default:
                        outputData.Add(sub);
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
            var spread = (DateTime.UtcNow - startTime).TotalMilliseconds;
            if (_delay - spread > 0)
                Thread.Sleep(_delay - (int)spread);
        }
        sealed protected override void ChangeMode(byte message)
        {
            _dataExchanger.ChangeMode(message);
        }
        sealed protected override double CalculateTime()
        {
            return base.CalculateTime() * (_measuresAmount-_measuresDone);
        }
    }
}
