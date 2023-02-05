using System;
using System.Collections.Generic;

namespace E7_20_v2._0
{
    internal static class Constants
    {
        public const int THOUSAND = 1000;
        public const double MEASUREMENT = 0.3;
        public const int DELAY = 250;
        public const int STACK_SIZE = 100;
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
        C = 0xB,
        D = 0xC,
        L = 0x7,
        Ql = 0xD,
        R = 0x3,
        Qr = 0xE,
        Z = 0x2,
        Fi = 0xF
    }
}
