using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primeras_Pruebas
{
    public class Cliente
    {
        private string nombre, apellido, direccion, localidad, telefono, codigo;
        private DateTime fecha_nacimiento;

        public Cliente()
        {
            Console.WriteLine("Creando un objeto basado en la clase cliente");
        }
        private string MostrarNombreCompleto()
        {
            return apellido + " " + nombre;

        }

        private void CapturarCodigo()
        {
            Console.Write("\nIngrese el codigo de cliente: ");
            codigo = Console.ReadLine();
        }

        private void CapturarNombre()
        {
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            if (nombre == "")
            {
                Console.WriteLine("Error, nombre no valido");
                CapturarNombre();
            }
            
          }

        private void CapturarApellido()
        {
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            if (apellido == "")
            {
                Console.WriteLine("Error, apellido no valido");
                CapturarApellido();
            }
        }

        private void CapturarDireccion()
        {
            Console.Write("Ingrese su direccion: ");
            direccion = Console.ReadLine();
            if (direccion == "")
            {
                Console.WriteLine("Error, dirección no valida");
                CapturarDireccion();
            }
        }

        private void CapturarLocalidad()
        {
            Console.Write("Ingrese su localidad: ");
            localidad = Console.ReadLine();
            if (localidad == "")
            {
                Console.WriteLine("Error, la localidad ingresada no es valida");
                CapturarLocalidad();
            }
        }
        private string AnunciarEdad()
        {
            //tomamos la fecha de hoy y la almacenamos en la 
            //variable "hoy"
            DateTime hoy = DateTime.Now;
            int edad = 0;
            //evalua si la persona ya cumplió años en el año
            //actual
            if (hoy.DayOfYear >= fecha_nacimiento.DayOfYear)
            {
                edad = hoy.Year - fecha_nacimiento.Year;
            }
            else
            {
                edad = (hoy.Year - fecha_nacimiento.Year) - 1;
            }
            return "Tengo " + edad + " años";

        }

        private void CapturarTelefono()
        {
            Console.Write("Ingrese su teléfono: ");
            telefono = Console.ReadLine();
            if (telefono == "")
            {
                Console.WriteLine("Error, el numero de telefono ingresado no es valido");
                CapturarTelefono();
            }
        }
        private void CapturarFechaNacimiento()
        {
            Console.Write("Por último ingrese su Fecha de nacimiento: ");
            try
            {
                fecha_nacimiento = Convert.ToDateTime(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error, ingrese la fecha de nacimiento");
                CapturarFechaNacimiento();
            }
        }
        public void CapturarDatos()
        {
            CapturarCodigo();
            CapturarApellido();
            CapturarNombre();
            CapturarDireccion();
            CapturarLocalidad();
            CapturarTelefono();
            CapturarFechaNacimiento();
        }
        private string Presentarse()
        {
           return "Hola soy "+ apellido+" "+nombre;
        }
        private string AnunciarDomicilio()
        {
           return "Vivo en "+ direccion+ "  "+localidad;
        }
           
         public void Hablar()
        {
            for (int x = 0; x < 40; x++)
                Console.Write("*");
            Console.WriteLine("\n");
            Console.WriteLine(Presentarse());
            Console.WriteLine(AnunciarDomicilio());
            Console.WriteLine(AnunciarEdad());
        }

        public void ImprimirFicha()
        {
            Console.WriteLine("\nPruebas de consola en\"C#\"");
            Console.WriteLine("\nFICHA PERSONAL CLIENTE");
            Console.WriteLine("Codigo de ciente: " + codigo);
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Direccion: " + direccion);
            Console.WriteLine("Localidad: " + localidad);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("Fecha_Nacimiento: " + fecha_nacimiento.ToShortDateString());
        }
        public void ImprimirHorizontal()
        {
            Console.WriteLine("{0} {1} {2} {3}",codigo, apellido, nombre, direccion);
        }
    }
}

 
