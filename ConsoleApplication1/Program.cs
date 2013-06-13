using System;
using System.Collections;

namespace tateti
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tablero tablero = new Tablero();
            Jugador jugador1 = new Jugador("X");
            Jugador jugador2 = new Jugador("O");

            int jugador_actual = 1;
            int ficha_actual = 1;
            while (true)
            {
                tablero.PintarTablero();
                if (ficha_actual == 0)
                {
                    Console.Write("Jugador {0}: ingrese el nro de ficha a mover:", jugador_actual);
                    ficha_actual = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Jugador {0}: ingrese posición para la ficha {1}:", jugador_actual, ficha_actual);
                int posicion_elegida = Convert.ToInt32(Console.ReadLine());
                //imprimiendo el tipo ficha apropiado según el 
                //jugador actual
                if (jugador_actual == 1)
                    tablero.posiciones[posicion_elegida] = jugador1.tipo_ficha;
                else
                    tablero.posiciones[posicion_elegida] = jugador2.tipo_ficha;

                jugador_actual++;

                if (jugador_actual == 3)
                {
                    jugador_actual = 1;
                    ficha_actual++;
                    if (ficha_actual == 4)
                    {
                        ficha_actual = 0;
                    }
                }

            }
            Console.ReadLine();
        }


    }
}