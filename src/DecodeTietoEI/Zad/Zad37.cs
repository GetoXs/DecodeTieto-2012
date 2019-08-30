using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad37
	{
		public string result;
		public void Run()
		{
			HashSet<int> sumHash = new HashSet<int>(); ;
			int count = 0;
			for (int i = 1; i <= 1000000; i++)
			{
				string num = i.ToString();
				char[] rev = num.ToCharArray();
				for (int j = 0; j < num.Length; j++)
				{
					int end = num.Length - j - 1;
					if (end <= j)
						break;
					rev[j] = num[end];
					rev[end] = num[j];
				}
				string revS = new string(rev);
				string sum = (int.Parse(revS) + int.Parse(num)).ToString();
				foreach (char c in sum)
				{
					if (int.Parse(c.ToString()) % 2 != 0)
						goto nextNum;
				}
				count++;
				sumHash.Add(int.Parse(revS) + int.Parse(num));
			nextNum: ;
			}
			result = count.ToString() + "," + sumHash.Count.ToString();
		}
	}
}
