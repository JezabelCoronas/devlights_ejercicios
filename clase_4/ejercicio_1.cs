using System;
using System.Collections.Generic;

class Ejercicio1
{
    static void Main()
    {
        List<int> notas = new List<int>() { 8, 7, 9, 10, 6, 7, 8, 9, 10, 7 };
        int suma = 0;

        foreach (int nota in notas)
        {
            Console.WriteLine("Nota: " + nota);
            suma += nota;
        }

        double promedio = (double)suma / notas.Count;
        Console.WriteLine("Promedio: " + promedio);
    }
}
