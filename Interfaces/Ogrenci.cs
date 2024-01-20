using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Ogrenci : IKisi
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string Okulu { get; set; }

        public string Getir()
        {
            return $"tc kimlik no:{TcKimlikNo}\nOgrenci:{Adi} {Soyadi}\nOkul:{Okulu}";
        }
    }
}
