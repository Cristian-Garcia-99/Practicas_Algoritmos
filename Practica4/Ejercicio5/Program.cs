/* EJERCICIO 5
Cree una clase llamada Operación con tres variables de instancia: operando1, operando2 y operador. Definir el constructor, 
todas las propiedades y el método evaluar() que será encargado de efectuar la operación solicitada según el tipo de operador 
( ‘+’: sumar, ‘-‘: restar, ‘*’: multiplicar o ‘/’: dividir, operando 1 y operando 2). El programa de aplicación deberá 
imprimir todos los resultados solicitados y calculados.
*/
using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion op1 = new Operacion('+', 10, 20);
            Operacion op2 = new Operacion('-', 10, 20);
            Operacion op3 = new Operacion('*', 10, 20);
            Operacion op4 = new Operacion('/', 10, 20);
            Operacion invalid = new Operacion('/', 1, 0);

            Console.WriteLine(op1.evaluar());
            Console.WriteLine(op2.evaluar());
            Console.WriteLine(op3.evaluar());
            Console.WriteLine(op4.evaluar());
            Console.WriteLine(invalid.evaluar());

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
