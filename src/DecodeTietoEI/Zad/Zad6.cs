using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad6
    {
        public int result;
        private List<Player> players = new List<Player>();
        public void Run()
        {
            Fill();
            int max_res = int.MinValue;
            for (int i=0; i<players.Count; i++)
            {
                Player p1 = players[i];
                for (int j = i; j < players.Count; j++ )
                {
                    Player p2 = players[j];
                    for (int k = j; k < players.Count; k++)
                    {
                        Player p3 = players[k];
                        int r = CalcRating(p1, p2, p3);
                        if (r > max_res)
                        {
                            result = 1;
                            max_res = r;
                        }
                        else if (r == max_res)
                        {
                            result++;
                        }
                    }
                }
            }
        }
        private int CalcRating(Player p1, Player p2, Player p3)
        {
            int r=0;
            r = p1.Rating + p2.Rating + p3.Rating;
            if (p1.E1PlayerNo == p2.Number || p1.E1PlayerNo == p3.Number)
                r -= p1.E1Rating;
            if (p1.E2PlayerNo == p2.Number || p2.E2PlayerNo == p3.Number)
                r -= p1.E2Rating;

            if (p2.E1PlayerNo == p1.Number || p2.E1PlayerNo == p3.Number)
                r -= p2.E1Rating;
            if (p2.E2PlayerNo == p1.Number || p2.E2PlayerNo == p3.Number)
                r -= p2.E2Rating;

            if (p3.E1PlayerNo == p1.Number || p3.E1PlayerNo == p1.Number)
                r -= p3.E1Rating;
            if (p3.E2PlayerNo == p1.Number || p3.E2PlayerNo == p1.Number)
                r -= p3.E2Rating;
            return r;
        }
        private void Fill()
        {
            players.Add(new Player(0,2,2,-1,5,-3));
            players.Add(new Player(1,6,3,1,9,-1));
            players.Add(new Player(2,4,8,2,6,-2));
            players.Add(new Player(3,3,5,1,3,4));
            players.Add(new Player(4,8,1,2,2,-4));
            players.Add(new Player(5,7,7,-2,3,-1));
            players.Add(new Player(6,5,9,2,8,-1));
            players.Add(new Player(7,9,6,-3,5,-4));
            players.Add(new Player(8,6,9,-1,4,3));
            players.Add(new Player(9,5,3,3,10,-1));
            players.Add(new Player(10,9,7,-2,2,3));
            players.Add(new Player(11,6,1,2,7,1));

        }
        class Player
        {
            public int Number;
            public int Rating;
            public int E1PlayerNo;
            public int E1Rating;
            public int E2PlayerNo;
            public int E2Rating;
            public Player(int n, int r, int e1p, int e1r, int e2p, int e2r)
            {
                Number = n;
                Rating = r;
                e1p = E1PlayerNo;
                e1r = E1Rating;
                e2p = E2PlayerNo;
                e2r = E2Rating;
            }
        }

    }
}
