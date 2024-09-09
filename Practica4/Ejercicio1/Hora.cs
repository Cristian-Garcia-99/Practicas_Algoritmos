/*
 * Creado por SharpDevelop.
 * Usuario: Cristian
 * Fecha: 7/9/2024
 * Hora: 15:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio1
{
	public class Hora
	{
		private int hora, minuto, segundo;
		
		public Hora(int hora, int minuto, int segundo)
		{
			this.hora = hora;
			this.minuto = minuto;
			this.segundo = segundo;
		}
		
		public void imprimir()
		{
			Console.WriteLine("{0} HORAS, {1} MINUTOS, {2} SEGUNDOS", this.hora, this.minuto, this.segundo);
		}
	}
}
