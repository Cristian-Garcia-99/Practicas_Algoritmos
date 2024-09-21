using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implemente la clase horario que permite guardar día, hora y materia a cursar en ese horario

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horario tarde_1 = new Horario("Martes", "12:00", "Algoritmos y programación");
            Horario tarde_2 = new Horario("Viernes", "13:00", "Organización y Arquiotectura");

            tarde_1.imprimir();
            tarde_2.imprimir();

            Console.WriteLine(tarde_2.Hora);

            Console.ReadKey(true);
        }
    }
}
