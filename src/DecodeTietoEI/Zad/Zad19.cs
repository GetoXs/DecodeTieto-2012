using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad19
    {
        public int result=0;
        public List<int> primaryList = new List<int>();
        public Dictionary<int, int> dictSum = new Dictionary<int, int>();
        public void Run()
        {
            Fill();
            for (int first = 4; first < 1000000; first+=4)
            {
                if (first == 8)
                {
                    //sumHistory.Sort(new KVComparer());
                }
                for (int second = 4; second < 1000000; second+=4)
                {
                    if (SumDivisors(second) == first && SumDivisors(first) == second)
                    {
                        result++;
                    }
                }
            }
        }
        int SumDivisors(int number)
        {
            if (dictSum.ContainsKey(number))
            {
                return dictSum[number];
            }
            int sum = 1;
            int curr = number;
            List<int> prims = new List<int>();
            int buff;
            while (curr != 1)
            {
                for (int i = 0; i < primaryList.Count; i++)
                {
                    buff = primaryList[i];
                    if (curr % buff == 0)
                    {
                        prims.Add(primaryList[i]);
                        curr /= buff;
                        break;
                    }
                }
            }
            List<int> primsD = prims.Distinct().ToList();
            for (int i = 0; i < primsD.Count; i++)
            {
                sum *= (int)(Math.Pow(primsD[i], prims.Where(p => p == primsD[i]).Count() + 1) - 1) / (primsD[i] - 1);
            }
            sum -= number-1;
            dictSum.Add(number, sum);
            return sum;
        }
        void Fill()
        {
            for (int i = 2; i <= 250000; i++)
            {
                for(int j=2; j<=Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                        goto nast;
                }
                primaryList.Add(i);
            nast: ;
            }
        }
        class KVComparer: IComparer<KeyValuePair<int, int>>
        {

            public int Compare(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
            {
                return x.Key.CompareTo(y.Key);
            }
        }
    }
}
