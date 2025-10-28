using System;

class Ejercicio5
{
    static void Main()
    {
        char[,] matriz = new char[5, 5];

        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                int posicion = fila * 5 + columna; // Posición lineal
                matriz[fila, columna] = (posicion % 2 == 0) ? 'P' : 'I';
            }
        }

        // Mostrar la matriz
        Console.WriteLine(" Matriz 5x5 con 'P' y 'I':\n");
        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                Console.Write(matriz[fila, columna] + " ");
            }
            Console.WriteLine();
        }
    }
}
