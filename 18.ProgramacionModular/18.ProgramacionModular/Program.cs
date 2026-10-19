using System;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de Fundamentos de Programación");
            MostrarMensaje("Juan");
            Console.WriteLine($"Juan tiene {CalcularEdad(2026, 2008)} años");
            MostrarMensaje("Freddy");
            MostrarMensaje("Juana", "de Arco");
            Console.ReadKey();
            BorrarPantalla();

        }
        //Procedimientos sin parámetros
        static int CalcularEdad()
        {
            int anioNacimiento = 2008;
            int anioActual = 2026;
            int edad = anioActual - anioNacimiento;
            return edad;
        }
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        //Procedimientos con parámetros
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento; ;
        }
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenid@, {nombre} al curso de Fundamentos de Programación");

        }
        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenid@, {nombre} {apellidos} al curso de Fundamentos de Programación");

        }
        
    }
}
