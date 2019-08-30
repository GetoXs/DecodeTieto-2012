using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad10
    {
        public int result=0;
        string input = "TO JEST PRZYKLADOWE KONKURSOWE ZDANIE DO SPRAWDZENIA DLA KAZDEGO UCZESTNIKA KONKURSU";
        public void Run()
        {
            int sum = 0;
            foreach (var ch in input)
            {
                sum += ch;
            }
            int avg = (sum / input.Length);
            foreach (var c in input)
                if (c == (char)avg)
                    result++;
        }
    }
}
