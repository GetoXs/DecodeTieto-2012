using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace DecodeTietoEI.Zad
{
    class Zad21
    {
        public int result=0;
        public List<int> primeNumbers;
        public void Run()
        {
            Fill();
            BigInteger current = 1;
            BigInteger last = 0, prelast = 0;
            for (int i = 2; i <= 1000; i++)
            {
                if (IsDiv(current))
                    result++;

                prelast = last;
                last = current ;
                //buff = current;
                current = last + prelast;
            }
        }
        bool IsDiv(BigInteger number)
        {
            string str = number.ToString();
            char[] ch = str.ToCharArray();

            foreach (int p in primeNumbers)
            {
                if (number % (BigInteger)p != 0)
                    return false;
            }
            return true;
        }
        void Fill()
        {
            primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
        }
    }
}
