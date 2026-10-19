using System;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
            //pantalla la suma de los elementos de cada columna.
            int filas = 10;
            int columnas = 20;
            int[,] matriz = new int[filas, columnas];

            Random random = new Random();

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = random.Next(1, 10);
                }
            }

            Console.WriteLine("--- Suma de cada columna ---");
            for (int c = 0; c < columnas; c++)
            {
                int sumaColumna = 0;
                for (int f = 0; f < filas; f++)
                {
                    sumaColumna += matriz[f, c];
                }
                Console.WriteLine($"Columna {c + 1}: {sumaColumna}");
            }

            //2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
            //caracteres en cada posición de la matriz hasta llenarla.El programa debe intercambiar la
            //primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            //matriz con el intercambio de filas.




        }
    }
}
