using System;
using System.Collections.Generic;

namespace Statistics
{
    class Stats
    {
        public double average;
        public double max;
        public double min;
    }
    class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            Stats obj = new Stats();
            if (numbers.Count == 0) {
                obj.max = double.NaN;
                obj.min = double.NaN;
                obj.average = double.NaN;
                return obj;
            }
            obj.max = numbers.Max();
            obj.min = numbers.Min();
            obj.average = numbers.Average();
            return obj;
        }
    }
}
