using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DecodeTietoEI.Zad
{
	class Zad46
	{
		public string result;
		public void Run()
		{
			int sumInt=0, sumC=0;
			for (int i = 1234; i <= 5678; i++)
			{
				string hex = i.ToString("X");
				hex = hex.ToLower();
				foreach (char c in hex)
				{
					if (c > 96)
					{
						sumC += c;
					}
					else if (c >= 48 && c <= 57)
					{
						sumInt += int.Parse(c.ToString());
					}
					else
						MessageBox.Show("blad");
				}
			}
			result = sumInt.ToString() +","+sumC.ToString();
		}
	}
}
