using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.SekillerDemo.Bases;

namespace Inheritance.SekillerDemo
{
    public class Sekiller
    {
        public static void Calistir()
        {
            Daire daire1 = new Daire()
            {
                Yaricap = 5,
                PiUcMu=false

            };

            Console.WriteLine("dairenin alanı:" + daire1.AlanHesapla());
            Console.WriteLine("dairenin cevresi:" + daire1.CevreHesapla());
        }
    }
}
