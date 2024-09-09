using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Persona
    {
        private string nombre;
        private int dni;
        private long año, año_actual, edad;
        private DateTime fecha;

        public Persona(string nombre, int dni, DateTime fecha)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.fecha = fecha;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public DateTime Fecha
        {
            get { return this.fecha; }
        }

        public void imprimir()
        {
            DateTime fecha_actual = DateTime.Now;
            año = this.fecha.Year;
            año_actual = fecha_actual.Year;
            this.edad = año_actual - año;

            Console.WriteLine("{0} ({1}) {2}", this.nombre, this.edad, this.dni);
        }

        public bool esMAyorQue(Persona pasada)
        {
            if (this.fecha.Year < pasada.Fecha.Year) return true;
            else return false;
        }
    }
}
