using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad7
    {
        public char result;
        private List<Vertex> graph = new List<Vertex>();
        public void Run()
        {
            Fill();
            int actualId = 1;
            Vertex actualV;
            for (int i = 1; i <= 9999; i++)
            {
                actualV = graph.Where(v => v.Id == actualId).First();
                if (actualV.CheckPredicate(i))
                    actualId = actualV.TrueNextId;
                else
                    actualId = actualV.FalseNextId;
            }
            result = (char)(64 + actualId);

        }
        public void Fill()
        {
            graph.Add(new Vertex()
            {
                Id = 1,
                TrueNextId = 2,
                FalseNextId = 3,
                p = p => p % 2 == 0
            });
            graph.Add(new Vertex()
            {
                Id = 2,
                TrueNextId = 6,
                FalseNextId = 4,
                p = p => p % 3 == 0
            });
            graph.Add(new Vertex()
            {
                Id = 3,
                TrueNextId = 5,
                FalseNextId = 1,
                p = p => p % 7 == 0
            });
            graph.Add(new Vertex()
            {
                Id = 4,
                TrueNextId = 1,
                FalseNextId = 5,
                p = p => p % 4 == 0
            });
            graph.Add(new Vertex()
            {
                Id = 5,
                TrueNextId = 6,
                FalseNextId = 2,
                p = p => p % 5 == 0
            });
            graph.Add(new Vertex()
            {
                Id = 6,
                TrueNextId = 3,
                FalseNextId = 4,
                p = p => p % 6 == 0
            });
        }
        class Vertex
        {
            public int Id;
            public int TrueNextId;
            public int FalseNextId;

            public Predicate<int> p;
            public bool CheckPredicate(int x)
            {
                return p.Invoke(x);
            }
        }
    }
}
