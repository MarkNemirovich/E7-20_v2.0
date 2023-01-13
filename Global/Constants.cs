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
        modeD = 0xC,
        modeL = 0x7,
        modeQl = 0xD,
        modeR = 0x3,
        modeQr = 0xE,
        modeZ = 0x2,
        modeFi = 0xF
    }
}
