

using Inheritance.SekillerDemo;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
      

            FutbolTakimi futbolTakimi1 = new FutbolTakimi()
            {
                Adi="fenerbahçe",
                KurulusYili=1907,
                Sehir="istanbul",

                TeknikDirektorAdi="Jorge jesus",
                KaleciAdi="altay bayındır",
                DefansOyuncuAdlari="serdar aziz,gustavo henrique,atilla sezai,ferdi kadıoğlu",
                OrtaSahaOyuncuAdlari="diego rossi,joshua king,michy batsuay",
                ForvetOyuncuAdlari="bret samuel, eşref, sadi",
                OyunSistemi="4-4-2"
            };

            Console.WriteLine(futbolTakimi1.BilgiGetir());
            Console.WriteLine(futbolTakimi1.KadroGetir());
            Console.WriteLine("oyun sistemi:" + futbolTakimi1.OyunSistemi);
            Console.WriteLine("sehir:" + futbolTakimi1.Sehir);



            Takım takim2 = new FutbolTakimi()
            {
                Adi="galatasaray",
                KurulusYili=1905,
                Sehir="istanbul",

                TeknikDirektorAdi="okan buruk",
                KaleciAdi="Fernando muslera",
                DefansOyuncuAdlari="leo dubias,abdulkerim bardakçı,victor ne isso,sacha boey",
                OrtaSahaOyuncuAdlari="berkan kutlu,sergio olivera,milot ras hica,barış alper yılmaz",
                ForvetOyuncuAdlari="muhammed kerem aktürkoğlu,dries mertes",
                OyunSistemi="4-4-3"
            };

            Console.WriteLine(takim2.BilgiGetir());

            FutbolTakimi futbolTakimi2 =takim2 as FutbolTakimi;
            Console.WriteLine(futbolTakimi2.KadroGetir());
            Console.WriteLine("oyun sistemi:" + futbolTakimi2.OyunSistemi);
            Console.WriteLine("sehir:" + futbolTakimi2.Sehir);


            BasketbolTakımı basketbolTakimi3 = new BasketbolTakımı();

            basketbolTakimi3.Adi = "beşiktaş";
            basketbolTakimi3.KurulusYili = 1903;
            basketbolTakimi3.Sehir = "istanbul";
            basketbolTakimi3.BasantrenorAdi = "milan milicic";
            basketbolTakimi3.GeriSahaOyuncuAdlari = "ali,veli,satılmış";
            basketbolTakimi3.OnSahaOyuncuAdlari = "mehmet,kerem, okben ulubay";

            Console.WriteLine(basketbolTakimi3.BilgiGetir());

            Console.WriteLine("geri saha:" + basketbolTakimi3.GeriSahaOyuncuAdlari);
            Console.WriteLine("ön saha:" + basketbolTakimi3.OnSahaOyuncuAdlari);
            Console.WriteLine("sehir:" + basketbolTakimi3.Sehir);

            Takım takim4 = new BasketbolTakımı();

            takim4.Adi = "anadolu efes";
            takim4.KurulusYili = 1976;
            takim4.Sehir = "istanbul";

            Console.WriteLine(takim4.BilgiGetir()+ "\n sehir:"+takim4.Sehir);

           
                Daire daire1 = new Daire()
                {
                    Yaricap = 5,
                    PiUcMu = false

                };
            

                Console.WriteLine("dairenin alanı:" + daire1.AlanHesapla());
                Console.WriteLine("dairenin cevresi:" + daire1.CevreHesapla());
            
        }
    }
    
}
