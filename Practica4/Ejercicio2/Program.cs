/*
 * Creado por SharpDevelop.
 * Usuario: Cristian
 * Fecha: 7/9/2024
 * Hora: 15:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
 
/* EJERCICIO 2
Defina la clase Persona con 3 campos: Nombre, Edad y DNI. En el constructor utilice parámetros cuyos
nombres coincidan con las variables de instancia del objeto (usar this). Definir un método que permita
imprimir los datos de la persona con el siguiente formato: Nombre (Edad) <TAB> DNI.
Ejemplo: Juan Perez (40) 2098745 
*/
 
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Persona persona_1 = new Persona("Juan Perez", 40, 2098745);
			persona_1.imprimir();
			
			Persona persona_2 = new Persona("Gael Pedernera", 20, 111111111);
			persona_2.imprimir();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}