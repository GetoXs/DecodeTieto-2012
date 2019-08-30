using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad23
    {
        public string result;
        List<int> primes;
        public void Run()
        {
            primes = new List<int>();
            for (int i = 2; i < 1e7; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++ )
                {
                    if (i % j == 0)
                        goto next;

                }
                primes.Add(i);
            next:;
            }
            long sum = 0;
            foreach (int n in primes)
            {
                sum += n;
            }
            result = sum.ToString().Substring(sum.ToString().Length - 2);
        }

    }
}
