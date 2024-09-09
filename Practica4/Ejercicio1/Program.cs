/*
 * Creado por SharpDevelop.
 * Usuario: Cristian
 * Fecha: 7/9/2024
 * Hora: 15:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
 
 /*
  EJERCICIO 1
Codifique la clase Hora de tal forma que al ejecutar el siguiente programa de aplicación
(Main):
class Program
{
	public static void Main(string[] args)
	{
		Hora h=new Hora(23,30,15);
		h.imprimir();
		Console.ReadKey(true);
	}
}
se imprima por consola: 23 HORAS, 30 MINUTOS Y 15 SEGUNDOS

  */
 
 
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Hora h = new Hora(23,30,15);
			h.imprimir();
			
			Hora hdos = new Hora(10,10,10);
			hdos.imprimir();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}