using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DecodeTietoEI.Zad
{
    class Zad1
    {
        private List<uint> history;
        public int result = 0;
        private uint NextStep(uint actualNumber)
        {
            string strActualN = actualNumber.ToString();
            uint result = 0;
            //List<uint> resultList = new List<uint>(strActualN.Length + 1);
            uint digit;
            for(int i=0; i<strActualN.Length; i++)
            {
                digit = uint.Parse(strActualN[i].ToString());
                //resultList[i] = (uint)digit * digit;
                result += digit * digit;
            }
            return result;
        }
        private bool CheckHistoryDuplicate(uint actualNumer)
        {
            int count = history
                .Where(h => h == actualNumer)
                .Count();
            if (count > 0)
                return true;
            return false;
        }
        public void Run()
        {
            uint start = 4563;
            uint finish = 89450;
            bool isDupe;
            for (uint n = start; n <= finish; n++)
            {

                if (history != null)
                    history.Clear();
                history = new List<uint>();
                uint res = n;
                isDupe = false;
                do{
                    
                    res = NextStep(res);
                    isDupe = CheckHistoryDuplicate(res);
                    history.Add(res);
                }while(res!=1 && isDupe==false);
                if (res == 1)
                    result++;
            }
        }
    }
}
