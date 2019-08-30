using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad8
    {
        public int result=0;
        private short[,] windmill;
        private short[,] lastW;
        public void Run()
        {
            Fill();
            while (IsSameDirection() == false)
            {
                lastW = (short[,])windmill.Clone();
                result++;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        CheckChanges(i, j);
                    }
                }
            }

        }
        private int CheckChanges(int _i, int _j)
        {
            int count = 0;
            short actual = lastW[_i, _j];
            int cntOpp=0;
            if (_i > 0)
            { 
                count++;
                if (actual != lastW[_i - 1, _j])
                    cntOpp++;
            }
            if (_i < 9)
            {
                count++;
                if (actual != lastW[_i+1, _j])
                    cntOpp++;
            }
            if (_j > 0)
            {
                count++;
                if (actual != lastW[_i, _j-1])
                    cntOpp++;
            }
            if (_j < 9)
            {
                count++;
                if (actual != lastW[_i, _j+1])
                    cntOpp++;
            }
            if (_i > 0 && _j > 0)
            {
                count++;
                if (actual != lastW[_i-1, _j - 1])
                    cntOpp++;
            }
            if (_i < 9 && _j < 9)
            {
                count++;
                if (actual != lastW[_i+1, _j + 1])
                    cntOpp++;
            }
            if (_i > 0 && _j < 9)
            {
                count++;
                if (actual != lastW[_i-1, _j + 1])
                    cntOpp++;
            }
            if (_i < 9 && _j > 0)
            {
                count++;
                if (actual != lastW[_i+1, _j - 1])
                    cntOpp++;
            }
            if ((double)cntOpp / count > 0.5)
            {
                windmill[_i, _j] += 1;
                windmill[_i, _j] &= 1;
                return 1;
            }
            return 0;
        }
        private bool IsSameDirection()
        {
            short last = windmill[0, 0];
            for (int i = 0; i < windmill.GetLength(0); i++)
                for (int j = 0; j < windmill.GetLength(0); j++)
                    if (last != windmill[i, j])
                        return false;
            return true;
        }
        private void Fill()
        {
            windmill = new short[10,10] 
                {{1, 1, 1, 1, 1, 1, 0, 0, 1, 0},
                {1, 0, 0, 0, 1, 0, 1, 1, 1, 1},
                {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
                {0, 1, 1, 0, 1, 1, 0, 1, 0, 1},
                {1, 0, 0, 1, 1, 1, 0, 1, 0, 1},
                {0, 1, 0, 0, 0, 1, 0, 0, 1, 0},
                {0, 1, 0, 1, 1, 1, 0, 0, 1, 0},
                {0, 0, 0, 1, 1, 1, 0, 1, 0, 0},
                {0, 1, 0, 1, 1, 1, 0, 1, 1, 1},
                {0, 0, 1, 0, 0, 0, 0, 0, 0, 1}};
        }
    }
}
