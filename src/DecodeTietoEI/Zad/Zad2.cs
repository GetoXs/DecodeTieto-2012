using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad2
    {
        public int result = 0;
        public void Run()
        {
            byte[] bytes = BitConverter.GetBytes(3.14159265);
            byte lastBit = 0;
            byte _byte;
            bool isFirst = true;
            for(int i = 0;i<bytes.Length; i++)
            {
                _byte = bytes[i];
                for (int j = 0; j < 8; j++)
                {
                    byte bit = (byte)((_byte >> j) & 1);
                    if (isFirst)
                        lastBit = bit;
                    if (lastBit != bit)
                        result++;
                    lastBit = bit;
                    isFirst = false;
                }
            }
        }
    }
}
