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
        public int SeleccionarFicha(int jugador)
        {
            Console.Write("Jugador {0}: intrese el número de ficha a mover: ", jugador);
            int ficha_a_mover = Convert.ToInt32(Console.ReadLine());
            return ficha_a_mover;
            
        }
        public int SeleccionarPosicion(int jugador, int ficha)
        {
            int posicion_elegida = 0;
            do
            {
                Console.Write("Jugador {0}: ingrese posición para la ficha {1}:", jugador, ficha);
                try
                {
                    posicion_elegida = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    posicion_elegida = 0;
                    Console.WriteLine("Error, se esperaba que ingrese un valor");
                }
                if (posicion_elegida < 1 || posicion_elegida > 9)
                {
                    Console.WriteLine("Error, posición no válida");
                    Console.ReadLine();
                }
            } while (posicion_elegida < 1 || posicion_elegida > 9);
            {
                Console.WriteLine("Error, posición no válida");
                Console.ReadLine();
                SeleccionarPosicion(jugador, ficha);
            }
            return posicion_elegida;
 
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
