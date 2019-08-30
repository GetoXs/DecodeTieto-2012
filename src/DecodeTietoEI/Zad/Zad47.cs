using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad47
	{
		public int result=0;
		public void Run()
		{
			DateTime dt = new DateTime(2000, 12, 31, new System.Globalization.GregorianCalendar());
			DateTime comp = new DateTime(3000,12,31);
			while(dt <= comp)
			{
				if (DateTime.IsLeapYear(dt.Year))
				{
					if (dt.Day == 13 && dt.DayOfWeek == DayOfWeek.Friday)
					{
						result++;
					}
					dt = dt.AddDays(1);
				}
				else
				{
					dt = dt.AddYears(1);
				}
			}
		}
	}
}
