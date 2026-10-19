using System;

namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo For 
            int acumulador = 0;

            for (int contador=1;contador<=5; contador++)
            {
                acumulador += contador;
            } 
            Console.WriteLine($"La suma de los primeros números es: {acumulador}");

            //2. Algoritmo que te permita pedirle un número al usuario y calcular la factorial del número ingresado. Ej: 5! = 1x2x3x4x5

            int acumulador2 = 1;
            int numUsuario = 0;

            Console.WriteLine("Digita un número para saber cual es su factorial");
            numUsuario = int.Parse(Console.ReadLine());

            for (int contador2 = 1; contador2 <= numUsuario; contador2++)
            {
                acumulador2 *= contador2;
            }
            Console.WriteLine($"El exponencial de su número es: {acumulador2}");
        }
    }
}
