using DemoKopeklerimConsoleApp.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKopeklerimConsoleApp.Entities
{
    public class Irk:Kayit
    {
        public string Adi { get; set; }

        public Ulkeler Ulkesi { get; set; }

        public Irk(string adi, Ulkeler ulkesi, int id) : base(id) 
        {
            Adi = adi;
            Ulkesi = ulkesi;

        }
        

    }
}
