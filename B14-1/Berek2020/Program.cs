using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
    internal class Program
    {
        static List<AdatIO> adatIOs = new List<AdatIO>();
        private static string reszleg;


        static void Main(string[] args)
        {
            adatokBeolvasasa();
            feladat3();
            feladat4();
            feladat5("5. feladat: Kérem egy részleg nevét:");
            feladat6();
            feladat7();
            
            
            Console.WriteLine("Program vége.");
            Console.ReadKey();
        }

        private static void feladat7()
        {
            Console.WriteLine("7. feladat: ");
            adatIOs.GroupBy(x => x.Részleg1).ToList().ForEach(x => Console.WriteLine($"\t{x.Key} - {x.Count()} fő"));
        }

        private static void feladat6()
        {
            try
            {
                int index = adatIOs.IndexOf(adatIOs.Where(x => x.Részleg1 == reszleg).OrderByDescending(x => x.Bér1).First());
                Console.WriteLine("6. Feladat: A legtöbbet kereső dolgozó a megadott részlegen");
                Console.WriteLine($"\tNév: {adatIOs[index].Név1}");
                Console.WriteLine($"\tNem: {adatIOs[index].Neme1}");
                Console.WriteLine($"\tBelépés: {adatIOs[index].Belépés1}");
                Console.WriteLine($"\tBér: {adatIOs[index].Bér1:### ###} Forint");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("6. Feladat: A megadott részleg nem létezik a cégnél!");
            }
        }

        private static void feladat5(string szoveg)
        {
            Console.WriteLine(szoveg);
            Console.WriteLine("Részlegek:");
            foreach (var item in adatIOs.GroupBy(a => a.Részleg1).Select(b => new { ok = b.Key}))
            {
                    Console.WriteLine($"\t{item.ok}");
            }
           
            reszleg = Console.ReadLine();
        }

        private static void feladat4()
        {
            Console.WriteLine($"4. feladat: Bérek átlaga: {((double)adatIOs.Sum(a => a.Bér1) / adatIOs.Count / 1000 ):00.0} eFt");
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
