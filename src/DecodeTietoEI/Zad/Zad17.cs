using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecodeTietoEI.Zad
{
    class Zad17
    {
        public int result=0;
        List<Package> packs;
        List<Package> lorryPacks = new List<Package>();
        public void Run()
        {
            Fill();
            int currW = 0;
            int currC = 0;
            Package p;
            while (currW <= 250)
            {
                p = GetOptimal();

                if (currW + p.Weight <= 250)
                {
                    currW += p.Weight;
                    lorryPacks.Add(p);
                    currC += p.Charge;
                }
                else
                {
                    var pW = packs
                        .Where(p1 => p1.Weight == 250-currW && lorryPacks.Contains(p1) == false)
                        .OrderByDescending(p1 => p1.Charge)
                        .Take(1)
                        .FirstOrDefault();
                    currW += pW.Weight;
                    currC += pW.Charge;
                }
            }
            result = currC;

            //NextPackage(0, 0, -1);
        }
        void NextPackage(int CurrentCharge, int CurrentWeight, int prevId)
        {
            if (CurrentWeight > 250)
                return;
            if (CurrentCharge > result)
                result = CurrentCharge;
            for (int i = prevId + 1; i < 100; i++)
            {
                NextPackage(CurrentCharge + packs[i].Charge, CurrentWeight + packs[i].Weight, i);
            }

        }
        Package GetOptimal()
        {
            double bestRatio = 0;
            Package bestPackage = null;
            for (int i = 1; i <= 13; i++)
            {
                var pW = packs
                    .Where(p => p.Weight == i && lorryPacks.Contains(p) == false)
                    .OrderByDescending(p=>p.Charge)
                    .Take(1)
                    .FirstOrDefault();

                if (pW != null)
                {
                    if ((double)pW.Charge / pW.Weight > bestRatio)
                    {
                        bestRatio = (double)pW.Charge / pW.Weight;
                        bestPackage = pW;
                    }
                }
            }
            return bestPackage;
        }
        void Fill()
        {
            packs = new List<Package>(100);
            for (int i = 1; i <= 100; i++)
            {
                packs.Add(new Package()
                {
                    Id = i,
                    Weight = (i % 11) + 1,
                    Charge = (i % 13) + 1
                });
            }
        }
        class Package:IEquatable<Package>
        {
            public int Id, Weight, Charge;

            public bool Equals(Package other)
            {
                if (other.Id == this.Id)
                    return true;
                else
                    return false;
            }
        }
    }
}
