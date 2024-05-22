using System;

class Program
{
     static void Main(string[] args)
 {
     Console.WriteLine("Mi segundo programa");

     Console.WriteLine("Inrese su nombre");
     string Nombre = Console.ReadLine();
     Console.WriteLine("Nombre:" + Nombre);

     Console.WriteLine("Ingrese su edad");
     string Edad = Console.ReadLine();
     Console.WriteLine("Edad:" + Edad);

     Console.WriteLine("Ingrese su carrera");
     string Carrera = Console.ReadLine();
     Console.WriteLine("Carrera:" + Carrera);

     Console.WriteLine("Ingrese su número de carné");
     string Carné = Console.ReadLine();
     Console.WriteLine("Carné:" + Carné);

     Console.ReadKey();
 }
}