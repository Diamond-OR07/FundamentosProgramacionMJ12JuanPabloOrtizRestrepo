using System;


namespace _2.ConstantesTiposDeDatosYOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string gravedad = "9.8";
            string nombre = "Juan";
            nombre = "Pablo";
            //Gravedad = "10"; ¡mal! no puedo cambiar el valor de una constante

            //TIPOS DE DATOS
            byte dato1 = 0;
            int dato2 = -7635;
            ulong dato3 = 3645271956;
            float dato4 = 12.7f;
            double dato5 = 5673.2d; //la "d" del sufijo al final es opcional
            decimal dato6 = 634173786.538645658m;

            char dato7 = '¬';
            string dato8 = "Γεια σου! =)";
            bool dato9 = false; //true or false
            object dato10 = new object();

            //OPERADORES
            //Operadores númericos
            //Cambio de signo
            int dato11 = 5;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;
            Console.WriteLine("dato11:{0}, dato12{1}, dato13:{2}, dato 14: {3}", dato11, dato12, dato13, dato14);
            int dato15 = 5 + 3;//Suma
            int dato16 = dato15 - 2;//Resta
            int dato17 = 67 * 7;//Producto
            //float dato18 =(float) 5f / 3f;//División
            float dato18 = 5f / 3f;//División
            Console.WriteLine("Suma: {0}, resta: {1}, producto: {2}, division: {3}", dato15, dato16, dato17, dato18);
        }
    }
}
