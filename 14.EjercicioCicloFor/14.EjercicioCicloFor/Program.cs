
using System;

class Program
{
    static void Main()
    {
        int inicio;
        int fin;

        Console.WriteLine("Por favor ingrese el numero inicial del rango: ");
        inicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Por favor ingrese el numero final del rango: ");
        fin = int.Parse(Console.ReadLine());

        Console.WriteLine("Los multiplos de 5 dentro del rango dado son: ");

        for (int i = inicio; i <= fin; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
