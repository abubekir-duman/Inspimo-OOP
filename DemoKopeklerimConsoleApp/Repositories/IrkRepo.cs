using DemoKopeklerimConsoleApp.Data;
using DemoKopeklerimConsoleApp.Entities;
using DemoKopeklerimConsoleApp.Entities.Bases;
using DemoKopeklerimConsoleApp.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKopeklerimConsoleApp.Repositories
{
    public class IrkRepo : IRepo
    {
        public List<Irk> IrklariGetir()
        {
            return Veriler.Irklar;
        }


        public Kayit KayitGetir(int id)
        {
            Kayit kayit = null;
            List<Irk> irklar = IrklariGetir();

            foreach(Irk irk in irklar)
            {
                if (irk.Id == id)
                {
                    kayit = irk;
                    break;
                }
                
            }

            return kayit;
        }
    }
}
