namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();
            Console.WriteLine(vatandas1.Ulke);
            Console.WriteLine(vatandas1.Sehir);

            Vatandas vatandas2 = new Vatandas
            {
                Ulke = "ABD",
                Sehir="new york",
                Adi="Çağıl",
                Soyadi="alsaç"

            };
            Console.WriteLine(vatandas2.UlkeVeSehirGetir());
            Console.WriteLine(vatandas2.AdSoyadGetir());


            Ogrenci ogrenci1 = new Ogrenci()
            {
                Adi="çağıl",
                Soyadi="alsaç"
            };

            Ogrenci ogrenci2 = new Ogrenci("luna","alsaç",80,70,90);

            Ogrenci ogrenci3 = new Ogrenci(10,20,30)
            {
                Adi="leo",
                Soyadi="Jr."
            };
        }
    }
}
