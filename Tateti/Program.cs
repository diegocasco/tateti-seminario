using System;
using System.Collections;

namespace tateti
{
    class Program
    {
        public static void Main(string[] args)
        {
            int jugador_actual = 1;
            int ficha_actual = 1;
            Juego juego = new Juego();

            //iniciamos un bucle que dure indefinidamente
            //hasta que el juego finalice
            while (true)
            {
                juego.PintarTablero();
                if (ficha_actual == 0)
                {
                    int ficha_a_mover = juego.SeleccionarFicha(jugador_actual);
                    //pedimos al usuario que defina cual es la ficha
                    //que va a mover
                    
                    int posicion_elegida = juego.SeleccionarPosicion(jugador_actual, ficha_actual);
                    //imprimiendo el tipo ficha apropiado según el 
                    //jugador actual
                    juego.Jugar(jugador_actual, ficha_a_mover, posicion_elegida);
                }
                else
                {   

                    int posicion_elegida=juego.SeleccionarPosicion(jugador_actual, ficha_actual);
                                        
                    //imprimiendo el tipo ficha apropiado según el 
                    //jugador actual
                    juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
                }
                
                jugador_actual++;

                if (jugador_actual == 3)
                {
                    jugador_actual = 1;
                    //solucion problema despues del movimiento 8
                    if (ficha_actual > 0)
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