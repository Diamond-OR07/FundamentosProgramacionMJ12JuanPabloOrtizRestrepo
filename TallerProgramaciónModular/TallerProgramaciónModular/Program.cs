
using System;

class Program
{
    //static void Main()
    //{
    //    char[] letras = IngresarPalabra();

    //    ContarLetras(letras);
    //}

    //// Modulo para uno ingresar la palabra
    //static char[] IngresarPalabra()
    //{
    //    Console.WriteLine("Ingrese una palabra:");
    //    string palabra = Console.ReadLine().ToLower();

    //    char[] vector = new char[palabra.Length];

    //    for (int i = 0; i < palabra.Length; i++)
    //    {
    //        vector[i] = palabra[i];
    //    }

    //    return vector;
    //}

    //// Modulo para contar las vocales y consonantes

    //static void ContarLetras(char[] vector)
    //{
    //    int vocales = 0;
    //    int consonantes = 0;

    //    for (int i = 0; i < vector.Length; i++)
    //    {
    //        if ((vector[i] >= 'a' && vector[i] <= 'z') ||
    //            vector[i] == 'á' || vector[i] == 'é' ||
    //            vector[i] == 'í' || vector[i] == 'ó' ||
    //            vector[i] == 'ú' || vector[i] == 'ü')
    //        {
    //            if (vector[i] == 'a' || vector[i] == 'e' ||
    //                vector[i] == 'i' || vector[i] == 'o' ||
    //                vector[i] == 'u' || vector[i] == 'á' ||
    //                vector[i] == 'é' || vector[i] == 'í' ||
    //                vector[i] == 'ó' || vector[i] == 'ú' ||
    //                vector[i] == 'ü')
    //            {
    //                vocales++;
    //            }
    //            else
    //            {
    //                consonantes++;
    //            }
    //        }
    //    }

    //    Console.WriteLine("Cantidad de vocales: " + vocales);
    //    Console.WriteLine("Cantidad de consonantes: " + consonantes);
    //}

    //// Programa principal
    //static void Main()
    //{
    //    string[] tareas = new string[100];
    //    int cantidad = 0;
    //    int opcion = 0;

    //    while (opcion != 4)
    //    {
    //        Console.WriteLine("\n--- LISTA DE TAREAS ---");
    //        Console.WriteLine("1. Agregar tarea");
    //        Console.WriteLine("2. Eliminar tarea");
    //        Console.WriteLine("3. Mostrar tareas");
    //        Console.WriteLine("4. Salir");
    //        Console.WriteLine("Seleccione una opcion:");

    //        opcion = int.Parse(Console.ReadLine());

    //        if (opcion == 1)
    //        {
    //            cantidad = AgregarTarea(tareas, cantidad);
    //        }
    //        else if (opcion == 2)
    //        {
    //            cantidad = EliminarTarea(tareas, cantidad);
    //        }
    //        else if (opcion == 3)
    //        {
    //            MostrarTareas(tareas, cantidad);
    //        }
    //        else if (opcion == 4)
    //        {
    //            Console.WriteLine("Saliendo......");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Error: Opcion no valida");
    //        }
    //    }
    //}

    //// Modulo para agregar tareas
    //static int AgregarTarea(string[] tareas, int cantidad)
    //{
    //    if (cantidad < tareas.Length)
    //    {
    //        Console.WriteLine("Ingrese la tarea:");
    //        tareas[cantidad] = Console.ReadLine();

    //        cantidad++;

    //        Console.WriteLine("Tarea agregada correctamente.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("La lista de tareas esta llena.");
    //    }

    //    return cantidad;
    //}

    //// Modulo para mostrar las tareas
    //static void MostrarTareas(string[] tareas, int cantidad)
    //{
    //    if (cantidad == 0)
    //    {
    //        Console.WriteLine("No hay tareas registradas.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Lista de tareas:");

    //        for (int i = 0; i < cantidad; i++)
    //        {
    //            Console.WriteLine((i + 1) + ". " + tareas[i]);
    //        }
    //    }
    //}

    //// Modulo para eliminar tareas
    //static int EliminarTarea(string[] tareas, int cantidad)
    //{
    //    if (cantidad == 0)
    //    {
    //        Console.WriteLine("No hay tareas para eliminar.");
    //    }
    //    else
    //    {
    //        MostrarTareas(tareas, cantidad);

    //        Console.WriteLine("Ingrese el numero de la tarea que desea eliminar:");
    //        int posicion = int.Parse(Console.ReadLine());

    //        if (posicion >= 1 && posicion <= cantidad)
    //        {
    //            for (int i = posicion - 1; i < cantidad - 1; i++)
    //            {
    //                tareas[i] = tareas[i + 1];
    //            }

    //            cantidad--;

    //            Console.WriteLine("Tarea eliminada correctamente.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Numero de tarea no valido.");
    //        }
    //    }

    //    return cantidad;
    //}

    // Modulo para convertir masa

    //// Programa principal
    //static void Main()
    //{
    //    int opcion = 0;

    //    while (opcion != 5)
    //    {
    //        Console.WriteLine("\n--- CONVERSOR DE UNIDADES ---");
    //        Console.WriteLine("1. Masa");
    //        Console.WriteLine("2. Capacidad");
    //        Console.WriteLine("3. Longitud");
    //        Console.WriteLine("4. Tiempo");
    //        Console.WriteLine("5. Salir");
    //        Console.WriteLine("Seleccione un tipo de unidad:");

    //        opcion = int.Parse(Console.ReadLine());

    //        if (opcion == 1)
    //        {
    //            Masa();
    //        }
    //        else if (opcion == 2)
    //        {
    //            Capacidad();
    //        }
    //        else if (opcion == 3)
    //        {
    //            Longitud();
    //        }
    //        else if (opcion == 4)
    //        {
    //            Tiempo();
    //        }
    //        else if (opcion == 5)
    //        {
    //            Console.WriteLine("Saliendo....");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Error: Opcion no valida");
    //        }
    //    }
    //}
    //static void Masa()
    //{
    //    Console.WriteLine("1. Kilogramos a gramos");
    //    Console.WriteLine("2. Gramos a kilogramos");
    //    int opcion = int.Parse(Console.ReadLine());

    //    Console.WriteLine("Ingrese el valor a convertir:");
    //    double valor = double.Parse(Console.ReadLine());

    //    double resultado = 0;

    //    if (opcion == 1)
    //    {
    //        resultado = valor * 1000;
    //        Console.WriteLine(valor + " kilogramos son " + resultado + " gramos.");
    //    }
    //    else if (opcion == 2)
    //    {
    //        resultado = valor / 1000;
    //        Console.WriteLine(valor + " gramos son " + resultado + " kilogramos.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Opcion no valida.");
    //    }
    //}

    //// Modulo para convertir capacidad
    //static void Capacidad()
    //{
    //    Console.WriteLine("1. Litros a mililitros");
    //    Console.WriteLine("2. Mililitros a litros");
    //    int opcion = int.Parse(Console.ReadLine());

    //    Console.WriteLine("Ingrese el valor a convertir:");
    //    double valor = double.Parse(Console.ReadLine());

    //    double resultado = 0;

    //    if (opcion == 1)
    //    {
    //        resultado = valor * 1000;
    //        Console.WriteLine(valor + " litros son " + resultado + " mililitros.");
    //    }
    //    else if (opcion == 2)
    //    {
    //        resultado = valor / 1000;
    //        Console.WriteLine(valor + " mililitros son " +resultado + " litros.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Opcion no valida.");
    //    }
    //}

    //// Modulo para convertir longitud
    //static void Longitud()
    //{
    //    Console.WriteLine("1. Kilometros a metros");
    //    Console.WriteLine("2. Metros a kilometros");
    //    int opcion = int.Parse(Console.ReadLine());

    //    Console.WriteLine("Ingrese el valor a convertir:");
    //    double valor = double.Parse(Console.ReadLine());

    //    double resultado = 0;

    //    if (opcion == 1)
    //    {
    //        resultado = valor * 1000;
    //        Console.WriteLine(valor + " kilometros son " +
    //            resultado + " metros.");
    //    }
    //    else if (opcion == 2)
    //    {
    //        resultado = valor / 1000;
    //        Console.WriteLine(valor + " metros son " +
    //            resultado + " kilometros.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Opcion no valida.");
    //    }
    //}

    //// Modulo para convertir tiempo
    //static void Tiempo()
    //{
    //    Console.WriteLine("1. Horas a segundos");
    //    Console.WriteLine("2. Segundos a horas");
    //    int opcion = int.Parse(Console.ReadLine());

    //    Console.WriteLine("Ingrese el valor a convertir:");
    //    double valor = double.Parse(Console.ReadLine());

    //    double resultado = 0;

    //    if (opcion == 1)
    //    {
    //        resultado = valor * 3600;
    //        Console.WriteLine(valor + " horas son " +
    //            resultado + " segundos.");
    //    }
    //    else if (opcion == 2)
    //    {
    //        resultado = valor / 3600;
    //        Console.WriteLine(valor + " segundos son " +
    //            resultado + " horas.");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Opcion no valida.");
    //    }
    //}

    // Programa principal
    static void Main()
    {
        char[] tablero = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        char jugador = 'X';
        int posicion;
        bool movimientoValido;
        bool ganador = false;

        while (ganador == false && TableroLleno(tablero) == false)
        {
            DibujarTablero(tablero);

            Console.WriteLine("Turno del jugador " + jugador);
            Console.WriteLine("Ingrese una posicion del 1 al 9:");

            posicion = int.Parse(Console.ReadLine());

            movimientoValido = RealizarMovimiento(tablero, posicion, jugador);

            if (movimientoValido == true)
            {
                ganador = VerificarGanador(tablero, jugador);

                if (ganador == false)
                {
                    if (jugador == 'X')
                    {
                        jugador = 'O';
                    }
                    else
                    {
                        jugador = 'X';
                    }
                }
            }
        }

        DibujarTablero(tablero);

        if (ganador == true)
        {
            Console.WriteLine("¡El jugador " + jugador + " ha ganado!");
        }
        else
        {
            Console.WriteLine("¡Empate!");
        }
    }

    // Modulo que dibuja el tablero
    static void DibujarTablero(char[] tablero)
    {
        Console.WriteLine();
        Console.WriteLine(" " + tablero[0] + " | " + tablero[1] + " | " + tablero[2]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" " + tablero[3] + " | " + tablero[4] + " | " + tablero[5]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" " + tablero[6] + " | " + tablero[7] + " | " + tablero[8]);
        Console.WriteLine();
    }

    // Modulo para realizar un movimiento
    static bool RealizarMovimiento(char[] tablero, int posicion, char jugador)
    {
        if (posicion >= 1 && posicion <= 9)
        {
            if (tablero[posicion - 1] != 'X' &&
                tablero[posicion - 1] != 'O')
            {
                tablero[posicion - 1] = jugador;
                return true;
            }
            else
            {
                Console.WriteLine("Esa casilla ya esta ocupada.");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Posicion no valida. Elija del 1 al 9.");
            return false;
        }
    }

    // Modulo que verifica si hay un ganador
    static bool VerificarGanador(char[] tablero, char jugador)
    {
        if (
            // Filas
            (tablero[0] == jugador && tablero[1] == jugador && tablero[2] == jugador) ||
            (tablero[3] == jugador && tablero[4] == jugador && tablero[5] == jugador) ||
            (tablero[6] == jugador && tablero[7] == jugador && tablero[8] == jugador) ||

            // Columnas
            (tablero[0] == jugador && tablero[3] == jugador && tablero[6] == jugador) ||
            (tablero[1] == jugador && tablero[4] == jugador && tablero[7] == jugador) ||
            (tablero[2] == jugador && tablero[5] == jugador && tablero[8] == jugador) ||

            // Diagonales
            (tablero[0] == jugador && tablero[4] == jugador && tablero[8] == jugador) ||
            (tablero[2] == jugador && tablero[4] == jugador && tablero[6] == jugador)
        )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Modulo que verifica si el tablero esta lleno
    static bool TableroLleno(char[] tablero)
    {
        for (int i = 0; i < tablero.Length; i++)
        {
            if (tablero[i] != 'X' && tablero[i] != 'O')
            {
                return false;
            }
        }

        return true;
    }

}
