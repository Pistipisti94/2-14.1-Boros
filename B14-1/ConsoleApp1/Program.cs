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
            
            bool jo = false;
            int a = 0, b = 0, szamA;
            szamA = SzamotKer();
            Console.WriteLine("Kérek két egész számot");
            Console.WriteLine("Első szám: ");
            while (jo != true)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0 || a > 0)
                {
                    jo = true;
                }
                else
                {
                    Console.WriteLine("Első szám: ");
                }
            }
            Console.WriteLine("Második szám: ");
            jo = false;
            while (jo != true)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (b < 0 || b > 0)
                {
                    jo = true;
                }
                else
                {
                    Console.WriteLine("Második szám: ");
                }
            }

            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Szám 1 = {a} meg szám 2 = {b} = " + (a+b));
            Console.WriteLine();
            Console.WriteLine("Bármelyik billenytűzet lenyomásával kiléphetsz.");
            Console.ReadKey();
        }

        private static int SzamotKer()
        {

        }
    }
}
