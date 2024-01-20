using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKopeklerimConsoleApp.Entities.Bases
{
    public abstract class Kayit
    {
        public int Id { get; set; }

        protected Kayit(int id)
        {
            Id = id;
        }

        protected Kayit()
        {
                
        }
    }
}
