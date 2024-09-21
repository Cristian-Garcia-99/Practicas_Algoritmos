using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implemente la clase horario que permite guardar día, hora y materia a cursar en ese horario

namespace Ejercicio1
{
    public class Horario
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
        public string Materia { get {return materia; } }

        public void imprimir()
        {
            Console.WriteLine("Materia: {0} | Horario: {1} | Día: {2}", this.materia, this.hora, this.dia);
        }
    }
}
