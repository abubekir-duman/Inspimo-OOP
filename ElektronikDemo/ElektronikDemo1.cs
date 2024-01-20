using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ElektronikDemo.Models;
using Microsoft.VisualBasic;


namespace ElektronikDemo
{
    public class ElektronikDemo1
    {
        public static void Calistir()
        {
            Bilgisayar bilgisayar = new Bilgisayar()
            {
                Marka = "ASUS",
                Model = "rog",
                SeriNo = "ar123",

                UretimTarihi = DateTime.Parse("16.03.2023 12:44:55", new CultureInfo("tr-TR")),

                BilgisayarTipi= BilgisayarTipi.Dizüstü,
                IslemciTipi=IslemciTipi.i7,
                EkranBoyutu=27,
                SuSogutmaliMi=true,
            };

            string bilgisayarbilgisi = $"bilgisayar:\n" +
                $"Marka:{bilgisayar.Marka}\n" +
                 $"Model:{bilgisayar.Model}\n" +
                  $"seri no:{bilgisayar.SeriNo}\n" +
                   $"üretim tarihi:{bilgisayar.UretimTarihi.ToString("dd.MM.yyyy HH:mm:ss")}\n" +
                    $"bilgisayar tipi:{bilgisayar.BilgisayarTipi}({(int)bilgisayar.BilgisayarTipi})\n" +
                     $"işlemci tipi:{bilgisayar.IslemciTipi}({(int)bilgisayar.IslemciTipi})\n" +
                      $"hafıza:{bilgisayar.Hafiza}\n" +
                       $"ekran boyutu:{bilgisayar.EkranBoyutu}\n" +
                        $"kategori:{bilgisayar.Kategori}\n" +
                         $"su soğutmalimi:{bilgisayar.SuSogutmali}({bilgisayar.SuSogutmaliMi})\n";

            Console.WriteLine(bilgisayarbilgisi);
        }
    }
}
