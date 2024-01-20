using AbstarctClassesDemo1.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClassesDemo1
{
    public class YazilimDersi:DersBase
    {
        public double SonSinavNotu {  get; set; }

        public override string KodGetir() => "YZL-" + Id;

        public override double DersNotuHesapla() => Sinav1Notu * 0.2 + Sinav2Notu * 0.2 + SonSinavNotu * 0.6;
        

    }
}
