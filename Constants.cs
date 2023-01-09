using System;

namespace E7_20_v2._0
{
    internal static class Constants
    {
        public const int SIZE = 22;
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
    public struct Modes
    {
        public bool C;
        public bool L;
        public bool R;
        public bool Z;
        public bool D;
        public bool Ql;
        public bool Qr;
        public bool Fi;
        public Modes(bool C, bool L, bool R, bool Z, bool D, bool Ql, bool Qr, bool Fi)
        {
            this.C = C;
            this.L = L;
            this.R = R;
            this.Z = Z;
            this.D = D;
            this.Ql = Ql;
            this.Qr = Qr;
            this.Fi = Fi;
        }
    }
}
