using DemoKopeklerimConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKopeklerimConsoleApp.Data
{
    public static class Veriler
    {
        public static string KayitBulunamadiMesaji => "Kayıt Bulunamadı.";

        public static string HataMesaji => "İşlem sırasında hata meydana geldi.";

        public static int EnsonId { get; set; } = 1;

        public static List<Kopek> Kopekler { get; set; }

        public static List<Irk> Irklar { get; set;}


        static Veriler()
        {
             Irklar = new List<Irk>()
            {
                 new Irk("İrlanda Seteri",Ulkeler.İrlanda,EnsonId++),
                 new Irk("Shetland Sheepdog",Ulkeler.İskoçya,EnsonId++),
                 new Irk("Border Collie",Ulkeler.İngiltere,EnsonId++)
            };

            Kopekler = new List<Kopek>();
            Kopek kopek = new Kopek()
            {
                Id=EnsonId++,
                Adi="Angel",
                DogumTarihi=DateTime.Parse("01.06.1994 02:18:34",new CultureInfo("tr-Tr")),
                Irki = Irklar[0],
                Boyu=55.7,
                Kilosu=24
            };
            Kopekler.Add(kopek);

            kopek = new Kopek();
            kopek.Id=EnsonId++;
            kopek.Adi = "Leo";
            kopek.DogumTarihi = new DateTime(2014, 5, 11, 22, 43, 0);
            kopek.Irki = Irklar[1];
            kopek.Boyu = 40;
            kopek.Kilosu = 10.3;
            kopek.ErkekMi = true;
            Kopekler.Add(kopek);

            kopek = new Kopek()
            {
                Id=EnsonId++,
                Adi="Loki",
                DogumTarihi=DateTime.Parse("19.06.2022",new CultureInfo("tr-Tr")),
                Irki = Irklar[2],
                Boyu=50,
                Kilosu=20,
                ErkekMi=true

            };
            Kopekler.Add(kopek);


            kopek = new Kopek()
            {
                Id = EnsonId++,
                Adi = "Luna",
                DogumTarihi = new DateTime(2022,9,29),
                Irki = Irklar[0],
                Boyu = 39.5,
                Kilosu = 9.5,
                ErkekMi = false
            };
            Kopekler.Add(kopek);

            kopek = new Kopek()
            {
                Id = EnsonId++,
                Adi = "Leo Jr.",
                DogumTarihi = DateTime.Parse("15.10.2022", new CultureInfo("tr-Tr")),
                Irki = Irklar[2],
                Boyu = 36,
                Kilosu = 9,
                ErkekMi = true
            };
            Kopekler.Add(kopek);
        }
        
        public static string KayitSayisiMesajiGetir(int kayitSayisi)
        {
            return kayitSayisi == 0 ? KayitBulunamadiMesaji : kayitSayisi + "kayıt bulundu.";
        }

    }
}
