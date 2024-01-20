using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Ogrenci
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        decimal _vize1;
        decimal _vize2;
        decimal _final;

        public Ogrenci(string adi, string soyadi, decimal vize1, decimal vize2, decimal final)
        {
            Adi = adi;
            Soyadi = soyadi;
            _vize1 = vize1;
            _vize2 = vize2;
            _final = final;
        }

        public Ogrenci(decimal vize1, decimal vize2, decimal final)
        {
            _vize1 = vize1;
            _vize2 = vize2;
            _final = final;
        }

        public Ogrenci()
        {

        }
           
    }
}
