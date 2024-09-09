using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Operacion
    {
        private char operador;
        private float num_1, num_2;

        public Operacion(char operador, int num_1, int num_2)
        {
            this.operador = operador;
            this.num_1 = num_1;
            this.num_2 = num_2;
        }

        public float evaluar()
        {
            switch (this.operador)
            {
                case '+': return num_1 + num_2;
                case '-': return num_1 - num_2;
                case '*': return num_1 * num_2;
                case '/':
                    if (num_2 != 0) return num_1 / num_2;
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero");
                        return 0;
                    }
                default: return 0;
            }
        }
    }
}
