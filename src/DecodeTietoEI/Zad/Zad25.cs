using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad25
	{
		public string result;
		public void Run()
		{
			int count5 = 0;
			int countBin = 0;
			for (int num = 1; num <= 1000000; num++)
			{
				string str = num.ToString();
				if (str.Where(c => c == '5').Count() == 3)
				{
					count5++;
					int cond = num;
					int counter = 0;
					while (cond != 0)
					{
						if ((cond & 0x01) == 1)
						{
							counter++;
						}
						cond = cond >> 1;
					}
					if (counter == 4 || counter == 6)
						countBin++;
				}
			}
			result = count5.ToString() + "," + countBin.ToString();
		}
	}
}
