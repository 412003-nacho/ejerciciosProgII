using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    public class Cola : ICollection
    {
        public List<Object> elementos;
        public Cola()
        {
            elementos = new List<Object>();
        }
        public bool añadir(object obj)
        {
            elementos.Add(obj);
            return true;
        }

        public bool estaVacia()
        {
            if (elementos.Count == 0) {  return true; }
            else { return false; }
        }

        public Object extraer()
        {
            Object primero = elementos[0];
            if (elementos.Count > 0)
            {
                elementos.RemoveAt(0);
            }
            return primero;
        }
        public Object primero()
        {
            if (elementos.Count > 0)
            {
                return elementos[0];
            }
            else { return "No hay nada en la cola"; }
        }
    }
}
