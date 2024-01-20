using DemoKopeklerimConsoleApp.Entities.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKopeklerimConsoleApp.Repositories.Bases
{
    public interface IRepo
    {
        Kayit KayitGetir(int id);
    }
}
