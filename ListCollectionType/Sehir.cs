using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionType
{
    public class Sehir
    {
        public byte PlakaNo {  get; set; }

        public string Adi {  get; set; }

        public Sehir()
        {
                
        }

        public Sehir(byte PlakaNo,string Adi)
        {
            PlakaNo = PlakaNo;
            Adi = Adi;
        }

    }
}
