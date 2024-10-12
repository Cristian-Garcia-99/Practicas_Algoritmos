using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/* EJERCICIO 2 
Dadas las siguientes clases: Alumno, Materia, Profesor, Coordinador:

a) Agregue a la clase Alumno el método mejorPromedioQue(Alumno otroA) que retorne verdadero
si el alumno que recibe el mensaje tiene promedio más alto que el otro alumno que se pasa como parámetro.

b)
*/

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Preseteo MAterias

            Materia algebra = new Materia("Álgebra");
            Materia ingles = new Materia("Inglés");
;           Materia calculo = new Materia("Cálculo");

            //Instancio profesores

            Profesor juan = new Profesor(3, algebra);
            Profesor ramiro = new Profesor(4, ingles);
            Profesor jesica = new Profesor(2, new Materia("Geometría"));

            //Instancio Alumnos

            Alumno cristian = new Alumno("Cristian", "111111", 9.7);
            Alumno marcelo = new Alumno("Marcelo", "222222", 6.00);

            //---Programa---

            //Punto A
            if (cristian.mejorPromedioQue(marcelo)) Console.WriteLine("Cristian tiene mejor promedio");
            else Console.WriteLine("MArcelo tiene mejor promedio");

            //Punto B

            Coordinador alberto = new Coordinador(4, algebra, "Basicas");

            int op = 0;
            Console.WriteLine("---Alta de alumnos---");
            Console.WriteLine("Quedan {0} cupos disponibles", alberto.CupoDisponible);
            while(alberto.CupoDisponible > 0)
            {
                Console.Write("Ingrese Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese Legajo: ");
                string legajo = Console.ReadLine();
                Console.Write("Ingrese promedio: ");
                double promedio = double.Parse(Console.ReadLine());
                alberto.AltaAlumno(new Alumno(nombre, legajo, promedio));

                Console.WriteLine("Desea continiar: 1-SI, 0-NO");
                op = int.Parse(Console.ReadLine());
                if (op == 0) break;   
            }
            if (alberto.CupoDisponible == 0) Console.WriteLine("NO HAY MAS CUPOS");



            Console.WriteLine("***Oprima una tecla para terminar***");
            Console.ReadKey(true);
        }
    }
}
