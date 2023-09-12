using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szamA = SzamotKer("Adj meg egy számot: ");
            int szamB = SzamotKer("Adj meg még egy számot: ");
            Console.WriteLine($"Az első szám {szamA} + a második szám {szamB} = " + (szamA + szamB).ToString());
            Console.ReadKey();
        }

        private static int SzamotKer(string szoveg)
        {
            int bekertSzam;
            Console.WriteLine(szoveg);
            bekertSzam = Convert.ToInt32(Console.ReadLine());
            return bekertSzam;
        }
    }
}
