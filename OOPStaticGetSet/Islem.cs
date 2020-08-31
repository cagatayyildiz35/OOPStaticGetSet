using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStaticGetSet
{
    static class Islem
    {
        public static decimal KDVHesapla(decimal fiyat)
        {
            return fiyat * 1.8M;
        }


        public static decimal OTVHesapla(decimal fiyat)
        {
            return fiyat * 2;
        }
    }
}
