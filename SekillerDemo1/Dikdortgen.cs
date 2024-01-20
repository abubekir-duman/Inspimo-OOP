using SekillerDemo1.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDemo1
{
    public class Dikdortgen : KoseliSekilBase
    {
        public override double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }

        public override double CevreHesapla()
        {
            return 2 * (Genislik + Yukseklik);
        }
    }
}
