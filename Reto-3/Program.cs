
using System;

class Seccion3
{
    static void Main()
    {
        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        Console.WriteLine("=== PRIMERA CALIFICACIÓN REPROBATORIA ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 60)
            {
                Console.WriteLine(
                    $"Reprobado en la posición {i + 1}: {calificaciones[i]}"
                );

                break;
            }
        }

        Console.WriteLine("\n=== CALIFICACIONES APROBATORIAS ===");

        int aprobados = 0;

        foreach (int nota in calificaciones)
        {
            if (nota < 60)
            {
                continue;
            }

            Console.WriteLine($"Aprobada: {nota}");
            aprobados++;
        }

        Console.WriteLine($"Total de estudiantes aprobados: {aprobados}");

        Console.WriteLine("\n=== FILTRADO CON BREAK Y CONTINUE ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            if (calificaciones[i] < 70)
            {
                continue;
            }

            if (calificaciones[i] >= 95)
            {
                break;
            }

            Console.WriteLine($"Calificación procesada: {calificaciones[i]}");
        }
    }
}
