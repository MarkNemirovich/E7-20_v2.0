using System;

namespace E7_20_v2._0
{
    internal interface IOoperations
    {
        bool NewMode(byte command);
        bool ChangeFrequency();
        bool ReadBuffer(int length, out byte[][] output);
        bool GetLastData(out byte[] output);
    }
}
