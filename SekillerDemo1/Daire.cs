using SekillerDemo1.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDemo1
{
    public class Daire : YuvarlakSekilBase
    {
        public override double AlanHesapla()
        {
            return PiUcMu ? 3*Math.Pow(Yaricap,2):Math.PI*Math.Pow(Yaricap,2);
        }

        public override double CevreHesapla()
        {
            return PiUcMu ? 2 * 3 * Yaricap : 2 * Math.PI * Yaricap;
        }
    }
}
