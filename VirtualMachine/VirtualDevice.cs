using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Xml.Linq;

namespace E7_20_v2._0
{
    internal class VirtualDevice
    {
        private VirtualGrasper _dataGenerator;
        private ExcelWritter _writter;
        private SpeedMode _speedMode;
        private Modes _modes;
        private int _endFrequency;
        private int _dataAmount;
        private int _f;
        public VirtualDevice(string direcroty, string fileName, int dataAmount, int startFrequency, int endFrequency, SpeedMode speedMode, Modes modes, Params parameters)
        {
            _dataAmount = dataAmount;
            _endFrequency = endFrequency;
            _speedMode = speedMode;
            _modes = modes;
            _dataGenerator = new VirtualGrasper(dataAmount);
            _writter = new ExcelWritter(direcroty, fileName);
            SetInitialFrequency(startFrequency);
            _writter.FillTheTitle(modes);
        }
        private void SetInitialFrequency(int startFrequency)
        {
            _f = startFrequency;            
        }
        public bool MakeMeasurement()
        {
            List<double> outputData = new List<double>(2);
            outputData.Add(Convert.ToDouble(GetF()));
            double[] main;
            double[] sub;
            bool isMainChecked = false;
            string additional = null;
            foreach (var mode in _modes._modes)
            {
                if (mode.Value == true)
                {
                    switch (mode.Key)
                    {
                        case "C":
                            ChangeMode((byte)ModeCommands.modeC);
                            
                            additional = "D";
                            break;
                        case "L":
                            ChangeMode((byte)ModeCommands.modeC);
                            additional = "Ql";
                            break;
                        case "R":
                            ChangeMode((byte)ModeCommands.modeC);
                            additional = "Qr";
                            break;
                        case "Z":
                            ChangeMode((byte)ModeCommands.modeC);
                            additional = "Fi";
                            break;
                        default:
                            isMainChecked = true;
                            break;
                    }
                    if (isMainChecked)
                        break;
                    while (GetData(out main, out sub) == false)
                        Thread.Sleep(100);
                    outputData.Add(main.Average());
                    if (_modes._modes[additional])
                        outputData.Add(sub.Average());
                }
            }
            _writter.AddLine(outputData.ToArray());
            if (_f == _endFrequency)
            {
                _writter.Dispose();
                return false;
            }
            ChangeFrequency(_speedMode);
            return true;
        }

        private void ChangeMode(byte message)
        {
            _dataGenerator.NewMode(message);
        }
        private void ChangeFrequency(SpeedMode mode)
        {
            if(mode==SpeedMode.Fast)
            {
                int i = 0;
                for (; i < Constants.MAIN_FREQUENCES.Length - 1; i++)
                    if (_f == Constants.MAIN_FREQUENCES[i])
                        break;
                _f = Constants.MAIN_FREQUENCES[i + 1];
            }
            else
            {
                for (int i = 0; i < Constants.MAIN_FREQUENCES.Length - 1; i++)
                {
                    if (_f >= Constants.MAIN_FREQUENCES[i])
                        continue;
                    if (Constants.MAIN_FREQUENCES[i - 1] / 1000 == 0)
                        _f += 1;
                    else
                        _f += 1000;
                    break;
                }
            }
        }
        public bool GetData(out double[] main, out double[] sub)
        {
            main = new double[_dataAmount];
            sub = new double[_dataAmount];
            if (_f < 0)
                return false;
            if (_dataGenerator.ReadBuffer(_dataAmount, out byte[][] output) == false)
                return false;
            Calculate(output, ref main, ref sub);
            return true;
        }
        private int GetF()
        {
            if (_dataGenerator.GetLastData(out byte[] data) == false)
                return -1;
            int newF = 0;
            try
            {
                newF = Convert.ToInt32(data[4]);
                newF += Convert.ToInt32(data[5] << 8);
                newF *= (int)Math.Pow(10.0, data[6]);
            }
            catch
            {
                newF = -1;
            }
            return newF;
        }
        private void Calculate(byte[][] input, ref double[] main, ref double[] sub)
        {
            for (int i = 0; i < _dataAmount; i++)    // считывает, что набралось в буффере
            {
                main[i] = CountData(input[i], 16);
                sub[i] = CountData(input[i], 12);
            }
        }
        private double CountData(byte[] input, int index)
        {
            double param = input[index];
            param += input[index + 1] << 8;
            if (input[index + 2] > 0x80)
            {
                param += (input[index + 2] - 0xFF - 1) << 16;
            }
            else
            {
                param += (input[index + 2] << 16);
            }
            if (input[index + 3] > 0x80)
            {
                param *= Math.Pow(10.0, input[index + 3] - 0xFF - 1);
            }
            else
            {
                param *= Math.Pow(10.0, input[index + 3]);
            }
            return param;
        }
        public void Finish()
        {

        }
    }
}
