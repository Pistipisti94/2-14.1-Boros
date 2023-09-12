using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek2020
{
    internal class AdatIO
    {
        string Név;
        string Neme;
        string Részleg;
        int Belépés;
        int Bér;

        public string Név1 { get => Név; set => Név = value; }
        public string Neme1 { get => Neme; set => Neme = value; }
        public string Részleg1 { get => Részleg; set => Részleg = value; }
        public int Belépés1 { get => Belépés; set => Belépés = value; }
        public int Bér1 { get => Bér; set => Bér = value; }

        public AdatIO(string név, string neme, string részleg, int belépés, int bér)
        {
            Név = név;
            Neme = neme;
            Részleg = részleg;
            Belépés = belépés;
            Bér = bér;
        }
        public AdatIO(string beolvasottSor)
        {
            string[] strings = beolvasottSor.Split(';');
            Név = strings[0];
            Neme = strings[1];
            Részleg = strings[2];
            Belépés = int.Parse(strings[3]);
            Bér = int.Parse(strings[4]);

        }
    }
}
