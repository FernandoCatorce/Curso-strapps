using System;

namespace _10_Ejemplo_2._10
{
    class Program
    {
        static void Main(string[] args)
        {
        //    1. Inicio
        //    2. Definir el arreglo
            int[] arreglo = {5, 3, 0, 2, 4, 4, 0, 0, 2, 3, 6, 0, 2};
        //    3. Hacer funcionar el contador
            int contador = 0;
        //    4. Repetir 0 hasta longitud del arreglo (13)
            for(int iteracion = 0; iteracion <= arreglo.Length; iteracion++)
            {
        //     4.1. Obtener el numero en el arreglo en la posición o iteracion actual
                    int numero = arreglo[iteracion];        
        //     4.2. validar si el numero es igual a cero
                    if (numero == 0)
                    {
                        // 4.2.1. incrementar el contador
                        contador = contador +1;                   
                    }
            }        
        //    5. Mostrar el numero de 0 encontrados 
                    Console.WriteLine("Se encontaron {0},contador");
        //    6. Fin 

        }
    }
}
