using System;

namespace SymulatorLotto
{
    class Program
    {
        static void Main(string[] args)
        {
            var prowadzacy = new Prowadzacy();
            var maszynaLosujaca = new MaszynaLosujaca();

            prowadzacy.PrzywitajGoscia();

            var mojeKule = prowadzacy.PoprosOWybranieSzesciuKul();
            Console.WriteLine("Twoje kule:");
            mojeKule.ForEach(Console.WriteLine);

            var wszystkieKule = maszynaLosujaca.ZwolnijMaszyneLosujaca();
            var losowanie = maszynaLosujaca.Losuj(mojeKule, wszystkieKule);

            prowadzacy.PodajWynikiLosowania(losowanie);
        }
    }
}