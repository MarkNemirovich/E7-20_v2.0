using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace E7_20_v2._0
{
    internal class AllMeterMachine : BaseMachine
    {
        private readonly Direction changeDirection;
        private readonly int endFrequency;
        private readonly int startFrequency;
        public AllMeterMachine(string portName, string direcroty, string fileName, int startFrequency, int endFrequency, SpeedMode speed, ModeCommands[] modes) :
            base(portName, direcroty, fileName, modes)
        {
            if (speed == SpeedMode.Fast)
            {
                if (startFrequency > endFrequency)
                    changeDirection = Direction.LEFT;
                else
                    changeDirection = Direction.RIGHT;
            }
            else
            {
                if (startFrequency > endFrequency)
                    changeDirection = Direction.DOWN;
                else
                    changeDirection = Direction.UP;
            }
            this.startFrequency = startFrequency;
            this.endFrequency = endFrequency;
            Start();
        }
        sealed protected override void Work()
        {
            f = dataExchanger.GetFrequency();
            SetInitialMode(startFrequency);
            base.Work();
        }
        sealed protected override void MakeMeasurement()
        {
            while (IsWorking)
            {
                int currentF = f;
                List<double> outputData = new List<double>(2);
                double main = 0;
                double sub = 0;
                outputData.Add(f);
                foreach (var mode in modes)
                {
                    if (IsWorking == false)
                        break;
                    switch (mode)
                    {
                        case ModeCommands.C:
                        case ModeCommands.L:
                        case ModeCommands.R:
                        case ModeCommands.Z:
                            if (lastSwitchMode != mode)
                                ChangeMode((byte)mode);
                            lastSwitchMode = mode;
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
                if (f == endFrequency)
                {
                    IsWorking = false;
                    break;
                }
                dataExchanger.ChangeFrequency((byte)changeDirection);
                while (f == currentF)
                    f=dataExchanger.GetFrequency();
            }
        }
        sealed protected override void GetData(out double main, out double sub)
        {
            f = dataExchanger.GetFrequency();
            base.GetData(out main, out sub);
        }
        sealed protected override void SetInitialMode(int target) 
        {
            while (IsWorking)
            {
                f = dataExchanger.GetFrequency();
                if (f == -1)
                    continue;
                if (f == target)
                    break;
                ChangeFrequency(f, target);
            } 
        }
        sealed protected override void ChangeMode(byte message) 
        {
            dataExchanger.ChangeMode(message);
        }
        private void ChangeFrequency(int currentFrequency, int targetFrequency)
        {
            var changeDirection = Direction.RIGHT;
            if (currentFrequency > targetFrequency)
                changeDirection = Direction.LEFT;
            dataExchanger.ChangeFrequency((byte)changeDirection);
        }

        sealed protected override double CalculateTime()
        {
            int f = base.f;
            double steps;
            if (changeDirection == Direction.UP || changeDirection == Direction.DOWN)
            {
                if (f >= 1000)
                {
                    if (endFrequency > 1000)
                        steps = Math.Abs((endFrequency - f)) / 1000;
                    else
                        steps = (f / 1000 - 1 + 1000 - endFrequency);
                }
                else
                {
                    if (endFrequency >= 1000)
                        steps = (endFrequency / 1000 - 1 + 1000 - f);
                    else
                        steps = Math.Abs((endFrequency - f));
                }
            }
            else
            {
                int iStartF = 0, iEndF = 0;
                for (int i = 0; i < Constants.MAIN_FREQUENCES.Length; i++)
                {
                    if (Constants.MAIN_FREQUENCES[i] == f)
                        iStartF = i;
                    if (Constants.MAIN_FREQUENCES[i] == endFrequency)
                        iEndF = i;
                }
                steps = Math.Abs(iStartF - iEndF);
            }
            return base.CalculateTime() * steps;
        }
    }
}
