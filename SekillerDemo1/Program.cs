using SekillerDemo1.Bases;

namespace SekillerDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Daire daire1 = new Daire()
            {
                Yaricap = 5
            };

            Console.WriteLine("dairenin çevresi:" + daire1.CevreHesapla());
            Console.WriteLine("dairenin alanı:" + daire1.AlanHesapla());


            Daire daire2 = new Daire()
            {
                Yaricap=10,
                PiUcMu=false
            };

            Console.WriteLine("dairenin çevresi:" + daire2.CevreHesapla());
            Console.WriteLine("dairenin alanı:" + daire2.AlanHesapla());


            KoseliSekilBase koseliSekil1 = new Dikdortgen()
            {
                Genislik=4,
                Yukseklik=3

            };

            Console.WriteLine("dikdortgenin çevresi:" + koseliSekil1.CevreHesapla());
            Console.WriteLine("dikdortgenin alanı:" + koseliSekil1.AlanHesapla());


            KoseliSekilBase koseliSekil2 = new Dikucgen()
            {
                Genislik=8,
                Yukseklik=6
            };

            Console.WriteLine("dikucgenin çevresi:" + koseliSekil2.CevreHesapla());
            Console.WriteLine("dikucgenin alanı:" + koseliSekil2.AlanHesapla());


            Dikucgen dikucgen = new Dikucgen()
            {
                Genislik = 12,
                Yukseklik = 9
            };

            Console.WriteLine("dikucgenin çevresi:" + dikucgen.CevreHesapla());
            Console.WriteLine("dikucgenin alanı:" + dikucgen.AlanHesapla());

        }
    }
}
