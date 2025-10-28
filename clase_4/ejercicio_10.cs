using System;
using System.Collections.Generic;

class Ejercicio10
{
    static void Main()
    {
        Queue<string> clientes = new Queue<string>();

        Console.WriteLine(" Ingrese los nombres de los clientes. Escriba 'fin' para terminar...");

        // Encolar clientes
        while (true)
        {
            Console.Write("Cliente: ");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "fin")
                break;

            clientes.Enqueue(nombre);
        }

        Console.WriteLine("\n Atención en ventanilla:");

        // Atender clientes
        while (clientes.Count > 0)
        {
            string atendido = clientes.Dequeue();
            Console.WriteLine($" Atendiendo a: {atendido}");
            Console.WriteLine($"Clientes restantes: {clientes.Count}\n");
        }

        Console.WriteLine(" Todos los clientes fueron atendidos.");
    }
}
