using Polymorphism.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class PlayStationOyunu:VideoOyunu
    {
        public byte[] Modelleri {  get; set; }
    }
}
