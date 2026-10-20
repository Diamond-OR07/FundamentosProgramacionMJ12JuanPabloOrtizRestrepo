using System;


namespace _10.CicloWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1, 101);
            int intento = 0;

            while (intento != numeroSecreto)
            {
                Console.WriteLine("Adivina el numero entre 1 y 100:");
                intento = int.Parse(Console.ReadLine());

                if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("¡Correcto! Adivinaste el numero.");
                }
            }
        }
    }
}
