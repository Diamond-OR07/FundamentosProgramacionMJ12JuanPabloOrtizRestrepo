using System;

namespace _8.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que el usuario ingrese un número negativo. Se debe mostrar en pantalla el total de la suma de los números ingresados.
            int sumaEnteros = 0;
            int numero = 0;
            Console.WriteLine("Ingrese números enteros positivos para sumarlos. Ingrese un número negativo para finalizar.");
            numero = int.Parse(Console.ReadLine());
            while (numero >= 0)
            {
                sumaEnteros += numero;
                Console.WriteLine("Ingrese otro número entero positivo para sumarlo. Ingrese un número negativo para finalizar.");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La suma total de los números ingresados es: " + sumaEnteros);
        }
    }
}
