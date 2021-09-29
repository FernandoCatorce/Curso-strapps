using System;

namespace _04_Ejemplo_2._4
{
    class Program
    {
        static Cliente Main(string[] args)
        {
            Console.Write("Introduzca el número de cliente");
            string entrada = Console.ReadLine();
            int NumerodeCliente = int.Parse(entrada);
            Cliente cliente = BuscarCliente(NumerodeCliente);
            Console.Write("Introduzca el número de cliente");
            string entrada = Console.ReadLine();
            decimal totalPedido = decimal.Parse(entrada);
            if (cliente.Saldo > totalPedido)
            {
                Console.WriteLine("Tu pedido fue aceptado");
            }
            else
            {
                Console.WriteLine("Tu pedido ha sido rechazado");
            }

        }
        static void BuscarCliente(int NumerodeCliente)
        {
            List<Cliente> BancodeDatos = CreaBancodeDatos();
            foreach (Cliente cliente in BancodeDatos)
            {
                if (cliente.NumerodeCliente == NumerodeCliente)
                {
                    return cliente;
                }
            }
            return null;
        }
        static List<Cliente> CreaBancodeDatos()
        {
            //1.Arranque
            //2.Definir entidad de cliente para banco de datos


            //3.Crear y guardar 5 clientes de manera fija    

            List<Cliente> BancodeDatos = new List<Cliente>();
            //3.1.Crear al cliente -> asignando un numero, un nombre y un saldo  
            Cliente cliente = new Cliente();
            cliente.NumerodeCliente = 1;
            cliente.Nombre = "Junaito Perez";
            cliente.Saldo = 1000;
            //3.2Guardar al cliente en el banco de datos
            BancodeDatos.Add(cliente);

            Cliente cliente = new Cliente();
            cliente.NumerodeCliente = 2;
            cliente.Nombre = "Maria Juarez";
            cliente.Saldo = 1100;
            //3.2Guardar al cliente en el banco de datos
            BancodeDatos.Add(cliente);

            Cliente cliente = new Cliente();
            cliente.NumerodeCliente = 3;
            cliente.Nombre = "Brenda Ochoa";
            cliente.Saldo = 2000;
            //3.2Guardar al cliente en el banco de datos
            BancodeDatos.Add(cliente);

            Cliente cliente = new Cliente();
            cliente.NumerodeCliente = 4;
            cliente.Nombre = "Rockdrigo Gonzales";
            cliente.Saldo = 500;
            //3.2Guardar al cliente en el banco de datos
            BancodeDatos.Add(cliente);

            Cliente cliente = new Cliente();
            cliente.NumerodeCliente = 5;
            cliente.Nombre = "Arturo Morales";
            cliente.Saldo = 0;
            //3.2Guardar al cliente en el banco de datos
            BancodeDatos.Add(cliente);
            //4.Regresar al banco de datos
            return BancodeDatos;
            //5.fin 
        }
        public class Cliente
        {
            public int NumerodeCliente { get; set; }
            public string Nombre { get; set; }
            public decimal Saldo { get; set; }
        }
    }
}
