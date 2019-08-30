using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace DecodeTietoEI.Zad
{
    class Zad26
    {
        public string result;
        public void Run()
        {
            BigInteger input = new BigInteger(205891132094649);
            BigInteger inVolume = input * input * input;
            BigInteger smallVolume = inVolume / 27;
            BigInteger calc = CalculateEmptySpace(inVolume, 0);
            result = calc.ToString().Substring(calc.ToString().Length-3);
        }
        BigInteger CalculateEmptySpace(BigInteger volume, int deep)
        {
            BigInteger smallVolume = volume/27;
            BigInteger smallEmptySpace ;
            if (deep <= 30)
                smallEmptySpace = CalculateEmptySpace(smallVolume, deep + 1);
            else
                smallEmptySpace = 0;
            return (smallVolume * 7) + (smallEmptySpace * 20);
        }
    }
}
