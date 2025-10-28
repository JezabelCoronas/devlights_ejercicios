using System;

class Ejercicio6
{
    static void Main()
    {
        int[,] temperaturas = new int[5, 7];
        Random rnd = new Random();
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        // 1. Cargar matriz con temperaturas aleatorias
        for (int semana = 0; semana < 5; semana++)
        {
            for (int dia = 0; dia < 7; dia++)
            {
                temperaturas[semana, dia] = rnd.Next(7, 39); // entre 7 y 38 inclusive
            }
        }

        int tempMaxMes = 0;
        string diaMaxMes = "";
        int semanaMaxMes = 0;

        // 2. Procesar cada semana
        for (int semana = 0; semana < 5; semana++)
        {
            int tempMaxSemana = temperaturas[semana, 0];
            int tempMinSemana = temperaturas[semana, 0];
            int diaMax = 0;
            int diaMin = 0;
            int sumaSemana = 0;

            for (int dia = 0; dia < 7; dia++)
            {
                int temp = temperaturas[semana, dia];
                sumaSemana += temp;

                if (temp > tempMaxSemana)
                {
                    tempMaxSemana = temp;
                    diaMax = dia;
                }

                if (temp < tempMinSemana)
                {
                    tempMinSemana = temp;
                    diaMin = dia;
                }

                if (temp > tempMaxMes)
                {
                    tempMaxMes = temp;
                    diaMaxMes = dias[dia];
                    semanaMaxMes = semana + 1;
                }
            }

            double promedio = (double)sumaSemana / 7;
            Console.WriteLine($"\n📅 Semana {semana + 1}:");
            Console.WriteLine($"🔥 Máxima: {tempMaxSemana}°C el {dias[diaMax]}");
            Console.WriteLine($"❄️ Mínima: {tempMinSemana}°C el {dias[diaMin]}");
            Console.WriteLine($"📊 Promedio: {promedio:F2}°C");
        }

        Console.WriteLine($"\n🌡️ Temperatura más alta del mes: {tempMaxMes}°C el {diaMaxMes} (Semana {semanaMaxMes})");
    }
}
