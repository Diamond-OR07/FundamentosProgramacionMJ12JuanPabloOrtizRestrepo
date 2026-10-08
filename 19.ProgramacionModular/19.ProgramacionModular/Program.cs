using System;

namespace _19.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpcion());
        }

        static float Division()
        {
            Console.WriteLine("Ingrese el número 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            float numero2 = float.Parse(Console.ReadLine());

            return numero1 / numero2;
        }

        static float Resta()
        {
            Console.WriteLine("Ingrese el número 1");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            float numero2 = float.Parse(Console.ReadLine());

            return numero1 - numero2;
        }

        static float Multiplicacion()
        {
            int numero = 0;
            int multiplicacion = 1;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("¿Deseas multiplicar más números? pulsa s para continuar y n para parar:");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicacion;
        }

        static float Suma()
        { 
            int numero = 0;
            int suma = 0;
            char respuesta = ' ';
            do
            {
               Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("¿Deseas sumar más números? pulsa s para continuar y n para parar:");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }

        static void RealizarOperaciones(int opcion)
        {
            while(opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La SUMA de los números que ingreso es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La RESTA de los números que ingreso es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La MULTIPLICACIÓN de los números que ingreso es: {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"La DIVISIÓN de los números que ingreso es: {Division()}");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();
            }
        }

        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }

        static void MostrarMenu()
        {
            Console.WriteLine("-----------------MENÚ-----------------");
            Console.WriteLine("1. Suma                  2. Resta");
            Console.WriteLine("3. Multiplicación        4. División");
            Console.WriteLine("0. Salir");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ingrese una opción del menú");
        }


    }
}
