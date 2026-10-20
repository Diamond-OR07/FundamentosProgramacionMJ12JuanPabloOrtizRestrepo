using System;

namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un profesor necesita un programa para procesar las calificaciones de un grupo de 18 alumnos con el fin de obtener un análisis general del curso. Las notas se encuentran en un rango de 0 a 10.
            //            Utilizando obligatoriamente una estructura repetitiva, el programa debe realizar las siguientes operaciones:
            //            1. Lectura de datos: Solicitar por teclado la nota de cada uno de los 18 estudiantes.Cada nota ingresada debe ser procesada individualmente.
            //            2. Cálculo de Promedio: Acumular las notas para calcular al final el promedio general de todo el curso.
            //            3. Identificación de Extremos: Identificar y almacenar cuál fue la nota mayor y la nota menor de todo el conjunto ingresado.
            //            4. Conteo de Aprobados: Contar cuántos estudiantes aprobaron la asignatura(considerando que se aprueba con una nota mayor o igual a 6.0).
            //            5. Reporte de Salida: Al finalizar el ciclo, mostrar claramente en pantalla:
            //            El promedio general del curso.
            //              La nota más alta obtenida.
            //              La nota más baja obtenida.
            //              La cantidad total de estudiantes que aprobaron.

            
            double acumSumaNotas = 0;
            int aprobados = 0;
            double notaMax = 0;
            double notaMin = 0;
            double promedio;

            for (byte cont = 0; cont < 18; cont++) 
            {

                Console.WriteLine("Ingrese la nota del estudiante {0} (0 a 10):", cont + 1);
                double nota = Convert.ToDouble(Console.ReadLine());
               

                    acumSumaNotas += nota;
                    if (cont == 0)
                    {
                        notaMax = nota;
                        notaMin = nota;
                    }
                    else
                    {
                        if (nota > notaMax)
                        {
                            notaMax = nota;
                        }
                        if (nota < notaMin)
                        {
                            notaMin = nota;
                        }
                    }
                    if (nota >= 6.0)
                    {
                        aprobados++;
                    }
                
                


            }

            Console.WriteLine("La nota más alta obtenida fue: {0}", notaMax);
            Console.WriteLine("La nota más baja obtenida fue: {0}", notaMin);
            Console.WriteLine("La cantidad total de estudiantes que aprobaron fue: {0}", aprobados);
            promedio = acumSumaNotas / 18;
            Console.WriteLine("El promedio general del curso fue: {0}", promedio);



        }
    }
}
