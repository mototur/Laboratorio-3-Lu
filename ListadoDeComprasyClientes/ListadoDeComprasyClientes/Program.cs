using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoDeComprasyClientes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] numeros = new int[5, 5];

            CalculodeCompras(numeros);

            Console.ReadKey(true);
        }

        public static void CalculodeCompras(int[,] listadeCompras)
        {
            int[] PrecioFinalClientes = new int[listadeCompras.GetLength(0)];

            for (int i = 0; i < listadeCompras.GetLength(0); i++)
            {
                for (int j = 0; j < listadeCompras.GetLength(1); j++)
                {
                    Console.WriteLine($"Escribe el precio del cliente {i + 1} No {j}: ");

                    listadeCompras[i, j] = int.Parse(Console.ReadLine());
                    PrecioFinalClientes[i] += listadeCompras[i, j];


                }
            }

            for (int i = 0; i < PrecioFinalClientes.Length; i++)
            {
                if (PrecioFinalClientes[i] <= 99)
                {
                    Console.WriteLine($"El cliente {i + 1} no tiene descuento");
                }
                else if (PrecioFinalClientes[i] >= 100 && PrecioFinalClientes[i] <= 1000)
                {
                    Console.WriteLine($"El cliente {i + 1} si tiene un descuento del 10% que tendra un precio final de: {PrecioFinalClientes[i] - (PrecioFinalClientes[i] * 0.1)} ");
                }

                else if (PrecioFinalClientes[i] >= 1000)
                {
                    Console.WriteLine($"El cliente {i + 1} si tiene un descuento del 20% por lo cual tendra un precio final de: {PrecioFinalClientes[i] - (PrecioFinalClientes[i] * 0.2)} ");

                }
            }

          
        
        }
    }
}
