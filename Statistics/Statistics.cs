using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class Stats
    {
        public double average;
        public double max;
        public double min;
    }
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            Stats obj = new Stats();
            if (numbers.Count == 0) {
                obj.max = double.NaN;
                obj.min = double.NaN;
                obj.average = double.NaN;
                return obj;
            }
            List<double> validNumbers = new List<double>();
            for (int i = 0; i < numbers.Count; i++) {
                if (!double.IsNaN(numbers[i])) {
                    validNumbers.Add(numbers[i]);
                }
            }
            obj.max = validNumbers.Max();
            obj.min = validNumbers.Min();
            obj.average = validNumbers.Average();
            return obj;
        }
    }
}
