using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad16
    {
        public int result=0;
        public void Run()
        {
            for (int i = 1000; i < 100000; i++)
            {
                string hex = i.ToString("X");
                int cnt = hex
                    .Where(c => c == '1')
                    .Count();
                if (cnt == 3)
                    result++;
            }
        }
    }
}
