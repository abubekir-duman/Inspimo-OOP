using ElektronikDemo.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElektronikDemo.Models
{
    public class EvSinemaSistemi:ElektronikEsya
    {
        public byte HoparlorSayisi { get; set; }

        public short Guc { get; set; }
    }
}
