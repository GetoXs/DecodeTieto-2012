using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad33
    {
        public int result;
        Number root;
        public void Run()
        {
            Fill();
            result = MinSum(root);
            
        }
        int MinSum(Number n)
        {
            int minSumLeft=0, minSumRight=0;
            if (n.left != null)
            {
                minSumLeft = MinSum(n.left);
                minSumRight = MinSum(n.right);
            }
            return n.n + Math.Min(minSumLeft, minSumRight);
        }
        void Fill()
        {
            string input = @"24
64 58
13 27 97
46 23 73 29
93 86 12 67 91
14 3 16 7 3 24
53 69 14 19 48 59 46
14 79 55 38 69 44 16 19
25 10 58 67 14 32 28 9 7
2 74 65 83 27 16 22 77 59 10";
            string[] rows = input.Split(new string[]{"\r\n"}, StringSplitOptions.None);
            root = new Number()
            {
                n=24,
                i = 0,
                lvl = 0
            };
            FillNumer(root, rows, 0, 0);
        }
        void FillNumer(Number n, string[] rows, int lvl, int leftIndex)
        {
            if (lvl + 1 >= rows.Length)
                return;
            List<int> nextRow = rows[lvl + 1].Split(' ').Select(r=>int.Parse(r)).ToList();
            Number left = new Number()
            {
                n = nextRow[leftIndex],
                lvl = lvl+1,
                i = leftIndex
            };
            Number right = new Number()
            {
                n = nextRow[leftIndex + 1],
                lvl = lvl + 1,
                i = leftIndex + 1
            };
            n.left = left;
            n.right = right;
            FillNumer(left, rows, left.lvl, left.i);
            FillNumer(right, rows, right.lvl, right.i);
        }
        class Number
        {
            public int n;
            public int lvl;
            public int i;
            public Number left = null, right = null;
        }
    }
}
