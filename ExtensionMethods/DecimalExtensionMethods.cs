using System;
using System.Collections.Generic;
using System.Text;

namespace DiviSharp.ExtensionMethods
{
    public static class DecimalExtensionMethods
    {
        public static ushort GetNumberOfDecimalPlaces(this decimal number)
        {
            return BitConverter.GetBytes(decimal.GetBits(number)[3])[2];
        }
    }
}
