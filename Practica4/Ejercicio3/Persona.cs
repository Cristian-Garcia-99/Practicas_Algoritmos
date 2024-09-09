/*
 * Creado por SharpDevelop.
 * Usuario: Cristian
 * Fecha: 7/9/2024
 * Hora: 16:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio3
{
	
	public class Persona
	{
		private string nombre;
		private int dni;
		private long año, año_actual, edad;
		private DateTime fecha;
		
		public Persona(string nombre, int dni, DateTime fecha)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.fecha = fecha;
		}
		
		public void imprimir()
		{
			DateTime fecha_actual = DateTime.Now;
			año = this.fecha.Year;
			año_actual = fecha_actual.Year;
			this.edad = año_actual - año;
			
			Console.WriteLine("{0} ({1}) {2}", this.nombre, this.edad, this.dni);
		}
	}
}
