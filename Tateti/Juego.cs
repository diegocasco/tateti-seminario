using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tateti
{
    public class Juego
    {
     //declaramos e inicializamos los objetos
            public Tablero tablero;
            public Jugador jugador1;
            public Jugador jugador2;
            
            public Juego ()
            {
                //declaramos las propiedades
             tablero = new Tablero ();
             jugador1= new Jugador("X");
             jugador2= new Jugador("O");
            }
          public void Jugar(int jugador; int ficha, int posicion);
    {  
        if (jugador_actual == 1)
                    posiciones[posicion_elegida] = jugador1.tipo_ficha;
                else
                    tablero.posiciones[posicion_elegida] = jugador2.tipo_ficha;

    }
}
