using System.Globalization;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kopek kopek = new Kopek()
            {
                Adi="leo",
                Cinsiyeti=Cinsiyet.Erkek,
                DogumTarihi=DateTime.Parse("19.10.2022",new CultureInfo("tr-TR")),
                Irki="Kangal"

            };
            Console.WriteLine($"köpek:\nAdı{kopek.Adi}\nCinsiyeti{kopek.Cinsiyeti}\nIrkı{kopek.Irki}" +
                $"\ndoğum tarihi{kopek.DogumTarihi.ToShortDateString()}");
            kopek.Uyu();
            kopek.YemekYe();
            kopek.SesCikar();

            Kedi kedi = new Kedi()
            {
                Adi = "luna",
                Cinsiyeti = Cinsiyet.Dişi,
                DogumTarihi = DateTime.Parse("11.11.2022", new CultureInfo("tr-TR")),
                Irki = "garfield"

            };
            Console.WriteLine($"kedi:\nAdı{kedi.Adi}\nCinsiyeti{kedi.Cinsiyeti}\nIrkı{kedi.Irki}" +
                $"\ndoğum tarihi{kedi.DogumTarihi.ToShortDateString()}");
            kedi.Uyu();
            kedi.YemekYe();
            kedi.SesCikar();
        }
    }

    enum Cinsiyet
    {
        Dişi,
        Erkek
    }

    class EvcilHayvan
    {
        public string Adi { get; set; }

        public Cinsiyet Cinsiyeti { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Irki { get; set; }



        public void YemekYe()
        {
            Console.WriteLine("Evcil hayvan yemek yiyor");
        }

        public void Uyu()
        {
            Console.WriteLine("Evcil hayvan uyuyor");
        }

        public virtual void SesCikar()
        {
            Console.WriteLine("Evcil hayvan ses çikariyor");
        }

    }

    class Kopek : EvcilHayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Köpek havlıyor");
        }
    }

    class Kedi : EvcilHayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Kedi miyavlıyor");
        }

        public override string ToString()
        {
            return $"kedi bilgisi:\nAdı:{Adi}\ncinsiyeti:{Cinsiyeti}\nIrkı:{Irki}\nDogumTarihi:{DogumTarihi.ToShortDateString()}";
        }
    }
}
