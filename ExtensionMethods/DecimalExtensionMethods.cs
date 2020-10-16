using System;

namespace DiviRpc.ExtensionMethods
{
    public static class DecimalExtensionMethods
    {
        public static ushort GetNumberOfDecimalPlaces(this decimal number)
        {
            return BitConverter.GetBytes(decimal.GetBits(number)[3])[2];
        }
    }
}
