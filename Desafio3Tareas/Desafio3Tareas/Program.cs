using System;
using System.Collections.Generic;

namespace ListaDeTareas
{
    internal class Tarea
    {
        public int Id { get; set; }
        public string TextoTarea { get; set; }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            bool validacion = true;
            int opcion;
            int idTarea = 1;
            List<Tarea> lista = new List<Tarea>();

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
                        Console.WriteLine("Tareas: ");
                        foreach (Tarea t in lista)
                        {
                            Console.WriteLine($"Numero de tarea: {t.Id}, Descripcion: {t.TextoTarea}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Ingresa la tarea que deseas agregar:");
                        string tarea = Console.ReadLine();
                        lista.Add(new Tarea { Id = idTarea++, TextoTarea = tarea });
                        break;

                    case 3:
                        Console.WriteLine("Ingresa el numero de la tarea que deseas eliminar:");
                        int idEliminar;

                        idEliminar = int.Parse(Console.ReadLine());
                        Tarea idTareaEliminar = lista.Find(t => t.Id == idEliminar);
                        if (idTareaEliminar != null)
                        {
                            lista.Remove(idTareaEliminar);
                            Console.WriteLine("tarea eliminada.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró una tarea con ese ID.");
                        }
                        break;

                    case 4:
                        validacion = false;
                        break;

                    default:
                        Console.WriteLine("Opción invaldia");
                        break;
                }

                Console.WriteLine("Presiona cualquier tecla para continuar");
                Console.ReadKey(true);

            } while (validacion);
        }
    }
}