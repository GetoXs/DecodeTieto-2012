using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad39
    {
        public int result=0;
        int[,] grid = new int[50, 50];
        public void Run()
        {
            Fill();
            for (int i = 0; i < 50; i++)
            {
                result += grid[i, i];
            }
        }
        void Fill()
        {
            bool nextPlus10=false;
            int counter = 0;
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (isPrime(i+1) && isPrime(j))
                    {
                        counter += 10;
                    }
                    else
                        counter++;
                    grid[i, j] = counter;

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
