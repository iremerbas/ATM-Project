using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_Uygulamasi
{
    internal interface Icrud<T>
    {
        bool Add(T entity);
        bool Delete(int id);
        T Detail(int id);
        List<T> List();
    }
}
