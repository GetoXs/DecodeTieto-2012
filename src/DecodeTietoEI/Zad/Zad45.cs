using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace DecodeTietoEI.Zad
{
    class Zad45
    {
        public string result;
        public void Run()
        {
            BigInteger sum = 0;
            List<Sixty> number = new List<Sixty>();
            number.Insert(0, new Sixty() { digit = 1 });
            List<Sixty> finish = new List<Sixty>();
            finish.Add(new Sixty() { digit = 5 });
            finish.Add(new Sixty() { digit = 1 });
            finish.Add(new Sixty() { digit = 1 });
            finish.Add(new Sixty() { digit = 1 });
            finish.Add(new Sixty() { digit = 1 });
            do
            {
                int mul = 1;
                for (int i = 0; i < number.Count; i++)
                {
                    mul *= number[i].digit;
                }
                sum += mul;
                IncrementSixty(number);
            }
            while (!IsEqual(number, finish));
            result = sum.ToString().Substring(0, 5);
        }
        bool IsEqual(List<Sixty> number, List<Sixty> eq)
        {
            if(number.Count!=eq.Count)
                return false;
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i].digit != eq[i].digit)
                    return false;
            }
            return true;
        }
        void IncrementSixty(List<Sixty> number)
        {
            bool isPrzeniesienie = false;
            for (int i = number.Count - 1; i >= 0; i--)
            {
                if (number[i].digit != 59)
                {
                    number[i].digit++;
                    isPrzeniesienie = false;
                    break;
                }
                else
                {
                    isPrzeniesienie = true;
                    number[i].digit = 0;
                }
            }
            if (isPrzeniesienie)
            {
                number.Insert(0, new Sixty() { digit = 1 });
            }
        }
        BigInteger From60To10(List<Sixty> number)
        {
            BigInteger sum = 0;
            for (int i = number.Count - 1, st=0; i >= 0; i--, st++)
            {
                sum += number[i].digit * (int)Math.Pow(60, st);
            }
            return sum;
        }
        class Sixty
        {
            public int digit;
        }
    }
}
