using AbstarctClassesDemo1.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctClassesDemo1
{
    public class MüzikDersi : DersBase
    {
        public override string KodGetir() => "MZK-" + Id;

        public override byte MaksimumNotGetir() => 10;
        

    }
}
