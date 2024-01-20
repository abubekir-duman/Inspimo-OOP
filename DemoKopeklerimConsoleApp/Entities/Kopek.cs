using DemoKopeklerimConsoleApp.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKopeklerimConsoleApp.Entities
{
    public class Kopek:Kayit
    {
        public string Adi { get; set; }

        public DateTime DogumTarihi { get; set; }

        public bool ErkekMi { get; set; }

        public Irk Irki { get; set; }

        public double Boyu { get; set;; }

        public double Kilosu { get; set; }
    }
}
