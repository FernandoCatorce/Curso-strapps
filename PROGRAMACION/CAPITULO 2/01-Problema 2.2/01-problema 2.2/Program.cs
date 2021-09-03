using System;

namespace _01_problema_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Inicialización de las variables
           double cantidad1;
           double cantidad2;
           string operacion;
           double resultado;

           Console.WriteLine("Operación");
           Console.WriteLine("Suma");

           operacion = Console.ReadLine();

           Console.WriteLine("catidad");
            cantidad1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("segunda cantidad");
            cantidad2 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if(operacion == "Suma")
            {
                resultado = cantidad1 + cantidad2;

                Console.WriteLine("El resultado de la suma es:" + resultado);
                Console.ReadLine(); 
            }

        }
    }
}
