using System;

namespace Binario_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            // Convertir a binario
            string binario = Convert.ToString(numero, 2);
            Console.WriteLine($"El número {numero} en binario es: {binario}");

            // Convertir a hexadecimal
            string hexadecimal = Convert.ToString(numero, 16);
            Console.WriteLine($"El número {numero} en hexadecimal es: {hexadecimal}");
        }
    }
}
