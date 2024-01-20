using System.ComponentModel;

namespace ListCollectionType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();

            sehirler.Add("İSTANBUL");
            sehirler.Add("ANKARA");
            sehirler.Add("İZMİR");

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine();

            Console.WriteLine(sehirler[0]);
            Console.WriteLine();


            List<Sehir> sehirListesi = new List<Sehir>()
            {
                new Sehir(1,"ADANA"),

                new Sehir()
                {
                    PlakaNo=7,
                    Adi="Antalya"
                },

                new Sehir(26,"ESKİŞEHİR")
            };

            Sehir sehirElemani = new Sehir()
            {
                PlakaNo=9,
                Adi="Aydın"
            };

            sehirListesi.Add(sehirElemani);

            sehirListesi.Add(new Sehir()
            {
                PlakaNo=16,
                Adi="Bursa"
            });

            for (int i = 0; i < sehirListesi.Count; i++)
            {
                Console.WriteLine("Plaka:" + sehirListesi[i].PlakaNo + ",Ad:" + sehirListesi[i].Adi);
            }
            Console.WriteLine();

            Sehir indexUzerindenSehir = sehirListesi[3];

            Console.WriteLine($"Plaka:{indexUzerindenSehir.PlakaNo},Ad:{indexUzerindenSehir.Adi}");



        }
    }
}
