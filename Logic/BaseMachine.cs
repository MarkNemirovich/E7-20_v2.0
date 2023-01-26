using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Documents;

namespace E7_20_v2._0
{
    internal abstract class BaseMachine
    {
        public bool IsWorking = false;
        public bool IsDataChanged = false;
        public double GetProgress => CalculateTime();

        protected readonly ExcelWritter _writter; // Check is there can be .net 4.0 installed and use Lazy<ExcelWritter>
        protected readonly DataGrasper _dataExchanger;
        protected ModeCommands[] _modes;
        protected ModeCommands _lastSwitchMode = ModeCommands.Fi;
        protected int _f;
        protected DateTime StartTime;
        public BaseMachine(string portName, string direcroty, string fileName, ModeCommands[] modes, string firstColumn = "f")
        {
            _dataExchanger = new DataGrasper(portName);
            _modes = modes;
            _writter = new ExcelWritter(direcroty, fileName);
            FillTheTitle();
        }
        #region Abstract methods
        protected abstract void StartWork();
        protected abstract void MakeMeasurement();
        #endregion
        #region Virtual methods
        protected virtual double CalculateTime()
        {
            var processTime = DateTime.UtcNow - StartTime;
            StartTime = DateTime.UtcNow;
            return processTime.TotalMilliseconds/1000;
        }
        protected virtual void FillTheTitle()
        {
            List<string> title = new List<string>();
            title.Add("Frequency");
            foreach (var mode in _modes)
            {
                title.Add(mode.ToString());
            }
            _writter.FillTheTitle(title.ToArray());
        }
        protected virtual void SetInitialMode(int target = 0) { }
        protected virtual void ChangeMode(byte message) { }
        protected virtual void Break()
        {
            _dataExchanger.Break();
            _writter.Save();
        }
        protected virtual void GetData(out double main, out double sub)
        {
            main = 0;
            sub = 0;
            byte[] data;
            while (_dataExchanger.GetLastData(out data) == false)
                Thread.Sleep(Constants.DELAY);
            Calculate(data, ref main, ref sub);
        }
        #endregion
        #region FidexMethods
        protected void Start()
        {
            IsWorking = true;
            var workerTHread = new Thread(StartWork);
            workerTHread.Start();
        }
        protected void Calculate(byte[] input, ref double main, ref double sub)
        {
            main = CountData(input, 16);
            sub = CountData(input, 12);
        }
        protected double CountData(byte[] input, int index)
        {
            double param = input[index];
            param += input[index + 1] << 8;
            if (input[index + 2] > 0x80)
                param += (input[index + 2] - 0xFF - 1) << 16;
            else
                param += (input[index + 2] << 16);
            if (input[index + 3] > 0x80)
                param *= Math.Pow(10.0, input[index + 3] - 0xFF - 1);
            else
                param *= Math.Pow(10.0, input[index + 3]);
            return param;
        }
        protected void WriteLine(object o)
        {
            var data = (double[])o;
            _writter.AddLine(data);
        }
        #endregion
    }
}
