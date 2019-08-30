using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad9
    {
        public int result=0;
        private uint[] input;
        public void Run()
        {
            Fill();
            foreach (var num in input)
            {
                byte[] numB = BitConverter.GetBytes(num);
                for(int i=0; i<4; i++)
                {
                    //byte[] letB = numB.Skip(i*8).Take(8).ToArray();
                    //int let = BitConverter.ToInt32(letB, 0);
                    int let = numB[i];
                    if (let >= (int)'I' && let <= (int)'U')
                        result++;
                }
            }
        }
        public void Fill()
        {
            input = new uint[] { 1364476232, 1129601601, 1128613712, 1447510359, 1179861337, 1178686549, 1096439881, 1380341577, 1229078855, 1397113431 };

        }
    }
}
