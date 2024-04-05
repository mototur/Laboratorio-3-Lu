using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_totito
{
    internal class Program
    {
        
        const char disponible = '_';
        char[,] tablero =
        {

            {disponible, disponible,disponible },
            {disponible, disponible,disponible },
            {disponible, disponible,disponible }
        
        };
        static void Main(string[] args)
        {
               Program p = new Program();
               bool fin = false;
               char jugadorActual = 'X';
               do
                {
                    p.RealizarJugada(jugadorActual);
                    p.MostrarTablero();

                    fin = p.TableroLleno() || p.EsGanador(jugadorActual);
                    jugadorActual = jugadorActual == 'X' ? '0' : 'X';

               } while (!fin);



                Console.ReadKey();
        }

            private bool EsGanador(char jugadorActual)

            {

                for (int i = 0; i < 3; i++)
                {
                    if (tablero[i, 0] == jugadorActual && tablero[i, 1] == jugadorActual && tablero[i, 2] == jugadorActual)
                    {
                        Console.WriteLine("Felicidades jugador " + jugadorActual + "Has Ganado!!");
                        return true;
                    }
                    if (tablero[0, i] == jugadorActual && tablero[1, i] == jugadorActual && tablero[2, i] == jugadorActual)
                    {
                        Console.WriteLine("Felicidades jugador " + jugadorActual + "Has Ganado!!");
                        return true;
                    }
                }
                return false;

            }

            private bool TableroLleno()
            {
                bool esDisponible = true;
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (tablero[f, c] == disponible)
                        {
                            esDisponible = false;
                            return esDisponible;
                        }

                    }
                }
                return esDisponible;
            }

            private void RealizarJugada(char jugadorActual)
            {
                Console.WriteLine("es el turno de " + jugadorActual);
                bool valida = true;
                do
                {
                    Console.WriteLine("Elija una fila");
                    int fila = int.Parse(Console.ReadLine());
                    Console.WriteLine("Elija una columna");
                    int columna = int.Parse(Console.ReadLine());
                    if (tablero[fila, columna] == disponible)
                    {
                        tablero[fila, columna] = jugadorActual;
                        valida = true;
                    }
                    else
                    {
                        Console.WriteLine("pocision invalida");
                        valida = false;

                    }
                } while (!valida);



            }

            public void MostrarTablero()
            {
                Console.Clear();
                for (int fila = 0; fila < 3; fila++)
                {
                    for (int col = 0; col < 3; col++)

                    {
                        Console.Write(tablero[fila, col]);
                    }

                    Console.WriteLine();
                }
                Console.WriteLine("presionar una tecla");
                Console.ReadKey();
            }
        
    }
}
