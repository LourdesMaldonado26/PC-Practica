using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desglosar una cantidad en quetzales a billetes y monedas.");
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese su número de carné: ");
        string carne = Console.ReadLine();
        Console.WriteLine($"{nombre} - {carne}");
        
        Console.Write("Ingrese una cantidad en quetzales: ");
        double cantidad = Convert.ToDouble(Console.ReadLine());

        // Desglose
        int billetes100 = (int)cantidad / 100;
        cantidad -= billetes100 * 100;
        int billetes50 = (int)cantidad / 50;
        cantidad -= billetes50 * 50;
        int billetes20 = (int)cantidad / 20;
        cantidad -= billetes20 * 20;
        int billetes10 = (int)cantidad / 10;
        cantidad -= billetes10 * 10;
        int billetes5 = (int)cantidad / 5;
        cantidad -= billetes5 * 5;
        int monedas1 = (int)cantidad / 1;
        cantidad -= monedas1 * 1;
        int monedas25c = (int)(cantidad / 0.25);
        cantidad -= monedas25c * 0.25;
        int monedas1c = (int)Math.Round(cantidad / 0.01);

        // Mostrar desglose
        Console.WriteLine("Desglose en billetes y monedas:");
        Console.WriteLine($"Billetes de Q100: {billetes100}");
        Console.WriteLine($"Billetes de Q50: {billetes50}");
        Console.WriteLine($"Billetes de Q20: {billetes20}");
        Console.WriteLine($"Billetes de Q10: {billetes10}");
        Console.WriteLine($"Billetes de Q5: {billetes5}");
        Console.WriteLine($"Monedas de Q1: {monedas1}");
        Console.WriteLine($"Monedas de 25 centavos: {monedas25c}");
        Console.WriteLine($"Monedas de 1 centavo: {monedas1c}");

        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
    }
}