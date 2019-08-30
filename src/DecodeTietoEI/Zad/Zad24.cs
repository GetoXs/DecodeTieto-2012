using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad24
	{
		public int result=0;
		public void Run()
		{
			Queue<int> fifo;
			for (int n = 10; n <= 999999; n++)
			{
				string str = n.ToString();
				fifo = new Queue<int>();
				foreach (char c in str)
				{
					fifo.Enqueue(int.Parse(c.ToString()));
				}
				int sum = fifo.Sum();
				while (sum < n)
				{
					sum = fifo.Sum();
					fifo.Dequeue();
					fifo.Enqueue(sum);
				}
				if (sum == n)
				{
					result++;
				}
			}
		}
	}
}
