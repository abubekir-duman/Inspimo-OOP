using System.Collections;

namespace ArrayListCollectionType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[3];
            //isimler[0] = "Angel";
            //isimler[1] = "Leo";
            //isimler[2] = "Luna";

            //foreach (string isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            //Console.WriteLine();


            //isimler = new string[4];
            //isimler[0] = "Angel";
            //isimler[1] = "Leo";
            //isimler[2] = "Luna";

            //isimler[3] = "ÇAĞIL";

            //foreach (string isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            //Console.WriteLine();


            ArrayList isimlistesi = new ArrayList()
            {
                "angel",
                "Leo",
                "Luna"
            };

            foreach (string isimElemani in isimlistesi)
            {
                Console.WriteLine(isimElemani);
            }
            Console.WriteLine();


            isimlistesi.Add("ÇAĞIL");

            Console.WriteLine();

            for (int i = 0; i < isimlistesi.Count; i++)
            {
                Console.WriteLine(isimlistesi[i]);
            }
            Console.WriteLine();


            isimlistesi.Add(43);
            isimlistesi.Add("E");
            isimlistesi.Add(true);
            isimlistesi.Add(1.75);

            foreach (var isimElemani in isimlistesi)
            {
                Console.WriteLine(isimElemani);
            }
            Console.WriteLine();
        }
    }
}
