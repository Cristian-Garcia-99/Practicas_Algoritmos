using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Materia
    {
        private string nombre;

        public Materia(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get { return nombre; } }
    }
}
