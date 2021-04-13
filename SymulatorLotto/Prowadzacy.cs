using System;
using System.Collections.Generic;

namespace SymulatorLotto
{
    class Prowadzacy
    {
        public List<int> PoprosOWybranieSzesciuKul()
        {
            var mojeKule = new List<int>();
            for (int i = 0; i < 6; i++)
            {
            COFNIJ:
                Console.WriteLine($"Wprowadz {i + 1} kulę: ");
                var wprowadzonaWartoscJestNumerem = int.TryParse(Console.ReadLine(), out int wprowadzonaKula);

                if (wprowadzonaWartoscJestNumerem == false)
                {
                    Console.WriteLine($"Wprowadzona kula nie jest numerem. Proszę wybierz kulę w zakresie od 1 do 49.");
                    goto COFNIJ;
                }

                if (mojeKule.Contains(wprowadzonaKula))
                {
                    Console.WriteLine($"Kula o numerze: {wprowadzonaKula} została już wprowadzona. Proszę wybierz inny numer.");
                    goto COFNIJ;
                }

                if (wprowadzonaKula < 1 || wprowadzonaKula > 49)
                {
                    Console.WriteLine($"Proszę wybierz kulę w zakresie od 1 do 49.");
                    goto COFNIJ;
                }

                mojeKule.Add(wprowadzonaKula);
            }

            return mojeKule;
        }

        public void PodajWynikiLosowania(Losowanie losowanie)
        {
            Console.WriteLine($"Trafiono ani razu: {losowanie.NicNieTrafione} razy.");
            Console.WriteLine($"Trafiono jedynke: {losowanie.TrafionychJedynek} razy.");
            Console.WriteLine($"Trafiono dwojke: {losowanie.TrafionychDwojek} razy.");
            Console.WriteLine($"Trafiono trojke: {losowanie.TrafionychTrojek} razy.");
            Console.WriteLine($"Trafiono czworke: {losowanie.TrafionychCzworek} razy.");
            Console.WriteLine($"Trafiono piatke: {losowanie.TrafionychPiatek} razy.");

            Console.WriteLine($"Trafiono 6stke po: {losowanie.LiczbaLosowan} losowaniach.");
            Console.WriteLine($"Twoje wygrywajace liczby Lotto => { string.Join(", ", losowanie.TrafioneKule)}");
        }

        public void PrzywitajGoscia()
        {
            Console.WriteLine("Program symuluje rozgrywkę Lotto. Po wybraniu 6sciu liczb, bedzie wybieral losowe liczby tak dlugo, az trafi te, ktore Ty wybrales.");
            Console.WriteLine("Dowiesz się dzięki temu po ilu hipotetycznych losowaniach udaloby Ci sie trafic 6stke w Lotto!");
        }
    }
}
