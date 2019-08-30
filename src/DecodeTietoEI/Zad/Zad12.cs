using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad12
    {
        public int result;
        List<int> matrix;
        public void Run()
        {
            int _x = 450;
            int _y = 250;
            int step = 6;
            int lastStep;
            matrix = new List<int>(_x * _y);
            lastStep = 0;
            int lastV=11;
            matrix.Add(lastV);
            for (int i = 1; i <= _x * 145 + 422; i++)
            {
                matrix.Add(lastV + lastStep);

                lastStep++;
                if (lastStep > step)
                    lastStep = 0;
                lastV = matrix[i];
            }
            result = lastV;

        }
    }
}
