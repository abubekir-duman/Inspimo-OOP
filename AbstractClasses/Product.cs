using AbstractClasses.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public class Product:RecordBase
    {
        
        public string Name { get; set; }

        public double UnitPrice {  get; set; }  

        public int StockAmount { get; set; }

        
    }
}
