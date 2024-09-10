using System;
using System.Collections;

/* EJERCICIO EXTRA
Crear la clase Alumno con nombre,  apellido,  legajo y nota.
Crear varios alumnos en la aplicación  y guardarlos en  un listado (array o arrayList).
Recorrer ese listado e imprimir los alumnos que tengan más nota que el promedio.
Traten de hacerlo para esta semana,  antes del martes que viene.
*/

namespace Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables de operación

            int promedio, sum = 0;
            ArrayList alumnos = new ArrayList();

            //Instancio los alumnos

            Alumno carlos = new Alumno("Carlos", "Rodriguez", 11111, 5);
            Alumno luna = new Alumno("Luna", "Vazques", 22222, 8);
            Alumno victoria = new Alumno("Victoria", "Di Cecco", 33333, 3);
            Alumno ariel = new Alumno("Ariel", "Kuntz", 44444, 9);
            Alumno juan = new Alumno("Juan", "Ballone", 55555, 3);
            Alumno florencia = new Alumno("Florencia", "De Luca", 66666, 9);

            //Agrego los alumnos al array

            alumnos.Add(carlos); 
            alumnos.Add(luna);
            alumnos.Add(victoria);
            alumnos.Add(ariel);
            alumnos.Add(juan);
            alumnos.Add(florencia);

            //Calculo el promedio gracias a que todos los atributos de la clase son propiedades

            foreach(Alumno alumno in alumnos) sum += alumno.Nota;
            promedio = sum / alumnos.Count;
            Console.WriteLine("El promedio de la nota de los alumnos es: {0}", promedio);

            //Comparo la nota con el promedio

            Console.WriteLine("***Listado de Alumnos con mejor promedio***"); 
            foreach(Alumno alumno in alumnos)
            {
                if(alumno.Nota > promedio)
                {
                    Console.WriteLine("* Apellido, Nombre: {0}, {1} / Legajo: {2} / Nota: {3}", alumno.Apellido, alumno.Nombre, alumno.Legajo, alumno.Nota);
                }
            }

            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey(true);

        }
    }
}
