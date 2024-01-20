using AbstractClasses.Bases;
using System.Globalization;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RecordBase record = new RecordBase()
            //{
            //    Id = 1,
            //    Guid= "5941e0be - 1509 - 4322 - 87a7 - b6832c5eb19d"
            //};

            //Console.WriteLine("ıd:"+record.Id+"\nguid:"+record.Guid);

            Product product = new Product()
            {
                Id = 1,
                Name = "Iphone 15",
                UnitPrice=10000,
                StockAmount=50,
                Guid=Guid.NewGuid().ToString()
            };

            Console.WriteLine("ID:"+product.Id+"\nname:"+product.Name+"\nunitprice:"+
                product.UnitPrice.ToString("C2",new CultureInfo("tr-TR"))+"\nstock amount:"+
                product.StockAmount+"\n guid:"+ product.Guid);

            Store store = new Store()
            {
                City="İSTANBUL",
                Country="türkiye",
                Guid=Guid.NewGuid().ToString(),
                Id=2,
                Name="vatan"

            };

            Console.WriteLine($"Id:{store.Id}\n" +
                $"name:{store.Name}\n" +
                $"city:{store.City} \n" + 
                $"Country:{store.Country} \n" + 
                $"guid:{store.Guid}");
                
        }
    }
}
