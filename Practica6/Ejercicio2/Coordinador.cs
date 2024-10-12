using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Coordinador : Profesor
    {
        private string area;

        public Coordinador(int cupoDisponible, Materia materia, string area) : base(cupoDisponible, materia)
        {
            this.area = area;
        }

        public string Area { get { return area; } }
    }
}
