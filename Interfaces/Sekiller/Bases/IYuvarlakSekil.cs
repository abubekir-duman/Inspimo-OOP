using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Sekiller.Bases
{
    public interface IYuvarlakSekil
    {
        public double Yaricap { get; set; }

        public bool PiUcMu { get; set; }

        public double CevreHesapla();

        public double AlanHesapla();
    }
}
