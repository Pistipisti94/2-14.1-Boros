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
            bool szam = true;
            bool szam2 = true;
            int a = 0;
            int b = 0;
            Console.WriteLine("Kérek két egész számot");
            Console.WriteLine("Első szám: ");
            while (szam)
            {
                
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0 || a > 0)
                {
                    szam=false;
                }
                else
                {
                    Console.WriteLine("Első szám: ");
                }
                
            }
            Console.WriteLine("Második szám: ");
            while (szam2)
            {

                a = Convert.ToInt32(Console.ReadLine());
                if (b < 0 || b > 0)
                {
                    szam2 = false;
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
    }
}
