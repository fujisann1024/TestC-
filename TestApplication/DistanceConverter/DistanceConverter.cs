using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public static class DistanceConverter
    {
        private const double radio = 0.3048;

        public static double FromMeter(int feet)
        {
            return feet / radio;
        }

        public static double ToMeter(int meter)
        {
            return meter * radio;
        }
    }
}
