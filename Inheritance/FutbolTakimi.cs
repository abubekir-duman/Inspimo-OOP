using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class FutbolTakimi:Takım
    {
        public string TeknikDirektorAdi { get; set; }

        public string KaleciAdi {  get; set; }

        public string DefansOyuncuAdlari {  get; set; }

        public string OrtaSahaOyuncuAdlari { get; set; }

        public string ForvetOyuncuAdlari { get; set; }

        public string OyunSistemi {  get; set; }


        public string KadroGetir()
        {
            return $"teknik direktör:{TeknikDirektorAdi}\n kaleci:{KaleciAdi}\n" +
                $"defans oyuncuları:{DefansOyuncuAdlari}\norta saha oyuncuları:{OrtaSahaOyuncuAdlari}\n" +
                $"forvet oyuncuları:{ForvetOyuncuAdlari}";

        }

    }
}
