using System;

namespace _7.ciclowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Esctibir un algoritmo que permita generar los primeros 5 números enteros positivos y realizar y mostrar su suma.

            int contador = 1;
            int acumulador = 1;

            while (contador <5)
            {
                contador++;
                acumulador += contador;
            }

            Console.WriteLine($"La suma de los primeros 5 números enteros positivos es: {acumulador}");

            //2. Crear un algoritmo que permita calcular el factorial de un número dado por el usuario.

            int contador2 = 1;            
            int acumulador2 = 1;
            int numUsuario = 0;

            Console.WriteLine("Ingrese un número para calcular su factorial: ");
            numUsuario = int.Parse(Console.ReadLine());

            while (contador2 < numUsuario)
            {
                contador2++;
                acumulador2 *= contador2;
            }

            Console.WriteLine($"El factorial de {numUsuario} es: {acumulador2}");
        }
    }
}
