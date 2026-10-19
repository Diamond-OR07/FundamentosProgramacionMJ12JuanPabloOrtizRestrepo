using System;

namespace _9.CicloWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar un algoritmo que solicite al usuario ingresar por teclado números enteros
            // al azar, al usuario le corresponde ingresar la cantidad de números que va aintroducir.
            // El algoritmo debe escribir en pantalla:
            // a) La cantidad de números introducidos que son mayores a 0. 
            // b) La cantidad de números introducidos que son menores a 0.
            // c) La cantidad de números introducidos que son iguales a 0.

            //int cantidadNumeros = 0;
            //int contador = 0;
            //int numero = 0;
            //int contadorCero = 0;
            //int contadorPositivos = 0;
            //int contadorNegativos = 0;
            //Console.WriteLine("Ingrese la cantidad de números a evaluar: ");
            //cantidadNumeros = int.Parse(Console.ReadLine());

            //while (contador < cantidadNumeros)
            //{
            //    contador++;
            //    Console.WriteLine("Ingrese un número entero: ");
            //    numero = int.Parse(Console.ReadLine());
            //    if (numero == 0)
            //    {
            //        contadorCero++;
            //    }
            //    else if (numero < 0)
            //    {
            //        contadorNegativos++;
            //    }
            //    else
            //    {
            //        contadorPositivos++;
            //    }

            //}

            //Console.WriteLine($"Cantidad de números mayores a 0: {contadorPositivos}, menores que 0: {contadorNegativos} e iguales a 0: {contadorCero}");

            //2. Escribir un algoritmo que cuente cuantos que cuente cuantos números pares hay en un rango de números del 1 al número n. (Operador mod en C#).

            int cantidadNumeros = 0;
            int contador = 0;
            int numero = 0;

            Console.WriteLine("Para conocer los números pares en un rango, ingrese el número entero n hasta donde ira el rango a partir de 1: ");
            cantidadNumeros = int.Parse(Console.ReadLine());
            while (contador < cantidadNumeros)
            {
                contador++;
                if (contador % 2 == 0)
                {

                }
            }
        }
    }
}

