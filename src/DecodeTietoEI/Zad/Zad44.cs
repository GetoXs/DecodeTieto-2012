using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad44
	{
		public int result;
		int[] input = { 91, 241, 87, 224, 76, 175, 47, 131, 50, 129, 45, 156, 62, 137, 35, 143, 34, 218, 57, 187, 19, 165, 70, 206, 98, 211, 120, 212, 100, 194, 111, 140, 59, 145, 55, 212, 37, 203, 62, 209, 50, 161, 76, 192, 45, 206, 79, 227, 88, 187, 75, 176, 95, 188, 57, 179, 93, 174, 93, 170, 93, 175, 76, 199, 65, 206, 94, 212, 89, 209, 91 };
		public void Run()
		{
			int lastIn = input[0];
			int[] decoded = new int[input.Length];
			for (int i = 1; i < input.Length; i++)
			{
				decoded[i] = input[i] ^ lastIn;
				decoded[i] ^= 0xC3;
				lastIn = input[i];
			}
			char[] chs = decoded.Select(i => (char)i).ToArray();
			result = 0xC3 ^ 'T' ^ 91;
		}
	}
}
