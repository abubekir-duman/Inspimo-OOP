using Inheritance.SekillerDemo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.SekillerDemo
{
    public class Dikdortgen : KöseliSekil, IHesapla
    {
        public double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }

        public double CevreHesapla()
        {
            return 2 * (Genislik + Yukseklik);
        }
    }
}
