using System;

namespace _20.ProgramacionModular
{
    internal class Program
    {
        static void Main()
        {
            int fila;
            int columna;

            Console.WriteLine("Ingrese la cantidad de filas:");
            fila = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de columnas:");
            columna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[fila, columna];

            LlenarMatriz(matriz, fila, columna);
            MostrarMatriz(matriz, fila, columna);
        }
        // Modulo que ingresa los valores de la matriz
        static void LlenarMatriz(int[,] matriz, int fila, int columna)
        {
            int numero;

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.WriteLine("Ingrese un multiplo de 5 para la posicion [" + i + "," + j + "]: ");
                    numero = int.Parse(Console.ReadLine());

                    while (numero % 5 != 0)
                    {
                        Console.WriteLine("El numero no es multiplo de 5. Por favor intentelo de nuevo: ");
                        numero = int.Parse(Console.ReadLine());
                    }

                    matriz[i, j] = numero;
                }
            }
        }

        // Modulo para mostrar la matriz
        static void MostrarMatriz(int[,] matriz, int fila, int columna)
        {
            Console.WriteLine("\nMatriz completa:");

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
