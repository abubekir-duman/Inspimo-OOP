using Polymorphism.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models.Bases
{
    public class VideoOyunu
    {
        public string Adi { get; set; }

        public DateTime CikisTarihi {  get; set; }

        public string[] Turleri { get; set; }

        public OyuncuSayisi OyuncuSayisi { get; set; }

        public string TurleriGosterim
        {
            get
            {
                string turler= "";

                if(Turleri is not null)
                {
                    foreach(string turu in Turleri)
                    {
                        turler += turu + ",";
                    }
                    turler=turler.Substring(0,turler.Length-2);
                    turler=turler.Tr
                }
                return turler;
            }
        }


        public string OyuncuSayisiGosterim
        {
            get
            {
                
                string oyuncuSayisi;
                if (OyuncuSayisi.HasFlag(OyuncuSayisi.TekOyuncu) && OyuncuSayisi.HasFlag(OyuncuSayisi.ÇokOyuncu))
                    oyuncuSayisi = "Hem tek hemde çok";
                if (OyuncuSayisi == OyuncuSayisi.TekOyuncu)
                    oyuncuSayisi = "Tek";
                else if (OyuncuSayisi == OyuncuSayisi.ÇokOyuncu)
                    oyuncuSayisi = "Çok";
                else
                    oyuncuSayisi = "Çok";

                return oyuncuSayisi + "oyunculu";
            }
        }
    }
}
