using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio2
{
    public class Profesor
    {
        protected ArrayList alumnos;
        protected int cupoDisponible;
        protected Materia materia;

        public Profesor(int cupoDisponible, Materia materia)
        {
            this.cupoDisponible = cupoDisponible;
            this.materia = materia;
            this.alumnos = new ArrayList();
        }

        public void AltaAlumno(Alumno alumno)
        { 
            alumnos.Add(alumno);
            cupoDisponible--;
        }

        //Agrego get al cupo

        public int CupoDisponible { get { return this.cupoDisponible; } }
    }
}
