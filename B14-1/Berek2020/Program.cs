using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
    internal class Program
    {
        static List<AdatIO> adatIOs = new List<AdatIO>();

        static void Main(string[] args)
        {
            adatokBeolvasasa();
            feladat3();
            feladat4();
            Console.WriteLine("Program vége.");
            Console.ReadKey();
        }

        private static void feladat4()
        {
            Console.WriteLine($"4. feladat: Bérek átlaga: {(adatIOs.Sum(a => a.Bér1) / adatIOs.Count /1000).ToString("#,###.0")} eFt");
        }

        private static void feladat3()
        {
                Console.WriteLine($"3. feladat: Dolgozók száma: {adatIOs.Count} fő ");
        }

        private static void adatokBeolvasasa()
        {
            try
            {
                using (StreamReader file = new StreamReader("berek2020.txt"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        adatIOs.Add(new AdatIO(file.ReadLine()));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
