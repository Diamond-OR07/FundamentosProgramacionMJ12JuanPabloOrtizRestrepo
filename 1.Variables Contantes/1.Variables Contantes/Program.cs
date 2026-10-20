using System;

namespace _1.Variables_Contantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double sueldo;

            Console.WriteLine("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo de la persona para saber si debe abonar impuestos: ");
            sueldo = double.Parse(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine(nombre + " debe abonar impuestos.");
            } 
        }
    }
}
