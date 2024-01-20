namespace IsimBulmaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*** İsim Bulma Demo***");

            List<string> isimler = new List<string>();

            string giris;
            string bulunanIsim;

            Console.Write("İsim listesine eklenecek isim giriniz:(ç:çıkış)");
            giris = Console.ReadLine();

            while (giris != "ç")
            {
                isimler.Add(giris);

                Console.Write("isim listesine eklenecek isim giriniz:(ç:çıkış)");

                giris = Console.ReadLine();

            }

            if (isimler.Count > 0)
            {
                Console.Write("isim arama işlemi seçiniz:(t:tam isim,p:ismin parçası,ç:çıkış)");
                giris = Console.ReadLine();

                while (giris != "ç")
                {
                    bulunanIsim = null;

                    if(giris=="t" || giris == "p")
                    {
                        if (giris == "t")
                        {
                            Console.Write("Aranacak tam ismi giriniz:");
                            giris = Console.ReadLine();

                            int bulunanIsimIndex = isimler.IndexOf(giris);

                            if (bulunanIsimIndex != -1)
                            {
                                bulunanIsim = isimler[bulunanIsimIndex];
                            }
                                
                               
                        }
                        else
                        {
                            Console.Write("Aranacak ismin parçasını giriniz:");
                            giris = Console.ReadLine();

                            foreach(string isim in isimler)
                            {
                                if (isim.Contains(giris))
                                {
                                    bulunanIsim = isim;

                                    break;
                                }
                            }
                        }


                        Console.WriteLine(bulunanIsim is null ? "aradığınız isim bulunamadı!":$"aradığınız isim bulundu:\"{bulunanIsim}\".");
                    }
                    Console.Write("isim arama işlemi seçiniz:(t:tam isim,p:ismin parçası,ç:çıkış)");
                    giris = Console.ReadLine();
                }
            }
        }
    }
}
