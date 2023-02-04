using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace E7_20_v2._0
{
    internal abstract class BaseMachine : IDisposable
    {
        public bool IsWorking;
        public bool IsDataChanged;
        public double GetProgress => CalculateTime();

        protected readonly ExcelWriter writer; // Check is there can be .net 4.0 installed and use Lazy<ExcelWriter>
        protected readonly DataGrasper dataExchanger;
        protected ModeCommands[] modes;
        protected ModeCommands lastSwitchMode;
        protected int f;
        protected Stopwatch stopWatch;
        private bool isDisposed;
        //private readonly ManualResetEvent dataEvent = new ManualResetEvent(false);
        public BaseMachine(string portName, string direcroty, string fileName, ModeCommands[] modes)
        {
            IsWorking = false;
            IsDataChanged = false;
            lastSwitchMode = ModeCommands.Fi;
            dataExchanger = new DataGrasper(portName);
            this.modes = modes;
            writer = new ExcelWriter(direcroty, fileName);
            stopWatch = new Stopwatch();
            isDisposed = false;
            FillTheTitle();
        }
        #region Abstract methods
        protected abstract void MakeMeasurement();
        #endregion
        #region Virtual methods
        protected virtual void Work()
        {
            stopWatch.Start();
            do
            {
                MakeMeasurement();
            } while (IsWorking);
            Dispose();
        }
        protected virtual double CalculateTime()
        {
            stopWatch.Stop();
            TimeSpan processTime = stopWatch.Elapsed;
            stopWatch.Start();
            return processTime.TotalMilliseconds/Constants.SECOND;
        }
        protected virtual void FillTheTitle()
        {
            List<string> title = new List<string>() { "f" };
            title.AddRange(modes.Select(mode => mode.ToString()));
            title.Add("Frequency");
            writer.FillTheTitle(title.ToArray());
        }
        protected virtual void SetInitialMode(int target = 0) { }
        protected virtual void ChangeMode(byte message) { }
        protected virtual void GetData(out double main, out double sub)
        {
            main = 0;
            sub = 0;
            byte[] data;
            while (dataExchanger.GetLastData(out data) == false)
                Thread.Sleep(Constants.DELAY);

            //byte[] data = new byte[Constants.SIZE];
            //dataEvent.Reset();
            //ThreadPool.QueueUserWorkItem(state =>
            //{
            //    while (dataExchanger.GetLastData(out data) == false)
            //    {
            //        Thread.Sleep(Constants.DELAY);
            //    }
            //    dataEvent.Set();
            //});
            //dataEvent.WaitOne();
            Calculate(data, ref main, ref sub);
        }
        #endregion
        #region FidexMethods
        protected void Start()
        {
            IsWorking = true;
            new Thread(Work).Start();
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
            writer.AddLine(data);
        }
        #endregion
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed) return;
            if (disposing)
            {
                dataExchanger?.Dispose();
                writer?.Dispose();
            }
            isDisposed = true;
        }
        ~BaseMachine() => Dispose(false);
    }
}