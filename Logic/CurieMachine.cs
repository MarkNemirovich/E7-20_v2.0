using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace E7_20_v2._0
{
    internal class CurieMachine : BaseMachine
    {
        private readonly int measuresAmount;
        private readonly int delay;
        private int measuresDone;
        private readonly double[] coefficients;
        public CurieMachine(string portName, string direcroty, string fileName, ModeCommands[] modes, int amount, double delay, double[] coefficient) :
            base(portName, direcroty, fileName, modes, "time")
        {
            measuresDone = 0;
            measuresAmount = amount;
            this.delay = (int)(1000 * delay);
            coefficients = coefficient;
            Start();
        }
        protected override void FillTheTitle()
        {
            List<string> title = new List<string>();
            title.Add("Time");
            foreach (var mode in modes)
            {
                title.Add(mode.ToString());
            }
            title.Add("Temperature");
            writter.FillTheTitle(title.ToArray());
        }
        sealed protected override void Work()
        {
            do
            {
                _f = dataExchanger.GetFrequency();
            } while (_f <= 0);
            base.Work();
        }
        sealed protected override void MakeMeasurement()
        {
            var startTime = DateTime.UtcNow;
            List<double> outputData = new List<double>(2);
            double main = 0;
            double sub = 0;
            outputData.Add(measuresDone * delay / 1000);
            double temperature = 0;
            foreach (var mode in modes)
            {
                if (IsWorking == false)
                    break;
                switch (mode)
                {
                    case ModeCommands.L:
                    case ModeCommands.R:
                        if (lastSwitchMode != mode)
                            ChangeMode((byte)mode);
                        lastSwitchMode = mode;
                        GetData(out main, out sub);
                        outputData.Add(main);
                        temperature = CalculateTemperature(main);
                        break;
                    default:
                        outputData.Add(sub);
                        break;
                }
            }
            outputData.Add(temperature);
            var outputThread = new Thread(WriteLine);
            outputThread.Start(outputData.ToArray());
            IsDataChanged = true;
            measuresDone++;
            if (measuresDone >= measuresAmount)
            {
                IsWorking = false;
            }
            var spread = (DateTime.UtcNow - startTime).TotalMilliseconds;
            if (delay - spread > 0)
                Thread.Sleep(delay - (int)spread);
        }
        sealed protected override void ChangeMode(byte message)
        {
            dataExchanger.ChangeMode(message);
        }
        sealed protected override double CalculateTime()
        {
            return base.CalculateTime() * (measuresAmount-measuresDone);
        }
        private double CalculateTemperature(double x)
        {
            double a = coefficients[0], b = coefficients[1], c = coefficients[2], d = coefficients[3];
            return a * (Math.Pow(x, b)) + c * x + d;
        }
    }
}
