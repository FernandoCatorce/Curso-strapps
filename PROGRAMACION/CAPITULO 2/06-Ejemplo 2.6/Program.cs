using System;

namespace _06_Ejemplo_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
        // 1. Iniciar 
        // 2. iniciar la suma = 0
            int suma = 0;
        // 3. Repetir sumas de 2 en 2 hasta llegar al 1000
            for(int numero = 2; numero <=1000; numero = numero +2 )
            {
                // 3.1. sumar la iteracion a la variable suma
                    suma = suma + numero ;   
            }
        // 4. mostrar el resultado 
        Console.WriteLine($"El resultado de la suma es: {suma}");
        // 5. Fin       
        }
    }
}
