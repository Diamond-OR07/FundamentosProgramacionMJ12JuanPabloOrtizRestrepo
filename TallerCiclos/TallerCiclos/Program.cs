using System;

namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //double calificacion;
            //double suma = 0;
            //int cantidad = 0;
            //string continuar = "s";

            //while (continuar == "s")
            //{
            //    Console.Write("Ingrese una calificación: ");
            //    calificacion = double.Parse(Console.ReadLine());

            //    suma = suma + calificacion;
            //    cantidad++;

            //    Console.Write("¿Desea ingresar otra calificación? (s/n): ");
            //    continuar = Console.ReadLine().ToLower();
            //}

            //double promedio = suma / cantidad;

            //Console.WriteLine("El promedio es: " + promedio);

            //2
            //Console.Write("Ingrese un número entero para saber sus divisores: ");
            //int numero = int.Parse(Console.ReadLine());

            //for (int i = numero; i >= 1; i--)
            //{
            //    if (numero % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //3
            //int b;
            //int e;
            //int resultado;
            //string continuar;

            //do
            //{
            //    Console.Write("Ingrese la base: ");
            //    b = int.Parse(Console.ReadLine());

            //    Console.Write("Ingrese el exponente: ");
            //    e = int.Parse(Console.ReadLine());

            //    resultado = 1;

            //    for (int i = 1; i <= e; i++)
            //    {
            //        resultado = resultado * b;
            //    }

            //    Console.WriteLine("El resultado es: " + resultado);

            //    Console.Write("¿Desea realizar otra potenciación? (s/n): ");
            //    continuar = Console.ReadLine().ToLower();

            //} while (continuar != "n");

            //4
            //double tiempo;
            //double suma = 0;
            //double promedio;
            //bool menor15 = false;
            //bool mayor20 = false;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("Ingrese el tiempo de la prueba " + i + ": ");
            //    tiempo = double.Parse(Console.ReadLine());

            //    suma = suma + tiempo;

            //    if (tiempo < 15)
            //    {
            //        menor15 = true;
            //    }

            //    if (tiempo > 20)
            //    {
            //        mayor20 = true;
            //    }
            //}

            //promedio = suma / 10;

            //Console.WriteLine("Promedio: " + promedio);

            //if (mayor20 == false && menor15 == true && promedio <= 18)
            //{
            //    Console.WriteLine("El atleta es APTO.");
            //}
            //else
            //{
            //    Console.WriteLine("El atleta NO es APTO.");
            //}
            //5
            //int n;
            //int aFavor = 0;
            //int enContra = 0;
            //int noResponde = 0;

            //Console.Write("Ingrese el número de encuestados: ");
            //n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Persona " + i);
            //    Console.WriteLine("1. A favor");
            //    Console.WriteLine("2. En contra");
            //    Console.WriteLine("3. No responde");
            //    Console.Write("Seleccione una opción: ");

            //    int opcion = int.Parse(Console.ReadLine());

            //    if (opcion == 1)
            //    {
            //        aFavor++;
            //    }
            //    else if (opcion == 2)
            //    {
            //        enContra++;
            //    }
            //    else if (opcion == 3)
            //    {
            //        noResponde++;
            //    }
            //}

            //double porcentajeFavor = (aFavor * 100.0) / n;
            //double porcentajeContra = (enContra * 100.0) / n;
            //double porcentajeNoResponde = (noResponde * 100.0) / n;

            //Console.WriteLine("\nResultados:");
            //Console.WriteLine("A favor: " + porcentajeFavor + "%");
            //Console.WriteLine("En contra: " + porcentajeContra + "%");
            //Console.WriteLine("No responde: " + porcentajeNoResponde + "%");

            //6
            //int positivos = 0;
            //int negativos = 0;
            //int neutros = 0;

            //double sumaPositivos = 0;
            //double sumaNegativos = 0;

            //for (int i = 1; i <= 40; i++)
            //{
            //    Console.Write("Ingrese el número " + i + ": ");
            //    double numero = double.Parse(Console.ReadLine());

            //    if (numero > 0)
            //    {
            //        positivos++;
            //        sumaPositivos = sumaPositivos + numero;
            //    }
            //    else if (numero < 0)
            //    {
            //        negativos++;
            //        sumaNegativos = sumaNegativos + numero;
            //    }
            //    else
            //    {
            //        neutros++;
            //    }
            //}

            //Console.WriteLine("\nResultados:");
            //Console.WriteLine("Positivos: " + positivos);
            //Console.WriteLine("Negativos: " + negativos);
            //Console.WriteLine("Neutros: " + neutros);
            //Console.WriteLine("Suma de positivos: " + sumaPositivos);
            //Console.WriteLine("Suma de negativos: " + sumaNegativos);

            //7
            int edad;
            double peso;

            int ninos = 0;
            int jovenes = 0;
            int adultos = 0;
            int viejos = 0;

            double sumaPesoNinos = 0;
            double sumaPesoJovenes = 0;
            double sumaPesoAdultos = 0;
            double sumaPesoViejos = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese la edad de la persona " + i + ": ");
                edad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el peso de la persona " + i + ": ");
                peso = double.Parse(Console.ReadLine());

                if (edad >= 0 && edad <= 13)
                {
                    ninos++;
                    sumaPesoNinos += peso;
                }
                else if (edad >= 14 && edad <= 30)
                {
                    jovenes++;
                    sumaPesoJovenes += peso;
                }
                else if (edad >= 31 && edad <= 60)
                {
                    adultos++;
                    sumaPesoAdultos += peso;
                }
                else if (edad >= 61)
                {
                    viejos++;
                    sumaPesoViejos += peso;
                }
            }

            Console.WriteLine("\nRESULTADOS");

            Console.WriteLine("Niños: " + ninos);
            if (ninos > 0)
                Console.WriteLine("Promedio de peso: " + (sumaPesoNinos / ninos));

            Console.WriteLine("\nJóvenes: " + jovenes);
            if (jovenes > 0)
                Console.WriteLine("Promedio de peso: " + (sumaPesoJovenes / jovenes));

            Console.WriteLine("\nAdultos: " + adultos);
            if (adultos > 0)
                Console.WriteLine("Promedio de peso: " + (sumaPesoAdultos / adultos));

            Console.WriteLine("\nViejos: " + viejos);
            if (viejos > 0)
                Console.WriteLine("Promedio de peso: " + (sumaPesoViejos / viejos));

        }
    }
}
