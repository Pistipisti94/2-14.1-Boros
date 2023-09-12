using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace schumacher
{
    internal class Program
    {
        static List<AdatIO> adatIOs = new List<AdatIO>();
        static void Main(string[] args)
        {
            //Metódusok
            adatokBeolvasasa();
            feladatok3();

            Console.WriteLine("Program vége!");
            Console.ReadKey();

        }
        //A harmadik feladat metódus
        private static void feladatok3()
        {
            Console.WriteLine($"3. feladat: {adatIOs.Count} sort olvastunk be. ");
            Console.WriteLine("4. feladat: Magyar Nagydíj helyezései");
            Console.WriteLine($"\t");
        }

        private static void adatokBeolvasasa()
        {
            try 
            {
                using (StreamReader file = new StreamReader("schumacher.csv"))
                {
                    file.ReadLine();
                    while (!file.EndOfStream)
                    {
                        adatIOs.Add(new AdatIO(file.ReadLine()));
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Adatok kiiratása
            //foreach (var item in adatIOs)
            //{
            //    Console.WriteLine(item.Grandprix);
            //}
        }
    }
}
