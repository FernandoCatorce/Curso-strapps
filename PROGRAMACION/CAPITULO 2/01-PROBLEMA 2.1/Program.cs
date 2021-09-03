using System;

namespace _01_PROBLEMA_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int costoInicial = 20000;
            int costoRecuperacion = 2000;
            int anio = 2005;
            int numerodeAnios = 6;
            decimal depreciacionAnual = (costoInicial - costoRecuperacion) / numerodeAnios;
            decimal depreciacionAcumulada = 0;
            decimal valorAnual = costoInicial;
            int contador = 1;
            Console.WriteLine("Año       Depreciacion          Depreciacion Acumulada        Valor Anual");

            while(contador <= numerodeAnios)
        {
         
         anio = anio +1;
         depreciacionAcumulada = depreciacionAcumulada + depreciacionAnual;
         valorAnual = valorAnual - depreciacionAnual;
         
         Console.WriteLine("(0) ({1})           {2}         {3}         {4}"   ,contador, anio, depreciacionAnual, depreciacionAcumulada, valorAnual);
         contador = contador +1;   
        }

        }
    }
}
