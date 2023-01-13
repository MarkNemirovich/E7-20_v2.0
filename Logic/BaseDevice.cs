using System;

namespace E7_20_v2._0
{
    internal class BaseDevice
    {
        private ExcelWritter _writter;
        protected ModeCommands[] _modes;
        protected int _f;
        public BaseDevice(string direcroty, string fileName, ModeCommands[] modes)
        {
            _modes = modes;
            _writter = new ExcelWritter(direcroty, fileName);
            _writter.FillTheTitle(_modes);
        }
        #region Virtual methods
        protected virtual void SetInitialMode(SpeedMode speed = SpeedMode.Fast, int target = default(int)) { }
        protected virtual void ChangeMode(byte message) { }
        protected virtual void Break()
        {
            _writter.Save();
        }
        #endregion
        #region FidexMethods
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
        protected void WriteLine(double[] data)
        {
            _writter.AddLine(data);
        }
        #endregion
    }
}
