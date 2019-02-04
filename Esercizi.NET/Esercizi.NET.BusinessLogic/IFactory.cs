using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi.NET.BusinessLogic
{
    public interface IFactory<T>
    {
        T Create();
    }
}
