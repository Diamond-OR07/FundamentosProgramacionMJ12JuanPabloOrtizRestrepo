using System;

namespace _4.CondicionalesSimplesYDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURA DE CONTROL CONDICIONALES
            //Simples
            //1. Crea un algoritmo que lea la edad  de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web".
            /*byte edad = 0;
            Console.WriteLine("Ingrese su edad por favor");
            edad = Convert.ToByte(Console.ReadLine() );
            if (edad >= 18)
            {
                //Si la condición se cumple
                Console.WriteLine("Bienvenido a mi sitio web");
            }*/

            //Crear el algoritmo que permita ingresar el nombre y le dueldo de una persona, si el sueldo de la persona supera los 3000 pesos
            //mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.
            string nombre;
            float sueldo;
            Console.WriteLine("Por favor ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine("Usted, estimad@ " + nombre + ", debe de abonar impuestos.");
            }

            //Condicionales dobles
            //Crear un algoritmo que lea la edad  de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web". De lo contrario mostrar el mensaje "No es apto para el contenido de este sitio web".
            byte edad = 0;
            Console.WriteLine("Ingrese su edad por favor");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //Si la condición se cumple
                Console.WriteLine("Bienvenido a mi sitio web");

            }
            else
            {
                //Si no se cumple la condición
                Console.WriteLine("No es apto para el contenido de este sitio web");
            }
        }
    }
}
