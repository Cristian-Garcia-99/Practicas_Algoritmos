using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Alumno
    {
        private string nombre;
        private string legajo;
        private double promedio;

        public Alumno(string nombre, string legajo, double promedio)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public double Promedio 
        {
            set { this.promedio = value; }
            get { return this.promedio;  } 
        }

        //METODO AGREGADO

        public bool mejorPromedioQue(Alumno otroAlumno)
        {
            if (this.promedio > otroAlumno.Promedio) return true;
            else return false;
        }

    }
}
