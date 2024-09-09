/*
 * Creado por SharpDevelop.
 * Usuario: Cristian
 * Fecha: 7/9/2024
 * Hora: 15:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
 
/* EJERCICIO 3
Modifique la clase anterior agregando un campo privado FechaNacimiento. Defina un nuevo
constructor que reciba como parámetro el nombre, la fecha de nacimiento (un DateTime) y el dni. En base a
la fecha de nacimiento y la fecha actual debe calcular y guardar la edad. 
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			//DateTime fecha1 = new DateTime(1999, 8, 21);
			
			Persona cristian = new Persona("Cristian", 1111111, new DateTime(1999, 8, 21));
			
			cristian.imprimir();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
}