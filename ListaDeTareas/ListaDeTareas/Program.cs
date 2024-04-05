using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeTareas
{
    internal class Program
    {
       
        
            public static void Main(string[] args)
            {
                bool validacion = true;
                int opcion;
                List<string> lista = new List<string>() { };

                do
                {
                    Console.Clear();
                    Console.WriteLine("Menu de opciones");
                    Console.WriteLine("1. Mostrar");
                    Console.WriteLine("2. Agregar");
                    Console.WriteLine("3. Eliminar");
                    Console.WriteLine("4. Salir");

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:

                            foreach (string elemento in lista)
                            {
                                Console.WriteLine(elemento);
                            }

                            break;

                        case 2:
                            Console.WriteLine("Ingresa la tarea que deseas agregar: ");
                            string AgregarTarea = Console.ReadLine();
                            lista.Add(AgregarTarea);
                            break;


                        case 3:
                            Console.WriteLine("Ingresa la tarea que deseas eliminar: ");
                            string EliminarTarea = Console.ReadLine();

                            lista.Remove(EliminarTarea);

                            break;

                        case 4: validacion = false; break;
                    }
                    Console.ReadKey(true);

                } while (validacion);
            }
    }
}
