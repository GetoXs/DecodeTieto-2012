using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad22
    {
        public int result=0;
        public void Run()
        {
            for (int i = 0; i < 1000000; i++)
            {
                if (CheckReq(i)==true)
                    result++;
            }
        }
        bool CheckReq(int number)
        {
            if (number % 3 != 1)
                return false;
            if (number % 4 != 2)
                return false;
            if (number % 5 != 3)
                return false;
            if (number % 6 != 4)
                return false;
            if (number % 7 != 5)
                return false;
            if (number % 8 != 6)
                return false;
            if (number % 9 != 7)
                return false;
            char[] ch = number.ToString().ToCharArray();
            if (ch.Where(c => c == '7').Count() == 0)
                return false;
            return true;
        }
    }
}
