using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace E7_20_v2._0.RealMachines
{
    internal class RealDevice
    {
        //    protected int GetF()
        //    {
        //        if (_data.Count <= 0)
        //        {
        //            return -1;
        //        }
        //        var current = _data.Peek();
        //        if (current.Length != 22)
        //        {
        //            return -1;
        //        }
        //        int f = Convert.ToInt32(current[4]);
        //        f += Convert.ToInt32(current[5] << 8);
        //        f *= (int)Math.Pow(10.0, current[6]);
        //        return f;
        //    }
        //    protected double[] LayOutMeasurement(byte[] measurement)
        //    {
        //        double[] output = new double[2];
        //        output[0] = CountData(measurement, 16);
        //        output[1] = CountData(measurement, 12);
        //        return output;
        //    }
        //    private double CountData(byte[] currentData, int index)
        //    {
        //        double param = currentData[index];
        //        param += currentData[index + 1] << 8;
        //        if (currentData[index + 2] > 0x80)
        //        {
        //            param += (currentData[index + 2] - 0xFF - 1) << 16;
        //        }
        //        else
        //        {
        //            param += (currentData[index + 2] << 16);
        //        }
        //        if (currentData[index + 3] > 0x80)
        //        {
        //            param *= Math.Pow(10.0, currentData[index + 3] - 0xFF - 1);
        //        }
        //        else
        //        {
        //            param *= Math.Pow(10.0, currentData[index + 3]);
        //        }
        //        return param;
        //    }
    }
}
