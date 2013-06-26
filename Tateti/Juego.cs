using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

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
        public void PintarTablero()
        {
            tablero.Limpiar();
            foreach (DictionaryEntry ficha in jugador1.fichas)
            {
                //grabamos la posición de la ficha del jugador 
                //en el tablero sumandole el numero de ficha
                tablero.posiciones[ficha.Value]=jugador1.tipo_ficha+ficha.Key.ToString();
            }
            foreach (DictionaryEntry ficha in jugador2.fichas)
            {
                //grabamos la posición de la ficha del jugador 
                //en el tablero sumandole el numero de ficha
                tablero.posiciones[ficha.Value]=jugador2.tipo_ficha+ficha.Key.ToString();
            }
            tablero.PintarTablero();
        }
        public void Jugar(int jugador, int ficha, int posicion)
        {
           if (jugador == 1)
            
                jugador1.fichas[ficha] =posicion;
           else
               jugador2.fichas[ficha] =posicion;

           
        }
    }
}
