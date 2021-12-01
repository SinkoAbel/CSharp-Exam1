using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.feladat
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kérd be egy hallgató nevét.

           Utána kérd meg a hallgatót, hogy írja be a Magasprog1 vizsgajegyeit. 
           (Mivel 1-es esetén vizsgát kell ismételni, illetve javítóvizsgát is tehet, így előre nem tudjuk, hány darab jegyet fog beírni.)

           A jegyek bekérése két okból állhat le:

           Már 5 db. 1-est szerzett. Ekkor a Tanulmányi és Vizsgaszabályzat alapján nem vizsgázhat többé.
           Megszerzi az első 5-ösét. (Ezt már biztos nem akarja javítani egy újabb vizsgán.)
           Beírja (a jegy bekérésekor), hogy "ELÉG".
           Ezek után írjuk ki a következőket:

           Hányszor vizsgázott összesen.
           Hány 1-est és hány nem 1-est szerzett.
           Mennyi a jegyei átlaga. */

            Console.Write("Adja meg a nevét: ");
            string hallgatoNev = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("A program futtatásának megszakításához írja be, hogy: 'ELÉG'");
            Console.WriteLine();



            List<byte> vizsgaJegyek = new List<byte>();
            float atlag;
            byte egyesekSzama = 0;
            byte beJegy;    
            string temp;

            do
            {                                 
                Console.Write("Adja meg a Magasszintű programozásból elért jegyeit: ");
                temp = Console.ReadLine();

                if (temp.ToLower() == "elég")
                    break;

                byte.TryParse(temp, out beJegy);

                if (beJegy > 0)
                {
                    vizsgaJegyek.Add(beJegy);
                }

                if (beJegy == 5)
                    break;

                if (beJegy == 1)
                    egyesekSzama++;


            } while (!byte.TryParse(temp, out beJegy) || beJegy < 1 || beJegy > 5 || vizsgaJegyek.Count < 5);


            Console.WriteLine();

            //Kiiratás
            Console.WriteLine("Vizsgák száma: {0}", vizsgaJegyek.Count);
            Console.WriteLine("Egyesek száma: {0}", egyesekSzama);
            Console.WriteLine("Jó jegyek száma: {0}", vizsgaJegyek.Count - egyesekSzama);
            Console.WriteLine("Átlag: {0}", vizsgaJegyek.Average(x=>x));



        }
    }
}
