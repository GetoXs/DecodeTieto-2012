using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad20
    {
        public string result;
        List<int> resultList = new List<int>();
        public void Run()
        {
            for (int i = 2; i < 100000; i++)
            {
                if (isPrime(i))
                {
                    string sNum = i.ToString();
                    char[] cNum = sNum.ToCharArray();
                    bool isPalindrom = true;
                    for (int x = 0; x < cNum.Length; x++)
                    {
                        int xe = cNum.Length - x - 1;
                        if (xe == x)
                            break;
                        if (cNum[x] != cNum[xe])
                            isPalindrom = false;
                    }
                    if (isPalindrom)
                        resultList.Add(i);
                }
            }
            resultList.Sort();
            result = resultList.Count.ToString() + ", " + resultList[63].ToString();




            //char[] number;
            //for (int i = 1; i <= 5; i++)
            //{
            //    number = new char[i];
            //    for (int start = 0; start < Math.Round((double)i / 2); start++)
            //    {
            //        int end = (int)Math.Round((double)i / 2)-1;

            //    }
            //}
        }
        bool isPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
