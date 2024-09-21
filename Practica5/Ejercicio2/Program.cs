using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*EJERCICIO 2
Implemente la clase Alumno para modelar alumnos en una Universidad. Agréguele como estado lo que considere necesario 
para el problema. Piense ¿cómo implementaría los horarios de cursada de un alumno? (debe usar la clase del ejercicio anterior)
Como comportamiento implemente el método agregarMateria(string dia, string hora, string materia) que agrega a los horarios del alumno 
la materia en ese día y hora, si es que tiene libre el horario.
Piense qué otros métodos podría definir.
En una aplicación arme una lista de alumnos con sus horarios de cursada. Defina un menú que permita inscribir alumnos en una materia, 
imprimir los alumnos inscriptos en una materia dada, informar 
cuántas materias cursa un alumno e imprimir la lista de todos los alumnos.
Observación: la lista de alumnos puede ser un Array o un ArrayList (no hay que definir otra clase nueva).
*/

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaAlumnos = new ArrayList();
            ArrayList listaHorarios = new ArrayList();

            Horario algoritmos = new Horario("Martes", "12:00", "Algoritmos y Programación");
            Horario so = new Horario("Miercoles", "13:00", "Sistemas Operativos");
            Horario arqui = new Horario("Viernes", "14:00", "Organización y Arquitectura");
            Horario mate = new Horario("Lunes", "14:30", "Matemáticas 1");

            Alumno pablo = new Alumno("Pablo Ramirez", "111111");
            Alumno juan = new Alumno("Juan Palacios", "222222");
            Alumno camila = new Alumno("Camila Santos", "333333");

            //Lista de alumnos precargados

            listaAlumnos.Add(pablo);
            listaAlumnos.Add(juan);
            listaAlumnos.Add(camila);

            //Lista de horarios

            listaHorarios.Add(algoritmos);
            listaHorarios.Add(so);
            listaHorarios.Add(arqui);
            listaHorarios.Add(mate);

            //Crear Alumno y agregar a la lista

            string nombre, legajo;
            int op = 0;
            Console.WriteLine("Desea crear un Alumno");
            Console.WriteLine("1-SI || 0-NO: ");
            op = int.Parse(Console.ReadLine());
            while (op != 0)
            {
                Console.Write("Escriba el Nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Escriba el legajo: ");
                legajo = Console.ReadLine();

                listaAlumnos.Add(new Alumno(nombre, legajo));

                Console.WriteLine("Desea Continuar? ");
                Console.WriteLine("1-SI || 0-NO: ");
                op = int.Parse(Console.ReadLine());
            }

            //Cargar materias por Alumnos

            op = 0;
            foreach (Alumno alumno in listaAlumnos)
            {
                Console.WriteLine();
                Console.WriteLine("Alumno: {0}", alumno.Nombre);
                foreach(Horario materia in listaHorarios)
                {
                    Console.WriteLine("Desea Inscribir la metria {0}", materia.Nombre);
                    Console.WriteLine("1-SI || 0-NO: ");
                    op = int.Parse(Console.ReadLine());
                    if(op != 0)
                    {
                        alumno.AgregarMateria(materia);
                        op = 0;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            //Imprimir materias por alumno

            foreach(Alumno alumno in listaAlumnos)
            {
                Console.WriteLine();
                Console.WriteLine("Alumno: {0}", alumno.Nombre);
                foreach (Horario materia in alumno.ListaMaterias) materia.imprimir();
            }

            Console.WriteLine("Presione una tecla para continuar...");  
            Console.ReadKey(true);
        }
    }
}
