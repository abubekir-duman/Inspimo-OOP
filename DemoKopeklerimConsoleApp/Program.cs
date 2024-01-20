using DemoKopeklerimConsoleApp.Repositories;
using System.ComponentModel.Design;

namespace DemoKopeklerimConsoleApp
{
    internal class Program
    {
        static KopekRepo _kopekRepo;
        static IrkRepo _irkRepo;

        static void Main(string[] args)
        {
            _irkRepo = new IrkRepo();
            _kopekRepo = new KopekRepo();

            string giris = MenuGetir();

            while (giris != "0")
            {
                switch (giris)
                {
                    case "1":
                        KopekleriListele();
                        break;
                    case "2":
                        AdaGoreKopekleriListele();
                        break;
                    case "3":
                        IdyeGoreKopegiGoster();
                        break;
                    case "4":
                        KopekEkle2();
                        break;
                    case "5":
                        KopekGuncelle2();
                        break;
                    case "6":
                        KopekSil();
                        break;
                    default:
                        Console.WriteLine("Geçersiz İşlem!");
                        break;
                }
                giris = MenuGetir();

            }
        }

         static string MenuGetir()
        {
            Console.WriteLine("\nİşlem Seçiniz\n" +
                "0:Çıkış\n" +
                "1:Tüm Köpeklerimi Listele\n" +
                "2:Ada göre köpeklerimi listele\n" +
                "3:ID'ye göre köpeğimi göster\n" +
                "4:Köpek ekle\n" +
                "5: Köpek güncelle\n" +
                "6:Köpek sil");
            return Console.ReadLine().Trim();
        }

        static void Yazdir (Kopek kopek)
        {
            string kopekText;
            string irkText;

        }
            

        
    }
}
