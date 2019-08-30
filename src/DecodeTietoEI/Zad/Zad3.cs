using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad3
    {
        public int result=0;
        private List<uint> primaryNumbers = new List<uint>();
        public void Run()
        {
            primaryNumbers.Add(5);
            primaryNumbers.Add(7);
            primaryNumbers.Add(11);
            primaryNumbers.Add(13);

            int start = 1000;
            int finish = 1000000;

            for (int n = start; n <= finish; n++)
            {
                foreach (var prim in primaryNumbers)
                {
                    if(n%prim!=0)
                        goto dalej;
                }
                result++;
            dalej: ;
            }
        }
    }
}
