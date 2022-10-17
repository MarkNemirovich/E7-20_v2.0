using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace E7_20_v2._0
{
    class AllMeterGrasper:Grasper
    {
        public AllMeterGrasper(SerialPortHandler port, int measuresAmount, Modes modes, Params parameters, SpeedMode speedMode, string path): base(port, measuresAmount, modes, parameters, speedMode, path)
        {

        }
        public override bool WriteData()
        {
            Queue<byte[]> current = _data;
            if (current.Count < MIN_LIMIT)
                return false;
            List<double[]> output = new List<double[]>(_measuresAmount);
            for (int i = 0; i < MIN_LIMIT; i++)
            {
                if (i < MIN_LIMIT - _measuresAmount)
                    current.Dequeue();
                else
                {
                    output.Add(LayOutMeasurement(current.Dequeue()));
                }
            }
            _writer.Write(CalculateParams(output, _parameters), true);
            return true;
        }     
        private List<double[]> CalculateParams(List<double[]> data, Params parameters)
        {
            double[] max = new double[2];
            double[] min = new double[2];
            double[] avg = new double[2];
            double[] stdDiviation = new double[2];

            for (int i = 0; i < data.Count; i++)
            {
                if (parameters.Max)
                {
                    if (data[i][0] > max[0])
                        max[0] = data[i][0];
                    if (data[i][1] > max[1])
                        max[1] = data[i][1];
                }
                if (parameters.Min)
                {
                    if (data[i][0] < min[0])
                        min[0] = data[i][0];
                    if (data[i][1] < min[1])
                        min[1] = data[i][1];
                }
                avg[0] += data[i][0] / _data.Count;
                avg[1] += data[i][1] / _data.Count;
            }
            if (parameters.StdDiv)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    stdDiviation[0] += Math.Abs((data[0][0] * data[0][0] - avg[0] * avg[0]) / _data.Count - 1);
                    stdDiviation[1] += Math.Abs((data[0][1] * data[0][1] - avg[1] * avg[1]) / _data.Count - 1);
                }
            }
            List<double[]> output = new List<double[]>();
            if (parameters.Avg)
                output.Add(avg);
            if (parameters.Max)
                output.Add(max);
            if (parameters.Min)
                output.Add(min);
            if (parameters.StdDiv)
                output.Add(stdDiviation);
            return output;
        }
    }
}
