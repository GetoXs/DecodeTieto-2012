using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad30
	{
		public string result = string.Empty;
		string[] words;
		List<int> sums = new List<int>();
		public void Run()
		{
			Fill();
			for (int f = 0; f < words.Length - 1; f++)
			{
				for (int s = f + 1; s < words.Length; s++)
				{
					if (words[f] == words[s])
						continue;
					int asciiF = words[f].Select(c => (int)c).Sum();
					int asciiS = words[s].Select(c => (int)c).Sum();
					if (asciiF == asciiS)
						sums.Add(asciiS);
				}
			}
			sums.Sort();
			foreach(var s in sums)
			{
				result += s.ToString() + ",";
			}
		}
		void Fill()
		{
			string input = @"Computer programming is the iterative process of writing or editing source code. Editing source code involves testing, analyzing, and refining, and sometimes coordinating with other programmers on a jointly developed program.
A person who practices this skill is referred to as a computer programmer, software developer or coder. The sometimes lengthy process of computer programming is usually referred to as software development.
The term software engineering is becoming popular as the process is seen as an engineering discipline.";
			words = input.Split(new char[] { ',', '.', '\r', '\n', ' '}, StringSplitOptions.RemoveEmptyEntries);
		}
	}
}
