using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad27
    {
        public int result=0;
        public void Run()
        {
            DateTime dt = new DateTime(2012, 01, 01);
            while (dt < new DateTime(2365, 01, 01))
            {
                if (dt.Day == 13 && dt.DayOfWeek == DayOfWeek.Friday)
                    result++;
                dt = dt.AddDays(1);
            }
        }
    }
}
