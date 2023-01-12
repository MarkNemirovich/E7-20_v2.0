using System;

namespace E7_20_v2._0
{
    internal interface IMeasurement
    {
        bool MakeMeasurement();
        bool GetData(out double[] main, out double[] sub);
    }
}
