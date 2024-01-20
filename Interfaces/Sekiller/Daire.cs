using Interfaces.Sekiller.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Sekiller
{
    public class Daire : IYuvarlakSekil
    {
        public double Yaricap { get; set; }
        public bool PiUcMu { get; set; }

        public double CevreHesapla()
        {
            return PiUcMu ? 2 * 3 * Yaricap : 2 * Math.PI * Yaricap;
        }
        public double AlanHesapla()
        {
            return PiUcMu ? 3*Math.Pow(Yaricap, 2) :Math.PI*Math.Pow(Yaricap, 2);
        }
    }
}
