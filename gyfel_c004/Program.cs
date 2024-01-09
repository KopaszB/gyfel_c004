using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C.4.feladat: Nem negatív egész számról határozza meg a program, hogy hány jegyű!

namespace gyfel_c004
{
    class Program
    {
        static void Main()
        {
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"A {szam} számjegyeinek a száma - {SzamjegyekSzama(szam)}"); 
            Console.ReadLine();

        }
        static int SzamjegyekSzama(int szam)
        {
            int szamlalo = 1;
            int i = 0;
            while (szam >= 10)
            {
                szam = szam / 10;
                szamlalo++;
                i++;
            }
            return szamlalo;
        }
    }
}
