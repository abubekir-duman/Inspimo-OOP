using Polymorphism.Enums;
using Polymorphism.Models;
using Polymorphism.Models.Bases;
using System.Globalization;

namespace Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoOyunu oyun1 = new VideoOyunu()
            {
                Adi = "FTL",
                CikisTarihi = DateTime.Parse("24.12.2023", new CultureInfo("tr-TR")),
                Turleri = new string[]
                {
                    "uzay", "turn base strateji"
                },
                OyuncuSayisi = OyuncuSayisi.TekOyuncu
            };

            Console.WriteLine("oyun adı:" + oyun1.Adi);

            oyun1 = new PcOyunu()
            {
                Adi = "Half-life-2",
                CikisTarihi = DateTime.Parse("23.03.2023", new CultureInfo("tr-Tr")),
                OyuncuSayisi = OyuncuSayisi.TekOyuncu | OyuncuSayisi.TekOyuncu,
                Turleri =new string[] {"ftsp","bilim kurgu"},
                IsletimSistemleri=new string[] {"windows 98","windows xp"},
                SteamOyunuMu=true
            };

            Console.WriteLine(oyun1.Adi);




        }
    }
}
