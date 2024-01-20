using Interfaces.Sekiller;
using Interfaces.Sekiller.Bases;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKisi ogrenci1 = new Ogrenci()
            {
                TcKimlikNo = "12334435",
                Adi = "luna",
                Soyadi = "ALSAÇ",
                Okulu = "ANADOLU LİSESİ"


            };

            Console.WriteLine(ogrenci1.Getir());

            IKisi ogrenci2 = new Ogrenci()
            {

                TcKimlikNo = "12334435",
                Adi = "leo",
                Soyadi = "ALSAÇ",
                Okulu = "university of alabama"
            };

            Console.WriteLine(ogrenci2.Getir());


            IKisi ogrenci3 = new Ogrenci();
            ogrenci3.TcKimlikNo = "1234566";
            ogrenci3.Adi = "mahmut";
            ogrenci3.Soyadi = "UTMANOĞLU";
            



            Console.WriteLine(ogrenci3.Getir());

            Musteri musteri1 = new Musteri()
            {
                TcKimlikNo = "12334435",
                Adi = "Abubekir",
                Soyadi = "Duman",
                KrediKartıNo="2345 3445 5678 4321"
            };

            Console.WriteLine(musteri1.Getir());

            IKisi musteri2 = new Musteri()
            {
                TcKimlikNo = "12334435",
                Adi = "dünya",
                Soyadi = "Duman",
                KrediKartıNo = "2345 3445 5678 4321"
            };

            Console.WriteLine(musteri2.Getir());

            Console.WriteLine("Müşteri2 Kredi Kartı No: " + (musteri2 as Musteri).KrediKartıNo);


            Daire daire1 = new Daire()
            {
                Yaricap = 5,
                PiUcMu=true
            };

            Console.WriteLine("dairenin çevresi:"+daire1.CevreHesapla());

            Daire daire2 = new Daire()
            {
                Yaricap = 10,
               
            };

            Console.WriteLine("dairenin çevresi:" + daire2.CevreHesapla());
            Console.WriteLine("dairenin alanı:" + daire2.AlanHesapla());


            IKoseliSekil koseliSekil1 = new Dikdortgen()
            {
                Genislik=4,
                Yukseklik=5
            };

            Console.WriteLine("dikdörtgenin çevresi:" + koseliSekil1.CevreHesapla());
            Console.WriteLine("dikdörtgenin alanı:" + koseliSekil1.AlanHesapla());

            IKoseliSekil koseliSekil2 = new Dikucgen()
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
