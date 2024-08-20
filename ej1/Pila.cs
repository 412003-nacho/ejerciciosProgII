using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1
{
    public class Pila : ICollection
    {
        public Object[] elementos;
        int contador;
        public Pila(int tamaño)
        {
            elementos = new Object[tamaño];
            contador = 0;
        }
        public bool añadir(object obj)
        {
            if (contador < elementos.Length)
            {
                elementos[contador] = obj;
                contador++;
                return true;
            }
            else { return false; }
        }
        public bool estaVacia()
        {
            if (elementos[0] == null) 
            { return true; }
            else
            { return false; }
        }
        public object extraer()
        {
            Object primero = elementos[0];
            for (int i = 0; i < contador; i++)
            {
                if(i != elementos.Length - 1)
                    { elementos[i] = elementos[i + 1]; }
                else
                {
                    elementos[i] = null;
                }
            }
            contador--;
            return primero;
        }
        public object primero()     
        {
            return elementos[0];
        }
    }
}
