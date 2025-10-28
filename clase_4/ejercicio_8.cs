using System;
using System.Collections.Generic;

class Ejercicio8
{
    static void Main()
    {
        char[,] tablero = new char[10, 10];
        int cantidadX = 10; 
        int fallos = 0;
        int aciertos = 0;
        List<(int, int)> posicionesX = new List<(int, int)>();
        Random rnd = new Random();

        // Inicializar tablero con '*'
        for (int fila = 0; fila < 10; fila++)
            for (int col = 0; col < 10; col++)
                tablero[fila, col] = '*';

        // Esconder X en posiciones aleatorias
        while (posicionesX.Count < cantidadX)
        {
            int f = rnd.Next(0, 10);
            int c = rnd.Next(0, 10);
            if (!posicionesX.Contains((f, c)))
                posicionesX.Add((f, c));
        }

        Console.WriteLine("Adivina donde están las X (matriz 10x10)");
        Console.WriteLine($"Tenés {cantidadX} intentos. Solo podés fallar 3 veces");

        while (aciertos < cantidadX && fallos < 3)
        {
            Console.Write("Fila (0-9): ");
            int fila = Convert.ToInt32(Console.ReadLine());

            Console.Write("Columna (0-9): ");
            int col = Convert.ToInt32(Console.ReadLine());

            if (posicionesX.Contains((fila, col)))
            {
                tablero[fila, col] = 'X';
                aciertos++;
                Console.WriteLine("Acertaste");
            }
            else
            {
                fallos++;
                Console.WriteLine("Fallaste");
            }

            Console.WriteLine($"Aciertos: {aciertos} | Fallos: {fallos}\n");
        }

        // Mostrar tablero final
        Console.WriteLine("Tablero final:");
        for (int fila = 0; fila < 10; fila++)
        {
            for (int col = 0; col < 10; col++)
            {
                if (tablero[fila, col] != 'X')
                    Console.Write("* ");
                else
                    Console.Write("X ");
            }
            Console.WriteLine();
        }

        Console.WriteLine(aciertos == cantidadX
            ? "\n Ganaste!!"
            : "\n Fin-Se agotaron tus intentos");
    }
}
