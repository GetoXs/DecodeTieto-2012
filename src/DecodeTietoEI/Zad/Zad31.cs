using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad31
	{
		public int result=0;
		public void Run()
		{
			for (int i = -300; i <= 50200; i++)
			{
				if (i == 0)
					continue;
				int sumEven = 0, sumOdd = 0;
				string num = i.ToString();
				foreach (char ch in num)
				{
					if (ch == '-')
						continue;
					if (int.Parse(ch.ToString()) % 2 == 0)
						sumEven += int.Parse(ch.ToString());
					else
						sumOdd += int.Parse(ch.ToString());
				}
				if (sumOdd != 0 && sumEven != 0 &&
					(i % sumEven == 0) && (i % sumOdd == 0))
					result++;
			}
		}
	}
}
