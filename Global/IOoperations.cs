using System;

namespace E7_20_v2._0
{
    internal interface IOoperations
    {
        bool NewMode(byte command);
        int GetFrequency();
        bool ChangeFrequency(byte command);
        bool GetLastData(out byte[] output);
    }
}
