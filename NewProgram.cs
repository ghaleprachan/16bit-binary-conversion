﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryConversion
{
    class NewProgram
    {
        /*static void Main()
        {
            Decimal[] values = { 1234.96m, -1234.96m };
            foreach (var value in values)
            {
                int[] parts = Decimal.GetBits(value);
                bool sign = (parts[3] & 0x80000000) != 0;

                byte scale = (byte)((parts[3] >> 16) & 0x7F);
                Decimal newValue = new Decimal(parts[0], parts[1], parts[2], sign, scale);
                Console.WriteLine("{0} --> {1}", value, newValue);
            }
        }*/
    }
}
