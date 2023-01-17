using System;

namespace E7_20_v2._0
{
    internal interface IOoperations
    { 
        bool ChangeMode(byte command);
        int GetFrequency();
        void ChangeFrequency(byte command);
        bool GetLastData(out byte[] output);
    }
}
