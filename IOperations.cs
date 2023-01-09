using System;

namespace E7_20_v2._0
{
    internal interface IOperations
    {
        bool ChangeFrequency(SpeedMode newMode);
        bool ChangeMode(Modes newMode);
        bool ReadBuffer(int length, out byte[][] output);
        bool GetLastData(out byte[] output);
    }
}
