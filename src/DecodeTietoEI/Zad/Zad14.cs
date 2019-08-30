using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad14
    {
        public string result;
        public void Run()
        {
            int sumP = 0;
            int sumD = 0;
            for (int i = 2; i < 10000; i++)
            {
                if(IsPrime(i))
                {
                    sumP += i;
                }

                if (i % 243 == 0)
                    sumD += i;
            }
            result = string.Empty;
            if (sumP % sumD == 0)
                result += "1";
            else
                result += "0";
            result += " divisible";

            if (NWD(sumP, sumD) == 1)
                result += ", coprime";
            else
                result += ", non-coprime";

        }
        private bool IsPrime(int n)
        {
            for (int i = 2; i < n; n++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        private int NWD(int a, int b)
        {
            int c;
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;

            }
            return a;
        }
    }
}
