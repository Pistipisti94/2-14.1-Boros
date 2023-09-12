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
            adatokBeolvasasa();


            Console.WriteLine("Program vége!");
            Console.ReadKey();

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
            foreach (var item in adatIOs)
            {
                Console.WriteLine(item.Grandprix);
            }
        }
    }
}
