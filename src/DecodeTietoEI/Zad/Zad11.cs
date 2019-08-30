using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad11
	{
		public string result = string.Empty;
		private string input;
		public void Run()
		{
			Fill();
			int move = 1;
			char[] chars = input.ToCharArray();
			for (int i = 0; i < input.Length; i++ )
			{
				if (chars[i] != ' ')
				{
					if (move % 2 == 1)
						chars[i] += (char)move;
					else
						chars[i] -= (char)move;
					if (chars[i] > 90)
						chars[i] -= (char)26;
					if (chars[i] < 65)
						chars[i] += (char)26;
				}
				move++;
			}
			result = new string(chars);
		}
		private void Fill()
		{
			input = "PRZYKLADOWE ZDANIE TESTOWE";
		}
	}
}
