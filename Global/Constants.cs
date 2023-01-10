using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Xml.Linq;

namespace E7_20_v2._0
{
    internal static class Constants
    {
        public const int BUFFER_LIMIT = 100;
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
    public struct Params
    {
        private Dictionary<string, bool> _params;
        public bool GetValue(string key) => _params.ContainsKey(key);
        public Params(bool Avg, bool Max, bool Min, bool StdDiv)
        {
            _params = new Dictionary<string, bool>();
            _params.Add("Avg", Avg);
            _params.Add("Max", Max);
            _params.Add("Min", Min);
            _params.Add("StdDiv", StdDiv);
        }
        public void ChangeValue(string paramName, bool paramValue)
        {
            foreach (var param in _params)
            {
                if (String.Equals(param.Key, paramValue))
                {
                    _params[param.Key] = paramValue;
                    return;
                }
            }
        }
    }
    public struct Modes
    {
        public Dictionary<string, byte> _modes;
        public Modes(byte C, byte L, byte R, byte Z, byte D, byte Ql, byte Qr, byte Fi)
        {
            _modes = new Dictionary<string, byte>();
            _modes.Add("C", C);
            _modes.Add("L", L);
            _modes.Add("R", R);
            _modes.Add("Z", Z);
            _modes.Add("D", D);
            _modes.Add("Ql", Ql);
            _modes.Add("Qr", Qr);
            _modes.Add("Fi", Fi);
        }
        public void ChangeValue(string modeName, byte modeValue)
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
