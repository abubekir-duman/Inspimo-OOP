using Polymorphism.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class PcOyunu : VideoOyunu
    {
        public string[] IsletimSistemleri { get; set; }

        public bool SteamOyunuMu { get; set; }

        public string IsletimSistemleriGosterim => string.Join(",", IsletimSistemleri);

        public string StemOyunuMuGosterim => SteamOyunuMu ? "evet" : "hayır";
    }
}
