using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E7_20_v2._0
{
    class AllMeterGrasper:Grasper
    {
        public AllMeterGrasper(SerialPortHandler port, int measuresAmount, SpeedMode speedMode): base(port, measuresAmount, speedMode)
        {

        }
    }
}
