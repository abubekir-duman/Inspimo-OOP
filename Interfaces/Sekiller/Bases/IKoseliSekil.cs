using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Sekiller.Bases
{
    public interface IKoseliSekil
    {
        public double Genislik { get; set; }

        public double Yukseklik { get; set; }

        public double CevreHesapla();

        public double AlanHesapla();
    }
}
