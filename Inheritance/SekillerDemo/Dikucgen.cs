using Inheritance.SekillerDemo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.SekillerDemo
{
    public class Dikucgen : KöseliSekil, IHesapla
    {
        public double AlanHesapla()
        {
            return Genislik * Yukseklik / 2;
        }

        public double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
            return hipotenus + Genislik + Yukseklik;
        }
    }
}
