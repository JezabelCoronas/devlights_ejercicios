using System;
using System.Collections.Generic;

class Ejercicio11
{
    static void Main()
    {
        List<string> productos = new List<string>();
        Dictionary<string, int> stock = new Dictionary<string, int>();
        Stack<string> historial = new Stack<string>();

        while (true)
        {
            Console.WriteLine("\n Inventario:");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Vender producto");
            Console.WriteLine("3. Mostrar inventario");
            Console.WriteLine("4. Ver últimas 3 acciones");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Nombre del producto: ");
                string nombre = Console.ReadLine();

                Console.Write("Cantidad: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                if (!productos.Contains(nombre))
                    productos.Add(nombre);

                if (stock.ContainsKey(nombre))
                    stock[nombre] += cantidad;
                else
                    stock[nombre] = cantidad;

                historial.Push($" Agregado: {nombre} ({cantidad})");
            }
            else if (opcion == "2")
            {
                Console.Write("Producto a vender: ");
                string nombre = Console.ReadLine();

                Console.Write("Cantidad: ");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                if (stock.ContainsKey(nombre) && stock[nombre] >= cantidad)
                {
                    stock[nombre] -= cantidad;
                    historial.Push($" Vendido: {nombre} ({cantidad})");
                }
                else
                {
                    Console.WriteLine(" Producto no disponible o stock insuficiente.");
                }
            }
            else if (opcion == "3")
            {
                Console.WriteLine("\nInventario actual:");
                foreach (string prod in productos)
                {
                    int cant = stock.ContainsKey(prod) ? stock[prod] : 0;
                    Console.WriteLine($"- {prod}: {cant} unidades");
                }
            }
            else if (opcion == "4")
            {
                Console.WriteLine("\n Ultimas 3 acciones:");
                int count = 0;
                foreach (string accion in historial)
                {
                    Console.WriteLine(accion);
                    count++;
                    if (count == 3) break;
                }
            }
            else if (opcion == "5")
            {
                Console.WriteLine(" Saliendo del sistema.");
                break;
            }
            else
            {
                Console.WriteLine("Opción invalida");
            }
        }
    }
}
