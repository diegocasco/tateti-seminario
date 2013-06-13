using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeras_Pruebas
{
    public class Saludo
    {
        private string nombre;
        private string apellido;
        
        public Saludo(String nom, String ape)
        {
            nombre = nom;
            apellido = ape;
        }
        
        public void Saludar()
        {
            Console.WriteLine("Hola {0} {1}", nombre, apellido);
        }
        public void SaludoFormal()
        {
            Console.WriteLine("Hola Sr/a= {0} {1}", nombre, apellido);
        }
        public void SaludoFormal(String leyenda)
        {
            Console.WriteLine("Hola {0}: {1} {2}",leyenda, nombre, apellido);
        }
    }
}


