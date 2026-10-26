
using System;

class Seccion1
{
    static void Main()
    {
        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        int suma = 0;
        double promedio;

        Console.WriteLine("=== REGISTRO DE CALIFICACIONES ===");

        for (int i = 0; i < calificaciones.Length; i++)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        Console.WriteLine("\n=== ORDEN DESCENDENTE ===");

        for (int i = calificaciones.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Estudiante {i + 1}: {calificaciones[i]}");
        }

        Console.WriteLine("\n=== PROMEDIO DEL GRUPO ===");

        foreach (int nota in calificaciones)
        {
            suma += nota;
        }

        promedio = (double)suma / calificaciones.Length;

        Console.WriteLine($"Suma total: {suma}");
        Console.WriteLine($"Promedio: {promedio:F1}");

        Console.WriteLine("\n=== POSICIONES PARES ===");

        for (int i = 0; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine($"Posición par: {calificaciones[i]}");
        }
    }
}
