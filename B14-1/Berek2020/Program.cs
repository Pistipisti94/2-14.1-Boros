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
        static void Main(string[] args)
        {

            Console.WriteLine("Program vége.");
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
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
}
