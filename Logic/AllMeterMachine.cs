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
        public AllMeterMachine(string portName, string direcroty, string fileName, 
            int startFrequency, int endFrequency, SpeedMode speed, ModeCommands[] modes) :
            base(portName, direcroty, fileName, modes)
        {
            changeDirection = startFrequency < endFrequency ? (speed == SpeedMode.Fast ? Direction.RIGHT : Direction.UP) :
                                                              (speed == SpeedMode.Fast ? Direction.LEFT : Direction.DOWN);
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
                f = dataExchanger.GetFrequency();
                int currentF = f;
                double[] outputData = new double[2+modes.Length];
                double main = 0;
                double sub = 0;
                outputData[0] = f;
                for (int i = 0; i < modes.Length; i++)
                {
                    if (IsWorking == false)
                        break;
                    switch (modes[i])
                    {
                        case ModeCommands.C:
                        case ModeCommands.L:
                        case ModeCommands.R:
                        case ModeCommands.Z:
                            if (lastSwitchMode != modes[i])
                                ChangeMode((byte)modes[i]);
                            lastSwitchMode = modes[i];
                            GetData(out main, out sub);
                            outputData[i+1] = main;
                            break;
                        default:
                            outputData[i + 1] = sub;
                            break;
                    }
                }
                new Thread(WriteLine).Start(outputData.ToArray());
                CalculateTime();
                if (f == endFrequency)
                {
                    IsWorking = false;
                }
                if (!IsWorking) break;
                dataExchanger.ChangeFrequency((byte)changeDirection);
                while (f == currentF)
                {
                    f = dataExchanger.GetFrequency();
                }
            }
        }
        sealed protected override void SetInitialMode(int target) 
        {
            while (IsWorking)
            {
                f = dataExchanger.GetFrequency();
                if (f == -1) continue;
                if (f == target) break;
                ChangeFrequency(f, target);
            } 
        }
        private void ChangeFrequency(int currentFrequency, int targetFrequency)
        {
            dataExchanger.ChangeFrequency(currentFrequency < targetFrequency ? (byte)Direction.RIGHT : (byte)Direction.LEFT);
        }
        sealed protected override void CalculateTime(double d = 1)
        {
            int f = base.f;
            int iStartF = 0, iEndF = 0;
            double steps; 
            if (changeDirection == Direction.UP || changeDirection == Direction.DOWN)
            {
                steps = Math.Abs(endFrequency - f) / Constants.THOUSAND;
                if (f < Constants.THOUSAND && endFrequency >= Constants.THOUSAND || f >= Constants.THOUSAND && endFrequency < Constants.THOUSAND)
                {
                    steps += Constants.THOUSAND - Math.Min(f, endFrequency) % Constants.THOUSAND;
                }
            }
            else
            {
                for (int i = 0; i < Constants.MAIN_FREQUENCES.Length; i++)
                {
                    if (Constants.MAIN_FREQUENCES[i] == f)
                    {
                        iStartF = i;
                    }
                    if (Constants.MAIN_FREQUENCES[i] == endFrequency)
                    {
                        iEndF = i;
                    }
                }
                steps = Math.Abs(iStartF - iEndF);
            }
            base.CalculateTime(steps);
        }
    }
}