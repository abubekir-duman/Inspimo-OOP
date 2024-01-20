using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Musteri : IKisi
    {
        public string TcKimlikNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        public string KrediKartıNo { get; set; }

        public string KrediKartıNoGizle()
        {
            return "**** **** ****" + KrediKartıNo.Substring(15);
        }
        



        public string Getir()
        {
            return $"tc kimlik no:{TcKimlikNo}\nmüşteri:{Adi} {Soyadi}\nKrediKartıNo:{KrediKartıNoGizle()}";
        }
    }
}
