using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad40
    {
        public int result=0;
        public void Run()
        {
            for (int i = 100000; i < 1000000; i++)
            {
                if(IsPalindrom(i))
                    result++;
            }
        }
        bool IsPalindrom(int n)
        {
            string str = n.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                int end = str.Length - i -1;
                if (i == end)
                {
                    break;
                }
                if (str[i] != str[end])
                    return false;
            }
            return true;
        }
    }
}
