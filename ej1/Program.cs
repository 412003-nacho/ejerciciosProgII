// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ej1;
using System.Collections.Concurrent;

Console.WriteLine("----------PILAS----------");
Pila pila = new Pila(3);

Console.WriteLine("Está vacía?: " + pila.estaVacia());
Console.WriteLine("--------------------");
Console.WriteLine("Se añaden 3 objetos: ");
pila.añadir("objeto1");
pila.añadir("objeto2");
pila.añadir("objeto3");
for (int i = 0; i < pila.elementos.Length; i++)
{
    Console.WriteLine(pila.elementos[i]);
}
Console.WriteLine("--------------------");
pila.extraer();
Console.WriteLine("Se extrae el primer objeto");
for (int i = 0; i < pila.elementos.Length; i++)
{
    Console.WriteLine(pila.elementos[i]);
}
Console.WriteLine("--------------------");
Console.WriteLine("Está vacía?: " + pila.estaVacia());
Console.WriteLine("--------------------");
Console.WriteLine("Primero: " + pila.primero());
Console.WriteLine("");
Console.WriteLine("----------COLAS----------");

Cola cola = new Cola();
Console.WriteLine("Está vacía?: " + cola.estaVacia());
Console.WriteLine("--------------------");
Console.WriteLine("Se añaden 2 objetos: ");
cola.añadir("1cola");
cola.añadir("2cola");

for (int i = 0; i < cola.elementos.Count; i++)
{
    Console.WriteLine(cola.elementos[i]);
}
Console.WriteLine("--------------------");
Console.WriteLine("Está vacía?: " + cola.estaVacia());
Console.WriteLine("--------------------");
Console.WriteLine("El primer objeto es: " + cola.primero());
