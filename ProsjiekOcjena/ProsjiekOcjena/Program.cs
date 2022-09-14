using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsjiekOcjena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Varijable
            double ocjena, zbrojOcjena = 0, brojOcjena = 0, prosjekOcjena = 0;

            // Zaglavalje aplikacije
            Console.WriteLine("##############################");
            Console.WriteLine("#   Izračunavanje prosjeka   #");
            Console.WriteLine("##############################");
            Console.WriteLine("Za Kraj unesi nulu.");

            // Unos Ocjena
            do
            {
                Console.WriteLine("Unesi ocjenu: ");
                ocjena = Convert.ToInt32(Console.ReadLine());
                if (ocjena > 1 && ocjena <= 5) // Ako je ocjena 1 do 5. Radi normalno
                {
                    zbrojOcjena += ocjena;
                    brojOcjena++;
                }
                else if (ocjena != 0) //Ako je ocjena nije 1 do 5 i da nije 0. Onda Ispiše da je nepravilno.
                {
                    Console.WriteLine("- Nepravilno ispis!!!");
                }
                if (ocjena == 1) //Ako je ocjena 1. Kaže da je pao razred.
                {
                    Console.WriteLine("Nisi prošao razred.");
                    goto Line;
                }

            }
            while (ocjena != 0);

            // Izračun
            prosjekOcjena = zbrojOcjena / brojOcjena;

            // Ispis
            Console.WriteLine("Prosjek Ocjena: " + prosjekOcjena);

            Line: Console.ReadKey();
        }
    }
}
