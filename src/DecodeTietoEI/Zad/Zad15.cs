using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad15
    {
        public int result = 0;
        public void Run()
        {
            NextJump(0, 2);
        }
        void NextJump(int currPos, int prevJump)
        {
            if (currPos > 50)
                return;
            else if (currPos == 50)
                result++;
            for (int i = prevJump; i <= 10; i++)
            {
                NextJump(currPos + i, i);
            }
        }
    }
}
