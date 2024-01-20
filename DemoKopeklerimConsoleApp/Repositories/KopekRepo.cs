using DemoKopeklerimConsoleApp.Data;
using DemoKopeklerimConsoleApp.Entities;
using DemoKopeklerimConsoleApp.Entities.Bases;
using DemoKopeklerimConsoleApp.Repositories.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoKopeklerimConsoleApp.Repositories
{
    public class KopekRepo : IRepo
    {
        private IrkRepo _irkRepo = new IrkRepo();

        public List<Kopek> KopekleriGetir()
        {
            return Veriler.Kopekler;
        }

        public List<Kopek> KopekleriGetir(string adi)
        {
            List<Kopek> kopekler = new List<Kopek>();
            List<Kopek> mevcutKopekler = KopekleriGetir();
            foreach (Kopek mevcutKopek in mevcutKopekler)
            {
                if (!string.IsNullOrWhiteSpace(adi) && mevcutKopek.Adi.Contains(adi, StringComparison.OrdinalIgnoreCase))
                {
                    kopekler.Add(mevcutKopek);
                }
                
            }
            return kopekler;
        }

        private Kopek KopekGetir(string adi,int id = 0)
        {
            Kopek kopek = null;
            List<Kopek> mevcutKopekler = KopekleriGetir();
            foreach (Kopek mevcutKopek in mevcutKopekler)
            {
                if(id==0 && mevcutKopek.Adi.Equals(adi, StringComparison.OrdinalIgnoreCase))
                {
                    kopek = mevcutKopek;
                    break;
                }
                else if(id!=mevcutKopek.Id && mevcutKopek.Adi.Equals(adi, StringComparison.OrdinalIgnoreCase))
                {
                    kopek = mevcutKopek;
                    break;
                }
                
            }
            return kopek;

        }


        public Kayit KayitGetir(int id)
        {
            
            Kayit kayit = null;
            List<Kopek> kopekler = KopekleriGetir();
            foreach (Kopek kopek in kopekler)
            {
                if (kopek.Id == id)
                {
                    kayit = kopek;
                    break;
                };
            }
            return kayit;
        }

       
    }
}
