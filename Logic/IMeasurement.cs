using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E7_20_v2._0
{
    internal interface IMeasurement
    {
        bool MakeMeasurement();
        bool GetData(out double[] main, out double[] sub);
    }
}
