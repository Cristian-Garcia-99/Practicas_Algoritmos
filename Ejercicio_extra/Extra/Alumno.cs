using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
    internal class Alumno
    {
        private string nombre, apellido;
        private int legajo, nota;

        public Alumno(string nombre, string apellido, int legajo, int nota)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.nota = nota;
        }

        //Como el ejecicio no pide modificar los atributos todas las propiedades solo serán del tipo get
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Legajo { get { return this.legajo; } }
        public int Nota { get { return this.nota; } }

    }
}
