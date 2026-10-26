
using System;

class Seccion2
{
    static void Main()
    {
        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };

        int suma = 0;

        foreach (int nota in calificaciones)
        {
            suma += nota;
        }

        double promedio = (double)suma / calificaciones.Length;

        Console.WriteLine("=== CONTROL DE ACCESO ===");

        int intentos = 0;
        string clave = "sena2026";
        string entrada = "";

        while (entrada != clave && intentos < 3)
        {
            Console.Write("Ingresa la clave: ");
            entrada = Console.ReadLine() ?? "";
            intentos++;

            if (entrada != clave && intentos < 3)
            {
                Console.WriteLine(
                    $"Clave incorrecta. Intentos restantes: {3 - intentos}"
                );
            }
        }

        if (entrada != clave)
        {
            Console.WriteLine("Acceso bloqueado.");
            return;
        }

        Console.WriteLine("Acceso concedido.");

        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");

            string respuesta = Console.ReadLine() ?? "";

            if (!int.TryParse(respuesta, out opcion))
            {
                opcion = 0;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Promedio del grupo: {promedio:F1}");
                    break;

                case 2:
                    int mayor = calificaciones[0];

                    foreach (int nota in calificaciones)
                    {
                        if (nota > mayor)
                        {
                            mayor = nota;
                        }
                    }

                    Console.WriteLine($"Calificación más alta: {mayor}");
                    break;

                case 3:
                    Console.WriteLine("Hasta luego.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

        } while (opcion != 3);
    }
}
