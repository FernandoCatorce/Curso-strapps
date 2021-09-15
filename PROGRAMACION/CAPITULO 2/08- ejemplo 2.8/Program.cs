using System;

namespace _08__ejemplo_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- inicio 
            int suma = 0;
            //2.- Iniciar las variables

            for (int numero = 1; numero <= 100; numero++)
        {


                //3.- repetir del 1 al 100
                int residuo = numero % 2;

                if (residuo == 0)

                    suma = suma + numero;

            }
            Console.WriteLine("La suma de los numeros par de 1 a 100 es {0}", suma);
            //5.- finalizar 

        }
    }
}
