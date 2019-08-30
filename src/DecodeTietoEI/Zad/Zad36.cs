using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad36
    {
        public string result;
        List<string> nums;
        public void Run()
        {
            Fill();
            nums.Sort(new WeirdComparer());
            result = nums[46];
        }
        void Fill()
        {
            string input = @"574, 7114, 37, 53216, 9326, 706, 4205, 91124, 65720, 34, 21413, 89, 29, 4080, 01234, 69, 90, 1300, 13, 85, 17723, 1193, 40883, 3177, 75228, 0925, 07545, 3741, 32021, 5509, 28, 63, 49, 2894, 89683, 254, 5923, 673, 7271, 65, 249, 65932, 14123, 3309, 27, 165, 62, 89393, 5231, 47693, 977, 9614, 24557, 6547, 13613, 23, 909, 35353, 29232, 33, 39194, 181, 765, 382, 19, 08, 65, 77778, 44, 999, 0551, 8146, 6479, 95292, 22, 54706, 967, 0082, 484, 44, 83391, 6373, 76, 8689, 6792, 5162, 36, 85, 5485, 676, 016, 33, 03435, 01502, 24, 140, 7428, 93391, 1967, 7134";
            nums = input.Split(new string[] { ", " }, StringSplitOptions.None).ToList();

        }
        class WeirdComparer : IComparer<string>
        {
            int[] comp = new int[] { 5, 3, 1, 7, 0, 2, 9, 8, 4, 6 };
            public int Compare(string x, string y)
            {
                string f = x.ToString();
                string s = y.ToString();
                if (f.Length != s.Length)
                {
                    return f.Length.CompareTo(s.Length);
                }
                for (int i = 0; i < f.Length; i++)
                {
                    char c1 = f[i];
                    char c2 = s[i];
                    int iF = comp.ToList().IndexOf(int.Parse(c1.ToString()));
                    int iS = comp.ToList().IndexOf(int.Parse(c2.ToString()));
                    if (iF != iS)
                    {
                        return iF - iS;
                    }
                }
                return 0;
            }
        }
    }
}
