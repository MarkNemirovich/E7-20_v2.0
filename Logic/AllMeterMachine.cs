using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace E7_20_v2._0
{
    internal class AllMeterMachine : BaseMachine
    {
        private readonly Direction _changeDirection;
        private readonly int _endFrequency;
        private readonly int _startFrequency;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="portName"></param>
        /// <param name="direcroty"></param>
        /// <param name="fileName"></param>
        /// <param name="startFrequency"></param>
        /// <param name="endFrequency"></param>
        /// <param name="speed"></param>
        /// <param name="modes"></param>
        public AllMeterMachine(string portName, string direcroty, string fileName, int startFrequency, int endFrequency, SpeedMode speed, ModeCommands[] modes) :
            base(portName, direcroty, fileName, modes)
        {
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
            _startFrequency = startFrequency;
            _endFrequency = endFrequency;
            IsWorking = true;
            var workerTHread = new Thread(StartWork);
            workerTHread.Start();
        }
        private void StartWork()
        {
            _f = _dataExchanger.GetFrequency();
            SetInitialMode(_startFrequency);
            IsDataChanged = true;
            MakeMeasurement();
        }
        public void MakeMeasurement()
        {
            while (IsWorking)
            {
                int currentF = _f;
                List<double> outputData = new List<double>(2);
                double main = 0;
                double sub = 0;
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
                            outputData.Add(main);
                            break;
                        default:
                            outputData.Add(sub);
                            break;
                    }
                }
                if (IsWorking == false)
                    break;
                var outputThread = new Thread(WriteLine);
                outputThread.Start(outputData.ToArray());
                IsDataChanged = true;
                if (_f == _endFrequency)
                {
                    IsWorking = false;
                    break;
                }
                _dataExchanger.ChangeFrequency((byte)_changeDirection);
                while (_f == currentF)
                    _f=_dataExchanger.GetFrequency();
            }
            Break();
        }
        sealed protected override void GetData(out double main, out double sub)
        {
            _f = _dataExchanger.GetFrequency();
            base.GetData(out main, out sub);
        }
        sealed protected override void SetInitialMode(int target) 
        {
            while (true && IsWorking)
            {
                _f = _dataExchanger.GetFrequency();
                if (_f == -1)
                    continue;
                if (_f == target)
                    break;
                ChangeFrequency(_f, target);
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
        private void ChangeFrequency(int currentFrequency, int targetFrequency)
        {
            var changeDirection = Direction.RIGHT;
            if (currentFrequency > targetFrequency)
                changeDirection = Direction.LEFT;
            _dataExchanger.ChangeFrequency((byte)changeDirection);
        }

        sealed protected override double CalculateTime()
        {
            int f = _f;
            int amount = 0;
            amount += Convert.ToInt32(_modes.Contains(ModeCommands.C));
            amount += Convert.ToInt32(_modes.Contains(ModeCommands.L));
            amount += Convert.ToInt32(_modes.Contains(ModeCommands.R));
            amount += Convert.ToInt32(_modes.Contains(ModeCommands.Z));
            double stepTime = 3 * amount;
            double time;
            if (amount == 1)
                stepTime -= 0.5;
            if (_changeDirection == Direction.UP || _changeDirection == Direction.DOWN)
            {
                if (f >= 1000)
                {
                    if (_endFrequency > 1000)
                        time = Math.Abs((_endFrequency - f)) * stepTime / 1000;
                    else
                        time = (f / 1000 - 1 + 1000 - _endFrequency) * stepTime;
                }
                else
                {
                    if (_endFrequency >= 1000)
                        time = (_endFrequency / 1000 - 1 + 1000 - f) * stepTime;
                    else
                        time = Math.Abs((_endFrequency - f)) * stepTime;
                }
            }
            else
            {
                int iStartF = 0, iEndF = 0;
                for (int i = 0; i < Constants.MAIN_FREQUENCES.Length; i++)
                {
                    if (Constants.MAIN_FREQUENCES[i] == f)
                        iStartF = i;
                    if (Constants.MAIN_FREQUENCES[i] == _endFrequency)
                        iEndF = i;
                }
                time = Math.Abs(iStartF - iEndF) * stepTime;
            }
            return time;
        }
    }
}
