using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Task2
    {
        public static string GetBinaryToString(this double number)
        {
            var bits = BitConverter.DoubleToInt64Bits(number);

            var sign = bits >> 63 & 0x01;

            var exponent = bits >> 52 & 0x7FF;

            var mantissa = bits & 0xFFFFFFFFFFFFF;

            return $"{Convert.ToString(sign, 2)}{Convert.ToString(exponent, 2).PadLeft(11, '0')}{Convert.ToString(mantissa, 2).PadLeft(52, '0')}";

        }
    }
}
