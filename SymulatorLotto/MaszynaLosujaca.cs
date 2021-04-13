using System;
using System.Collections.Generic;
using System.Linq;

namespace SymulatorLotto
{
    class MaszynaLosujaca
    {
        public List<int> ZwolnijMaszyneLosujaca()
        {
            return Enumerable.Range(1, 49).ToList();
        }

        public Losowanie Losuj(List<int> mojeKule, List<int> wszystkieKule)
        {
            Console.WriteLine("Losuje...");

            var wylosowaneKule = new List<int>();
            var trafioneKule = new List<int>();
            var liczbaTrafien = 0;

            var liczbaLosowan = 0;
            var nicNieTrafione = 0;
            var trafionychJedynek = 0;
            var trafionychDwojek = 0;
            var trafionychTrojek = 0;
            var trafionychCzworek = 0;
            var trafionychPiatek = 0;

            while (liczbaTrafien != 6)
            {
                var random = new Random();

                wylosowaneKule = wszystkieKule.OrderBy(x => random.Next()).Take(6).ToList();
                trafioneKule = mojeKule.Intersect(wylosowaneKule).ToList();
                liczbaTrafien = trafioneKule.Count();

                switch (liczbaTrafien)
                {
                    case 0:
                        nicNieTrafione++;
                        break;
                    case 1:
                        trafionychJedynek++;
                        break;
                    case 2:
                        trafionychDwojek++;
                        break;
                    case 3:
                        trafionychTrojek++;
                        break;
                    case 4:
                        trafionychCzworek++;
                        break;
                    case 5:
                        trafionychPiatek++;
                        break;
                }

                liczbaLosowan++;
            }

            return new Losowanie()
            {
                LiczbaLosowan = liczbaLosowan,
                NicNieTrafione = nicNieTrafione,
                TrafionychJedynek = trafionychJedynek,
                TrafionychDwojek = trafionychDwojek,
                TrafionychTrojek = trafionychTrojek,
                TrafionychCzworek = trafionychCzworek,
                TrafionychPiatek = trafionychPiatek,
                TrafioneKule = trafioneKule
            };
        }
    }
}
