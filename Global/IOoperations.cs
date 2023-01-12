using System;

namespace E7_20_v2._0
{
    internal interface IOoperations
    {
        bool NewMode(byte command);
        bool ChangeFrequency(byte command);
        bool GetLastData(out byte[] output);
    }
}
