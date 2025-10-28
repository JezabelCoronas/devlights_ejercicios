using System;
using System.Collections.Generic;

class Ejercicio4
{
    static void Main()
    {
        // Lista base del supermercado
        List<string> listaSupermercado = new List<string> { "pan", "leche", "arroz", "huevos", "manzanas" };

        // Lista de elementos comprados por el usuario
        List<string> comprados = new List<string>();

        Console.WriteLine("Lista del supermercado: " + string.Join(", ", listaSupermercado));
        Console.WriteLine("Ingresá los productos que compraste. Escribí 'fin' para terminar.");

        while (true)
        {
            Console.Write("Producto: ");
            string producto = Console.ReadLine().ToLower();

            if (producto == "fin")
                break;

            comprados.Add(producto);

            if (listaSupermercado.Contains(producto))
            {
                listaSupermercado.Remove(producto);
                Console.WriteLine($"✅ '{producto}' estaba en la lista. Se eliminó.");
            }
            else
            {
                Console.WriteLine($"➕ '{producto}' no estaba en la lista. Se agregó como nuevo.");
            }
        }

        // Mostrar resultados
        Console.WriteLine("\n📌 Elementos que NO compraste:");
        Console.WriteLine(string.Join(", ", listaSupermercado));

        Console.WriteLine("\n📌 Elementos que compraste pero NO estaban en la lista:");
        foreach (string item in comprados)
        {
            if (!listaSupermercado.Contains(item))
                Console.WriteLine(item);
        }

        Console.WriteLine("\n📦 Todos los productos que compraste:");
        Console.WriteLine(string.Join(", ", comprados));
    }
}
