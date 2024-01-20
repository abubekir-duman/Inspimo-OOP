namespace AbstarctClassesDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YazilimDersi yazilimDersi = new YazilimDersi()
            {
                Id = 101,
                Adi="C# programlama dersi",
                Sinav1Notu=90,
                Sinav2Notu=70,
                SonSinavNotu=80
            };

            string yazilimDersiKodu = yazilimDersi.KodGetir();

            byte yazilimDersiMaksimumNotu = yazilimDersi.MaksimumNotGetir();

            double yazilimDersiNotu = yazilimDersi.DersNotuHesapla();

            Console.WriteLine($"\nDers Kodu: {yazilimDersiKodu}\nDers Adı: {yazilimDersi.Adi}\n" +
               $"Ders Notu: {yazilimDersiMaksimumNotu} üzerinden {yazilimDersiNotu}");

            MüzikDersi müzikDersi = new MüzikDersi()
            {
                Id=201,
                Adi="Armoni",
                Sinav1Notu=3,
                Sinav2Notu=7
            };

            Console.WriteLine($"\nDers Kodu: {müzikDersi.KodGetir()}\nDers Adı: {müzikDersi.Adi}\n" +
               $"Ders Notu: {müzikDersi.MaksimumNotGetir()} üzerinden {müzikDersi.DersNotuHesapla()}");
        }
    }
}
