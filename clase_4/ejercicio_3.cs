using System;
using System.Collections.Generic;

class Ejercicio3
{
    static void Main()
    {
        List<string> nombres = new List<string> {
            "Ana", "Jezabel", "Maxi", "Ariel", "Martina", "Sol", "Fernando"
        };

        string nombreMasLargo = nombres[0];
        string nombreMasCorto = nombres[0];

        foreach (string nombre in nombres)
        {
            if (nombre.Length > nombreMasLargo.Length)
                nombreMasLargo = nombre;

            if (nombre.Length < nombreMasCorto.Length)
                nombreMasCorto = nombre;
        }

        Console.WriteLine("Nombre mas largo: " + nombreMasLargo);
        Console.WriteLine("Nombre mas corto: " + nombreMasCorto);
    }
}
