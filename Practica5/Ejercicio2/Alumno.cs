using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio2
{
    class Alumno
    {
        //Atributos

        private string nombre, legajo;
        private ArrayList listaMaterias;

        //Constructor
        public Alumno(string nombre, string legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            listaMaterias = new ArrayList();
        }

        //Propiedades
        public string Nombre { get { return this.nombre; } }
        public string Legajo { get { return this.legajo; } }
        public ArrayList ListaMaterias { get { return this.listaMaterias; } } 

        //Métodos
        public void AgregarMateria(Horario horario)
        {
            listaMaterias.Add(horario);
        }

        public Horario VerMateria(int i)
        {
            return (Horario)listaMaterias[i];    
        }

        /*public ArrayList ListaMaterias()
        { 
            return listaMaterias;
        }*/
    }
}
