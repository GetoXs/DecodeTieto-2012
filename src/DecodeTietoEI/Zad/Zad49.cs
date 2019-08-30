using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad49
	{
		public string result;
		bool[] locker;
		public void Run()
		{
			locker = new bool[10000001];
			for (int i = 0; i < locker.Length; i++)
				locker[i] = false;
			for (int iter = 1; iter <= 1000000; iter++)
			{
				for (int i = iter; i < locker.Length; i += iter)
				{
					if (locker[i] == true)
						locker[i] = false;
					else
						locker[i] = true;
				}
			}
			result = boolToChar(locker[999]) + "," + boolToChar(locker[23314]) + "," + boolToChar(locker[100200]) + "," + boolToChar(locker[678343]) + "," + boolToChar(locker[1000000]);
		}
		char boolToChar(bool b)
		{
			return b.ToString().ToCharArray()[0];
		}
	}
}
