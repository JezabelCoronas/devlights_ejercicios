using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        List<int> edades = new List<int> { 15, 22, 17, 18, 30, 12, 19, 25, 16, 21, 14, 18, 20, 13, 19, 23, 17, 18, 16, 22 };
        int mayores = 0;
        int menores = 0;

        foreach (int edad in edades)
        {
            if (edad >= 18)
                mayores++;
            else
                menores++;
        }

        Console.WriteLine("Mayores de edad: " + mayores);
        Console.WriteLine("Menores de edad: " + menores);
    }
}
