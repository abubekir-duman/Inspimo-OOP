using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Takım
    {
        public string Adi { get; set; }

        public short KurulusYili { get; set; }

        public string Sehir { get; set; }


        public string BilgiGetir()
        {
            return $"Takım:{Adi}\n Krulus yılı:{KurulusYili}";
        }
    }
}
