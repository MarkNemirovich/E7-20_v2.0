using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
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
        public CurieMachine(string portName, string direcroty, string fileName, 
            ModeCommands[] modes, int amount, double delay, double[] coefficient) :
            base(portName, direcroty, fileName, modes)
        {
            measuresDone = 0;
            measuresAmount = amount;
            this.delay = (int)(Constants.SECOND * delay);
            coefficients = coefficient;
            Start();
        }
        protected override void FillTheTitle()
        {
            List<string> title = new List<string>() { "Time" };
            title.AddRange(modes.Select(mode => mode.ToString()));
            title.Add("Temperature");
            writer.FillTheTitle(title.ToArray());
        }
        sealed protected override void Work()
        {
            do
            {
                f = dataExchanger.GetFrequency();
            } while (f <= 0);
            base.Work();
        }
        sealed protected override void MakeMeasurement()
        {
            var startTime = DateTime.UtcNow;
            double[] outputData = new double[2 + modes.Length];
            double main = 0;
            double sub = 0;
            double temperature = 0;
            outputData[0] = measuresDone * delay / Constants.SECOND;
            for (int i = 0; i < modes.Length; i++)
            {
                if (IsWorking == false)
                    break;
                switch (modes[i])
                {
                    case ModeCommands.L:
                    case ModeCommands.R:
                        if (lastSwitchMode != modes[i])
                            ChangeMode((byte)modes[i]);
                        lastSwitchMode = modes[i];
                        GetData(out main, out sub);
                        outputData[i+1] = main;
                        temperature = CalculateTemperature(main);
                        break;
                    default:
                        outputData[i + 1] = sub;
                        break;
                }
            }
            outputData[modes.Length+1] = temperature;
            new Thread(WriteLine).Start(outputData);
            IsDataChanged = true;
            measuresDone++;
            if (measuresDone >= measuresAmount)
            {
                IsWorking = false;
            }
            int spread = (int)(DateTime.UtcNow - startTime).TotalMilliseconds;
            if (delay - spread > 0)
            {
                Thread.Sleep(delay - spread);
            }
        }
        sealed protected override void ChangeMode(byte message)=>dataExchanger.ChangeMode(message);
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