using Inheritance.SekillerDemo.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.SekillerDemo
{
    public class Daire : YuvarlakSekil, IHesapla
    {
        public double AlanHesapla()
        {
            return PiUcMu ? 3 * Math.Pow(Yaricap, 2) : Math.PI * Math.Pow(Yaricap, 2);
        }

        public double CevreHesapla()
        {
            return PiUcMu ? 2 * 3 * Yaricap : 2 * Math.PI * Yaricap;
        }
    }
}
