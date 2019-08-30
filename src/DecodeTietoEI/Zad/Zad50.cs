using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace DecodeTietoEI.Zad
{
	class Zad50
	{
		public int result=10;
		public void Run()
		{
			BigInteger lastT1 = 2, lastT2 = 1, lastT3 = 1;
			BigInteger lastF1 = 2, lastF2 = 1, lastF3 = 1;
			BigInteger fib;
			BigInteger trib;
			for (int i = 4; i <= 40; i++)
			{
				fib = lastF1 + lastF2;
				trib = lastT1 + lastT2 + lastT3;
				BigInteger nwd = NWD(fib, trib);
				if (nwd > result)
					result = (int)nwd;
				lastF3 = lastF2;
				lastF2 = lastF1;
				lastF1 = fib;

				lastT3 = lastT2;
				lastT2 = lastT1;
				lastT1 = trib;
			}

		}
		BigInteger NWD(BigInteger a, BigInteger b)
		{
			BigInteger c;
			while (b != 0)
			{
				c = a % b;
				a = b;
				b = c;

			}
			return a;
		}
	}
}
