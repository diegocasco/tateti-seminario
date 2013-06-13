using System;
using System.Collections;

namespace tateti
{
    public class Tablero
    {
        //declarando el diccionario hash que manejará
        //las posiciones del tablero
        public Hashtable posiciones;

        //metodo constructor que inicializa las posiciones
        //con un valor vacio
        public Tablero()
        {
            posiciones = new Hashtable();
            for (int x = 1; x < 10; x++)
                posiciones.Add(x, " ");
        }
        public void PintarTablero()
        {
            Console.Clear();
            for (int x = 1; x < 10; x++)
            {
                Console.Write("[{0}]", posiciones[x]);
                //comprobamos si ya se imprimieron 3
                //posiciones y hacemos un salto de linea
                if (x % 3 == 0)
                {
                    Console.Write("\n");
                }
            }
        }
    }
}