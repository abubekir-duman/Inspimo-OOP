using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Interfaces
{
    public interface IKisi
    {
        public string TcKimlikNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Getir();

    }
}
