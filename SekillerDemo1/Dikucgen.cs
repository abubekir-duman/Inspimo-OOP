using SekillerDemo1.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDemo1
{
    public class Dikucgen : KoseliSekilBase
    {
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik / 2;
        }

        public override double CevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(Genislik, 2) + Math.Pow(Yukseklik, 2));
            return hipotenus + Genislik + Yukseklik;
        }
    }
}
