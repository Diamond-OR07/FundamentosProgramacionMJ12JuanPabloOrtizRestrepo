using System;

namespace _17.ArreglosBidimensionales_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales - Matrices
            int[,] numeros = new int[2, 3]; //Declaración de una matriz

            //numeros[2, 1] = 23; No se puede almacenar porque el indice de la fila no existe
            //numeros[1, 3] = 54; No se puede almacenar porque el indice de la columna no existe
            numeros[0, 0] = 25;
            numeros[0, 1] = 41;
            numeros[0, 2] = 104;
            numeros[1, 0] = 47;
            numeros[1, 1] = 56;
            numeros[1, 2] = 6;

            Console.WriteLine($"El valor almacenado en la posición [1, 1] es: {numeros[1, 1]}");
            char[,] simbolos = new char[3, 4];

            //Recorrer para rellenar
            for (int i = 0; i < 3; i++)//Recorre las filas
            {
                for (int j = 0; j < 2; j++)//Recorre las columnas
                {
                    Console.WriteLine($"Ingrese un caracter para la posición [{i}, {j}]: ");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer para recuperar
            for (int i = 0; i < simbolos.GetLength(0); i++)//Recorre las filas
            {
                for (int j = 0; j < simbolos.GetLength(1); j++)//Recorre las columnas
                {
                    Console.WriteLine($"{simbolos[i, j]} |");
                }
                Console.WriteLine();
            }
            //Crear una matriz[10,20], en cada posición de la matriz poner el número 100; mostrar la matriz en consola
        }
    }
}
