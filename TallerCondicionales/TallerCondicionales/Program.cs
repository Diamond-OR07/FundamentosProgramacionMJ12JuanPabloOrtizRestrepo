using System;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bool invencible;

            Console.Write("¿El personaje está invencible? (true/false): ");
            invencible = bool.Parse(Console.ReadLine());

            Random rnd = new Random();
            int municion = rnd.Next(1, 11);

            Console.WriteLine($"Munición disponible: {municion}");

            if (invencible == true && municion >= 1 && municion <= 10)
            {
                Console.WriteLine("El personaje está disparando");
           } */

            /*int numero1, numero2, numero3;

            Console.Write("Ingrese el primer número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            numero3 = int.Parse(Console.ReadLine());

            // Comprobar si hay números iguales
            if (numero1 == numero2 || numero1 == numero3 || numero2 == numero3)
            {
                Console.WriteLine("Debe ingresar números diferentes.");
            }
            else
            {
                // Encontrar el mayor
                if (numero1 > numero2 && numero1 > numero3)
                    Console.WriteLine("El número mayor es: " + numero1);
                else if (numero2 > numero1 && numero2 > numero3)
                    Console.WriteLine("El número mayor es: " + numero2);
                else
                    Console.WriteLine("El número mayor es: " + numero3);

                // Ordenar de menor a mayor
                int menor, medio, mayor;

                if (numero1 < numero2 && numero1 < numero3)
                {
                    menor = numero1;

                    if (numero2 < numero3)
                    {
                        medio = numero2;
                        mayor = numero3;
                    }
                    else
                    {
                        medio = numero3;
                        mayor = numero2;
                    }
                }
                else if (numero2 < numero1 && numero2 < numero3)
                {
                    menor = numero2;

                    if (numero1 < numero3)
                    {
                        medio = numero1;
                        mayor = numero3;
                    }
                    else
                    {
                        medio = numero3;
                        mayor = numero1;
                    }
                }
                else
                {
                    menor = numero3;

                    if (numero1 < numero2)
                    {
                        medio = numero1;
                        mayor = numero2;
                    }
                    else
                    {
                        medio = numero2;
                        mayor = numero1;
                    }
                }

                Console.WriteLine("Orden de menor a mayor: " + menor + ", " + medio + ", " + mayor);
            }*/

            // Coordenadas de los tres puntos
            /*Console.Write("Ingrese x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese x3: ");
            double x3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese y3: ");
            double y3 = double.Parse(Console.ReadLine());

            // Calcular las distancias
            double d12 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double d23 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double d13 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            Console.WriteLine($"Distancia P1 -> P2: {d12}");
            Console.WriteLine($"Distancia P2 -> P3: {d23}");
            Console.WriteLine($"Distancia P1 -> P3: {d13}");

            // Comprobar las condiciones del triángulo
            if (d12 + d23 > d13 &&
                d12 + d13 > d23 &&
                d23 + d13 > d12)
            {
                Console.WriteLine("Sí se puede construir un triángulo.");
            }
            else
            {
                Console.WriteLine("No se puede construir un triángulo.");

                if (d12 + d23 <= d13)
                    Console.WriteLine("No se cumple: d12 + d23 > d13");

                if (d12 + d13 <= d23)
                    Console.WriteLine("No se cumple: d12 + d13 > d23");

                if (d23 + d13 <= d12)
                    Console.WriteLine("No se cumple: d23 + d13 > d12");
            }*/

            // Generar las vidas aleatoriamente entre 0 y 5
            Random rnd = new Random();
            int vidas = rnd.Next(0, 6);

            Console.WriteLine($"El personaje tiene {vidas} vidas.");

            // Comprobar si tiene vidas
            if (vidas > 0)
            {
                Console.Write("Ingrese una acción (c, x, t, i): ");
                char accion = Console.ReadKey().KeyChar;

                if (accion == 'c')
                {
                    Console.WriteLine("\nEl personaje está disparando");
                }
                else if (accion == 'x')
                {
                    Console.WriteLine("\nEl personaje está hablando con la Rana");
                }
                else if (accion == 't')
                {
                    Console.WriteLine("\nEl personaje está en modo Turbo");
                }
                else if (accion == 'i')
                {
                    Console.WriteLine("\nEl personaje es Invencible");
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción");
            }
        }
    }
}
