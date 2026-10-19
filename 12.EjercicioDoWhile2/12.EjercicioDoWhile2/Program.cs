using System;

namespace _12.EjercicioDoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente:
            //1.Si el saldo es mayor o igual a 3'000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "Es apto para el credito"
            //2.Si el saldo es menor a 3'000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "No es apto para el crédito"
            //El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no desea preguntar más.Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.

            string nombre;
            int numeroCuenta;
            int saldo;
            double promedio;
            int cont = 0;
            int acum = 0;
            char respuesta;

            do 
            {
                Console.WriteLine("Por favor ingrese su nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Por favor ingrese su número de cuenta: ");
                numeroCuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("Por favor ingrese su saldo: ");
                saldo = int.Parse(Console.ReadLine());

                if (saldo >= 3000000)
                {
                    Console.WriteLine($"{nombre}, {numeroCuenta}, {saldo} - Es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"{nombre}, {numeroCuenta}, {saldo} - No es apto para el crédito");
                }

                cont++;
                acum += saldo;

                Console.WriteLine("¿Desea ingresar otro usuario? (s/n): ");
                respuesta = char.Parse(Console.ReadLine());
            }
            while (respuesta == 's' || respuesta == 'S');

            promedio = (double)acum / cont;
            Console.WriteLine($"Número de usuarios: {cont}");
            Console.WriteLine($"Promedio de saldos: {promedio}");
        }
    }
}
