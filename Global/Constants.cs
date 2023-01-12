using System;
using System.Collections.Generic;

namespace E7_20_v2._0
{
    internal static class Constants
    {
        public const int DELAY = 10;
        public const int BUFFER_LIMIT = 100;
        public const int MEASURES_AMOUNT = 5;
        public const int SIZE = 22;
        public static readonly int[] MAIN_FREQUENCES = new int[17] { 25, 50, 60, 100, 120, 200, 500, 1000, 2000, 5000, 10000, 20000, 50000, 100000, 200000, 500000, 1000000 };
    }
    public enum SpeedMode
    {
        Slow,
        Fast
    }
    public enum Direction : byte
    {
        RIGHT = 0x1,
        DOWN = 0x4,
        UP = 0x6,
        LEFT = 0x9
    }
    public enum ModeCommands : byte
    {
        modeC = 0xB,
        modeL = 0x7,
        modeR = 0x3,
        modeZ = 0x2
    }
    public struct Modes
    {
        public Dictionary<string, bool> _modes;
        public Modes(bool C, bool L, bool R, bool Z, bool D, bool Ql, bool Qr, bool Fi)
        {
            _modes = new Dictionary<string, bool>();
            _modes.Add("C", C);
            _modes.Add("L", L);
            _modes.Add("R", R);
            _modes.Add("Z", Z);
            _modes.Add("D", D);
            _modes.Add("Ql", Ql);
            _modes.Add("Qr", Qr);
            _modes.Add("Fi", Fi);
        }
        public void ChangeValue(string modeName, bool modeValue)
        {
            foreach (var mode in _modes)
            {
                if (String.Equals(mode.Key, modeValue))
                {
                    _modes[mode.Key] = modeValue;
                    return;
                }
            }
        }
    }
}
