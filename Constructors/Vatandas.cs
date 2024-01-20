using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Vatandas
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Ulke { get; set; }

        public string Sehir { get; set; }

        public Vatandas()
        {
            Ulke = "türkiye cumhuriyeti";
            Adi = "";
            Soyadi = string.Empty;
            Sehir = "";
        }

        public string UlkeVeSehirGetir() => $"ülke/şehir:{Ulke}/{Sehir}";

        public string AdSoyadGetir()
            {
                return "Adı Soyadı: " + Adi + "" + Soyadi;
            }

        
    }
}
