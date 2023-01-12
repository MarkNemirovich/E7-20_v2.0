using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading;
using System.Xml.Linq;

namespace E7_20_v2._0
{
    internal class VirtualDevice
    {
        private VirtualGrasper _dataGenerator;
        private ExcelWritter _writter;
        private Modes _modes;
        private int _startFrequency;
        private int _endFrequency;
        private Direction _changeFrequencyCommand;
        private int _f;
        public VirtualDevice(string direcroty, string fileName, int startFrequency, int endFrequency, SpeedMode speedMode, Modes modes)
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
            _modes = modes;
            _dataGenerator = new VirtualGrasper();
            _writter = new ExcelWritter(direcroty, fileName);
            SetInitialFrequency();
            _writter.FillTheTitle(modes);
        }
        private void SetInitialFrequency()
        {
            _f = _startFrequency;            
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
                return false;
            }
            ChangeFrequency();
            return true;
        }

        private void ChangeMode(byte message)
        {
            _dataGenerator.NewMode(message);
        }
        private void ChangeFrequency()
        {
            GetF();
            int i = 0;
            switch (_changeFrequencyCommand)
            {
                case Direction.RIGHT:
                case Direction.LEFT:
                    for (; i < Constants.MAIN_FREQUENCES.Length - 1; i++)
                        if (_f == Constants.MAIN_FREQUENCES[i])
                            break;
                    if (_changeFrequencyCommand == Direction.RIGHT)
                        _f = Constants.MAIN_FREQUENCES[i + 1];
                    if (_changeFrequencyCommand == Direction.LEFT)
                        _f = Constants.MAIN_FREQUENCES[i - 1];
                    break;
                case Direction.UP:
                case Direction.DOWN:
                    for (; i < Constants.MAIN_FREQUENCES.Length - 1; i++)
                    {
                        if (_f >= Constants.MAIN_FREQUENCES[i])
                            continue;
                        int value = 1000;
                        if (Constants.MAIN_FREQUENCES[i - 1] / 1000 == 0)
                            value = 1;
                        if (_changeFrequencyCommand== Direction.DOWN)
                            value = -value;
                        _f += value;
                        break;
                    }
                    break;
            }
        }
        public bool GetData(out double[] main, out double[] sub)
        {
            _f = GetF();
            main = new double[Constants.MEASURES_AMOUNT];
            sub = new double[Constants.MEASURES_AMOUNT];
            byte[] data = new byte[Constants.SIZE];
            for (int i = 0; i < Constants.MEASURES_AMOUNT; i++)
            {
                while (_dataGenerator.GetLastData(out data) == false)
                    Thread.Sleep(Constants.DELAY);
                Calculate(data, ref main[i], ref sub[i]);
            }
            return true;
        }
        public void Break()
        {
            _writter.Save();
            _dataGenerator.Break();
        }
        private int GetF()
        {
            return _f;
        }
        private void Calculate(byte[] input, ref double main, ref double sub)
        {
            main = CountData(input, 16);
            sub = CountData(input, 12);
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
    }
}
