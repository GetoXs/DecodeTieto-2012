using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad42
    {
        public int result = 0;
        public void Run()
        {
            int counter=0;
            for (int i = 1999999; i > 1; i--)
            {
                if (isPrime(i))
                {
                    counter++;
                    result+=i; 
                    if (counter == 10)
                        break;
                }
            }
        }
        bool isPrime(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
