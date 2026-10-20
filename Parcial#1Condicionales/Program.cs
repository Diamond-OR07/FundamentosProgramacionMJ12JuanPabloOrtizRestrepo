using System;

namespace Parcial1Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pizzería Olafo
            //1. Selección del tipo de pizza:
            string TipodePizza;
            byte ingrediente1;
            byte ingrediente2;
            byte ingrediente3;
            double Preciofinal;
            double Valoriva;

            Console.WriteLine("Por favor Seleccione solo uno de los siguientes tipo de pizza: Vegeteriana o No vegetariana");
            TipodePizza = Console.ReadLine();

            //2. Selección de los ingredientes:

            if (TipodePizza == "Vegetariana" || TipodePizza == "vegetariana")
            {
                Console.WriteLine("Elija tres ingredientes diferentes seleccionandolos exclusivamente por su número: 1.Pimiento 2.Tofu 3.Champiñones 4.Tomate 5.Lechuga");
                ingrediente1 = byte.Parse(Console.ReadLine());
                Console.WriteLine("Elija el segundo");
                ingrediente2 = byte.Parse(Console.ReadLine());
                Console.WriteLine("Elija el tercero");
                ingrediente3 = byte.Parse(Console.ReadLine());

                if (ingrediente1 != ingrediente2 && ingrediente2 != ingrediente3 && ingrediente1 != ingrediente3) //Se comprueba que no seleccione dos veces el mismo ingrediente
                {
                    if (ingrediente1 >= 1 && ingrediente1 <= 5 || ingrediente2 >= 1 && ingrediente2 <= 5 || ingrediente3 >= 1 && ingrediente3 <= 5)//Se revisa que sean validos los ingredientes
                    {
                        if (ingrediente1 + ingrediente2 + ingrediente3 == 9)
                        {
                            Console.WriteLine($"Se selecciono de ingredientes: {ingrediente1} + {ingrediente2} + {ingrediente3}");
                            Preciofinal = 20000 * 1.19;
                            Console.WriteLine("El precio de su pizza vegetariana (+ 19% de IVA) es: "+Preciofinal);
                        } else if (ingrediente1 + ingrediente2 + ingrediente3 == 10)
                        {
                            Console.WriteLine($"Se selecciono de ingredientes: {ingrediente1} + {ingrediente2} + {ingrediente3}");
                            Preciofinal = 30000 * 1.15;
                            Console.WriteLine("El precio de su pizza vegetariana (+ 15% de IVA) es: " + Preciofinal);
                        }
                        else 
                        {
                            Console.WriteLine($"Se selecciono de ingredientes: {ingrediente1} + {ingrediente2} + {ingrediente3}");
                            Preciofinal = 25000 * 1.10;
                            Console.WriteLine("El precio de su pizza vegetariana (+ 10% de IVA) es: " + Preciofinal);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No selecciono un ingrediente valido");
                    }
                } else
                {
                    Console.WriteLine("los ingredientes deben ser distintos");
                }

            } else if (TipodePizza == "No vegetariana" || TipodePizza == "no vegetariana")
            {
                Console.WriteLine("Elija dos ingredientes diferentes seleccionandolos exclusivamente por su número: 1.Res 2.Chorizo 3.Pollo 4.Tocineta 5.Cerdo");
                ingrediente1 = byte.Parse(Console.ReadLine());
                Console.WriteLine("Elija el segundo");
                ingrediente2 = byte.Parse(Console.ReadLine());
                if (ingrediente1 != ingrediente2)
                {
                    if (ingrediente1 >= 1 && ingrediente1 <= 5 || ingrediente2 >= 1 && ingrediente2 <= 5)
                    {
                        if (ingrediente1 + ingrediente2 == 4)
                        {
                            Console.WriteLine($"Se selecciono de ingredientes: {ingrediente1} + {ingrediente2}");
                            Preciofinal = 10000 * 1.19;
                            Console.WriteLine("El precio de su pizza no vegetariana (+ 19% de IVA) es: " + Preciofinal);
                        }
                        else if (ingrediente1 + ingrediente2 == 5)
                        {
                            Console.WriteLine($"Se selecciono de ingredientes: {ingrediente1} + {ingrediente2}");
                            Preciofinal = 15000 * 1.17;
                            Console.WriteLine("El precio de su pizza no vegetariana (+ 17% de IVA) es: " + Preciofinal);
                        }
                        else if (ingrediente1 + ingrediente2 == 6)
                        {
                            Console.WriteLine($"Se selecciono de ingredientes: {ingrediente1} + {ingrediente2}");
                            Preciofinal = 25000 * 1.9;
                            Console.WriteLine("El precio de su pizza no vegetariana (+ 9% de IVA) es: " + Preciofinal);
                        } else
                        {
                            Console.WriteLine($"Se selecciono de ingredientes: {ingrediente1} + {ingrediente2}");
                            Preciofinal = 22000 * 1.10;
                            Console.WriteLine("El precio de su pizza no vegetariana (+ 10% de IVA) es: " + Preciofinal);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No selecciono un ingrediente valido");
                    }
                }
                else
                {
                    Console.WriteLine("los ingredientes deben ser distintos");
                }

            }
        }
    }
}
