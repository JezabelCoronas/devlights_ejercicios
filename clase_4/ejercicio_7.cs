using System;

class Ejercicio7
{
    static void Main()
    {
        int[,] matriz = new int[10, 10];

        // Cargar encabezados (fila 0 y columna 0)
        for (int i = 0; i < 10; i++)
        {
            matriz[0, i] = i; // primera fila
            matriz[i, 0] = i; // primera columna
        }

        // Calcular multiplicaciones
        for (int fila = 1; fila < 10; fila++)
        {
            for (int columna = 1; columna < 10; columna++)
            {
                matriz[fila, columna] = fila * columna;
            }
        }

        // Mostrar la matriz
        Console.WriteLine("📊 Tablas de multiplicar del 1 al 9:\n");
        for (int fila = 0; fila < 10; fila++)
        {
            for (int columna = 0; columna < 10; columna++)
            {
                Console.Write($"{matriz[fila, columna],3} ");
            }
            Console.WriteLine();
        }
    }
}
