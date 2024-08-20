using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    public interface ICollection
    {
        public bool estaVacia();
        public Object extraer();
        public Object primero();
        public bool añadir(Object obj);
    }
}
