using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Horario
    {
        private string hora, materia, dia;

        public Horario(string dia, string hora, string materia)
        {
            this.dia = dia;
            this.hora = hora;
            this.materia = materia;
        }

        public string Hora { get { return hora; } }
        public string Dia { get { return dia; } }
        public string Nombre { get { return materia; } }

        public void imprimir()
        {
            Console.WriteLine("Materia: {0} | Horario: {1} | Día: {2}", this.materia, this.hora, this.dia);
        }
    }
}
