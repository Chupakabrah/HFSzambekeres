﻿using System;
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
            int szam;
            List<int> szamLista = new List<int>();
            int[] szamTomb = new int[10];

            Console.WriteLine("Kérem adjon meg 10db számot!");
            do
            {
                Console.Write((db + 1) + ". szám : ");
                szam = Convert.ToInt32(Console.ReadLine());
                szamTomb[db] = szam;
                szamLista.Add(szam);
                db++;
            } while (db < 10);

            Console.WriteLine("\n(Tömb) Max : " + MinMaxSzamok.MaxSzam(szamTomb));
            Console.WriteLine("\n(Lista) Max : " + szamLista.Max());
            Console.ReadKey();
        }
    }
}
