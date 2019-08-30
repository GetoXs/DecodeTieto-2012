using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
	class Zad34
	{
		public int result=0;
		List<string> words;
		public void Run()
		{
			Fill();
			for (int f = 0; f < words.Count - 1; f++)
			{
				for (int s = f + 1; s < words.Count; s++)
				{
					var dF = CalculateChars(words[f]);
					var dS = CalculateChars(words[s]);
					dF.OrderBy(c => c.Key);
					dS.OrderBy(c => c.Key);
					foreach(var c in dF)
					{
						if(!dS.ContainsKey(c.Key))
							goto next;
						if(dS[c.Key] != c.Value)
							goto next;
					}
					result++;
				next: ;
				}
			}
		}
		Dictionary<char, int> CalculateChars(string word)
		{
			Dictionary<char, int> dict = new Dictionary<char,int>();
			foreach (char ch in word)
			{
				if (dict.ContainsKey(ch))
				{
					dict[ch]++;
				}
				else
					dict.Add(ch, 1);
			}
			return dict;
		}
		void Fill()
		{
			string input = @"wnwjfznwtdpyjsgnjctuwcnjcmltrr
abrfxjlrminpgpdqamzlejbqbpwkwu
iamxtlpgrkepvatjqernodzyfajqqc
vwrplefmvyjaxgmzffehpkkzlabdfs
lubcmjxhqnyfbggqqyezdrrmepgdxy
tfuhzgwxckkbnfbxqlknkskmykbatp
cbpoewhgmrrryuqhrwettutvfgmadb
chvowthqjoclzlntlckwkvebcbiazw
exuelwjpzunxvkbcrxzhzcphqtjpck
tsamxawsmbysxurfbgbyjiluzkattv
aullubmyzsyxcujqrepftsaivrdrhn
guqfqozvbwpvrbtafpjqjjqdswgbui
fvriwvnzavfmdvrggsqwhccztkzgcv
wzfdlrkpkeczwcrwynzqvrjfvdxqsx
smlwbugaitzkmfrubtayaxyjxtvbss
jbnzieewdhgxozbujbgxgodtdhabsb
pdxvekfbfwzdtcgyltibkgwalpcvph
vnrlguacvfsnlnwfayiqgxvvyggbjs
cmclznhwslbnmgyjiyifazihkanxbk
zmxqcugiyedjsdpedxqzxpeqhullsq
kjlblbrmjpwawzfmrpnixbuagdqpqe
ilfojkjojqlyovkmimpoeuppgehrzx
cwngyktfmxnkxktfbqazhlkubpkbks
iyrsjhdcjxdylzdswfmtlqsxkxhuwx
ayhbmvxpwgrcibonvlqskslaopiorj
sdcxjzehullxudqpqsmyzqxeqeipgd
tvujrycdvowqcbetzfmotuindzmhwo
efmrnqvoyjatpdapictglzqaxeqjrk
vxefloeoeihavcctnhluldhltxwunt
jrnnhtvflhjxdhqwnanaqolbqzvbcd
ulenjzngttgnvqpzkzihovnpzasfyf
bmlvzydmemqpmmqennvaybtrevfqnc
duqeiottbxebtznflpbbfofkzwrlgi
oahtvwumpgtmdqhwytrfrbubceergr
zngnnzvgsiptnyfeuhapzvkzjloftq
vtzmlvymecvqmmrnqeypmdfbqanbne
mulhkelxeatgqxfemrntnpaqnyzlet
hzclbyfzqaxqaovcvjcbgzrhmlpwhy
dqljywdyjudytsuvogkigkubqsfoku
xivjfuavhmmagvmqdavmhmzesaopkt
hnewmdjbhwccsuokvkwyoyalfkbmcv
cbhjzvrtwzyutwvomotfdqucmedion
pqgijkxzjuoplofooepmrhjyivklme
ohawmsjtpxopgjoqfggjgcuisxdqyp
cdkxkdroldsnsclpgbehkvdkiqqhdf
fdvsscqnkcfwgjudsvabhwycjvmjns
ccwlbtchklkvoeotwavzichlwjznbq
rhdixxyjruocovptmfcmuwkiufwxys
hzhxzxejuccrekcpxunpztjkqlwbvp
ybkjwuvspygauntjzcceqbscmiuukl
yzhporvmmuapgknvzcoppriktstmeg
rlxlptcmfjbdrysrvqnuuzsahyaieu
pjnctvujccwiqmuseagublzkbkuysy
wlcsvgjnfvsaynnqgxfagvulrivybg
pigjctnjmgbfaekswoaeibgdpxapvm
piifqthtvjynejkeiatczqzfnjcexf
zsvivrckmkpnygpztremaugmopopht
pooqftqigxupwjxgcgpdayjgsmhjos
szgiuwvvjpqpaqdqoqrfjbfgbjwutb
vxsoabngsrvcioarlhjomiwlbpykqp";
			string[] tab = input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			words = new List<string>(tab);
		}
	}
}
