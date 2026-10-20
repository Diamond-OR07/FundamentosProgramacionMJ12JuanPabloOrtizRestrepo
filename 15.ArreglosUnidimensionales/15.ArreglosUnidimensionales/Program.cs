using System;

namespace _15.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidimensionales - vectores
            //int[] numeros= new int[5];

            //numeros[0] = 1;
            //numeros[1] = 2;
            //numeros[2] = 3;
            //numeros[3] = 4;
            //numeros[4] = 5;
            //numeros[5] = 14; no se puede almacenar porque es una posición que no existe

            //Console.WriteLine($"El número almacenado en la posición 3 con indice 2 es: {numeros[2]}");

            //Otras formas de declarar e inicializar vectores


            // Crear arreglo llamado numeros de 100 elementos asignar el número 10 en cada una de las posiciones del arrreglo, leer el contenido de cada elemento y escribirlo en pantalla.


            int[] numeros = new int[100];
            for (int i = 0; i < numeros.Length; i++)
            {

                numeros[i] = 10;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} |");
            }

            //Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo, al final, debe visualizar el promedio de esos números.

            double[] numeros2 = new double[10];
            double suma = 0;
            double promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n\nIngrese el numero " + (i + 1) + ":");
                numeros2[i] = double.Parse(Console.ReadLine());

                suma = suma + numeros2[i];
            }

            promedio = suma / 10;

            Console.WriteLine("\n\nEl promedio es: " + promedio);
        }
    }

    
}
