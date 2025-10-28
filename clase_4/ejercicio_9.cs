using System;
using System.Collections.Generic;
using System.Linq;

class Ejercicio9
{
    static void Main()
    {
        Dictionary<string, double> calificaciones = new Dictionary<string, double>();

        Console.WriteLine("Ingrese alumnos y sus notas. Escriba 'fin' para finalizar...");

        while (true)
        {
            Console.Write("Nombre del alumno: ");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "fin")
                break;

            Console.Write("Nota: ");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                calificaciones[nombre] = nota;
            }
            else
            {
                Console.WriteLine("Nota inválida");
            }
        }

        // Mostrar promedio general
        double promedio = calificaciones.Values.Average();
        Console.WriteLine($"\n Promedio general del curso: {promedio:F2}");

        // Mejor y peor nota
        var mejor = calificaciones.OrderByDescending(x => x.Value).First();
        var peor = calificaciones.OrderBy(x => x.Value).First();

        Console.WriteLine($"Mejor nota: {mejor.Key} con {mejor.Value}");
        Console.WriteLine($"Peor nota: {peor.Key} con {peor.Value}");
    }
}
