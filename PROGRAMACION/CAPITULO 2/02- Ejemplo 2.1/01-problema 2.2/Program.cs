using System;

namespace _01_problema_2._2
{
    class Program
    {
        static void Main(string[] args)
            { 
                //1.- inico
                string entrada = string.Empty;


                //2.- obtener horasTrabajadas 
                        entrada = Console.ReadLine();
                        int horasTrabajadas = int.Parse(entrada);
                        

                //3.- obtener TrifaHora
                        entrada = Console.ReadLine();
                        int TarifaHoraria =  int.Parse(entrada);
                //4.- obtener TasaImpuesto
                     entrada = Console.ReadLine();
                     decimal TasaImpuesto = decimal.Parse(entrada);

                //5.- declarar variables PagoBruto, ImpuestoaPagar, PagoNeto
                        int PagoBruto = 0;
                        decimal ImpuestoAPagar = 0;
                        decimal pagoNeto = 0;

                //6.- Calcular pagoBruto, HorasTrabajadas, TarifaHoraria
                PagoBruto = horasTrabajadas * TarifaHoraria;

                //7.- Calcular ImpuestoaPagar ,PagoBruto, TasaImpuesto
                ImpuestoAPagar = PagoBruto * ImpuestoAPagar;
                //8.- Calcular PagoNeto, PagoBruto, ImpuestoAPagar
                pagoNeto = PagoBruto - ImpuestoAPagar;

                //9.- Imprirmir el pago neto
                Console.WriteLine("El pago neto es:" + pagoNeto);
                //10.- Fin  
                
        
           
            }

        }
    }
