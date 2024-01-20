using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDemo1.Bases
{
    public abstract class YuvarlakSekilBase : IHesapla
    {

        public double Yaricap {  get; set; }

        public bool PiUcMu { get; set; } = true; 



        public abstract double AlanHesapla();

        public abstract double CevreHesapla();
       
    }
}
