/*
 * Creado por SharpDevelop.
 * Usuario: Cristian
 * Fecha: 7/9/2024
 * Hora: 15:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio2
{
	public class Persona
	{
		private string nombre;
		private int edad, dni;
		
		public Persona(string nombre, int edad, int dni)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.dni = dni;
		}
		
		public void imprimir()
		{
			Console.WriteLine("{0} ({1}) {2}", this.nombre, this.edad, this.dni);
		}
		
	}
}
