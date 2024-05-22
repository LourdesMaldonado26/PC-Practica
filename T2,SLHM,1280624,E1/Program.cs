using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Este programa calcula la velocidad final, velocidad inicial, aceleración y tiempo.");
        Console.WriteLine("Ingrese tres valores y el programa calculará el cuarto.");
        Console.WriteLine("Si el valor es desconocido, ingrese -1 para ese valor.");

        Console.Write("Ingrese la velocidad inicial (m/s) o -1 si es desconocido: ");
        double velocidadInicial = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la aceleración (m/s^2) o -1 si es desconocido: ");
        double aceleracion = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo (s) o -1 si es desconocido: ");
        double tiempo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la velocidad final (m/s) o -1 si es desconocido: ");
        double velocidadFinal = Convert.ToDouble(Console.ReadLine());

        // Calcular el valor desconocido
        if (velocidadInicial == -1)
        {
            velocidadInicial = velocidadFinal - aceleracion * tiempo;
            Console.WriteLine($"La velocidad inicial calculada es: {velocidadInicial} m/s");
        }
        else if (aceleracion == -1)
        {
            aceleracion = (velocidadFinal - velocidadInicial) / tiempo;
            Console.WriteLine($"La aceleración calculada es: {aceleracion} m/s^2");
        }
        else if (tiempo == -1)
        {
            tiempo = (velocidadFinal - velocidadInicial) / aceleracion;
            Console.WriteLine($"El tiempo calculado es: {tiempo} s");
        }
        else if (velocidadFinal == -1)
        {
            velocidadFinal = velocidadInicial + aceleracion * tiempo;
            Console.WriteLine($"La velocidad final calculada es: {velocidadFinal} m/s");
        }
        else
        {
            Console.WriteLine("Todos los valores han sido ingresados, no hay nada que calcular.");
        }

        Console.WriteLine("Presione cualquier tecla para finalizar.");
        Console.ReadKey();
    }
}