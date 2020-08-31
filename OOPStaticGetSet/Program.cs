using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStaticGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Islem islem = new Islem();

            //islem.KDVHesapla(50);

            //Islem.OTVHesapla(40);


            Ninja ninja = new Ninja();
            ninja.Name = "Çağatay";


            string ad = ninja.Name;

            int point = ninja.StartPoint;
            ninja.StartPoint = 15;

            int point2 = ninja.StartPoint;
            ninja.StartPoint = 5;
        }
    }
}
