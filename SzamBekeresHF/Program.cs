using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamBekeresHF
{
    class Program
    {
        static void Main(string[] args)
        {
            int db = 0;
            int szam, lngth;
            List<int> szamLista = new List<int>();

            Console.Write("Kérem adja meg, hogy hány számot szeretne megadni : ");
            lngth = Convert.ToInt32(Console.ReadLine());
            int[] szamTomb = new int[lngth];
            Console.WriteLine("Kérem adjon meg " + lngth + "db számot!");
            do
            {
                Console.Write((db + 1) + ". szám : ");
                szam = Convert.ToInt32(Console.ReadLine());
                szamTomb[db] = szam;
                szamLista.Add(szam);
                db++;
            } while (db < lngth);

            Console.WriteLine("\n(Tömb) Max : " + MinMaxSzamok.MaxSzam(szamTomb) + "\n(Tömb) Min : " + MinMaxSzamok.MinSzam(szamTomb));
            Console.WriteLine("\n(Lista) Max : " + szamLista.Max() + "\n(Lista) Min : " + szamLista.Min());
            Console.ReadKey();
        }
    }
}
