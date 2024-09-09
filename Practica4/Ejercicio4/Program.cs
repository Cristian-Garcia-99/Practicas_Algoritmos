

/* EJERCICIO 4
Agregue a la clase Persona un método esMayorQue(Persona p) que devuelva verdadero si la persona que recibe el mensaje es 
más grande que la persona recibida como parámetro. Utilícelo para realizar un programa de aplicación (Main) que al recibir 
los datos de 2 personas imprima el nombre y el dni del menor. 
 */
using System;

namespace Ejercicio4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Persona carlos = new Persona("Carlos", 11111111, new DateTime(1999, 1, 1));
            Persona agustin = new Persona("Agustin", 22222222, new DateTime(2004, 10, 5));
            Persona lautaro = new Persona("Lautaro", 33333333, new DateTime(1997, 12, 4));

            carlos.imprimir();
            agustin.imprimir();
            lautaro.imprimir();

            // Carlos vs Ahustin

            if (!carlos.esMAyorQue(agustin))
            {
                Console.WriteLine("{0} es menor que {1}", carlos.Nombre, agustin.Nombre);
                Console.WriteLine("Datos del menor => Nombre: {0} DNI: {1}", carlos.Nombre, carlos.Dni);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}", carlos.Nombre, agustin.Nombre);
                Console.WriteLine("Datos del menor => Nombre: {0} DNI: {1}", agustin.Nombre, agustin.Dni);
            }

            // Carlos vs Lautaro

            if (!carlos.esMAyorQue(lautaro))
            {
                Console.WriteLine("{0} es menor que {1}", carlos.Nombre, lautaro.Nombre);
                Console.WriteLine("Datos del menor => Nombre: {0} DNI: {1}", carlos.Nombre, carlos.Dni);
            }
            else
            {
                Console.WriteLine("{0} es mayor {1}", carlos.Nombre, lautaro.Nombre);
                Console.WriteLine("Datos del menor => Nombre: {0} DNI: {1}", lautaro.Nombre, lautaro.Dni);
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }

}