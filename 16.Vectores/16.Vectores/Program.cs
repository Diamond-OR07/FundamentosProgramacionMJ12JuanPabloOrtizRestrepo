
using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[15];
        int mayor; 
        int menor;
        int posicionMayor = 0;
        int posicionMenor = 0;

        // Ingresar los 15 numeros
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("Por favor ingrese el numero " + (i + 1) + ":");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Mostrar todos los elementos del arreglo
        Console.WriteLine("\nElementos del arreglo (vector):");

        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("Posicion " + i + ": " + numeros[i]);
        }

        // Inicializar el mayor y el menor
        mayor = numeros[0];
        menor = numeros[0];

        // Buscar el mayor y el menor
        for (int i = 1; i < 15; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                posicionMayor = i;
            }

            if (numeros[i] < menor)
            {
                menor = numeros[i];
                posicionMenor = i;
            }
        }

        // Mostrar los resultados
        Console.WriteLine("\nEl numero mayor es: " + mayor);
        Console.WriteLine("Su posicion dentro del arreglo (vector) es: " + posicionMayor);

        Console.WriteLine("\nEl numero menor es: " + menor);
        Console.WriteLine("Su posicion dentro del arreglo (vector) es: " + posicionMenor);
    }
}
