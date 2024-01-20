using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDemo1.Bases
{
    public abstract class KoseliSekilBase : IHesapla
    {
        public double Genislik {  get; set; }

        public double Yukseklik {  get; set; }


        public abstract double AlanHesapla();
        
        public abstract double CevreHesapla();
        
    }
}
