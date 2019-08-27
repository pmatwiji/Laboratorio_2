using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        #region notas

        private byte nota1;
        private byte nota2;
        private float notaFinal;

        #endregion

        #region datos

        public string apellido;
        public string nombre;
        public int legajo;

        #endregion


        static Random finalRandom = new Random();


        #region metodos

        public void CalcularFinal()
        {
            
            if (this.nota1 >= 4 && this.nota2 >=4)
            {
                
                this.notaFinal = (float)finalRandom.Next(4, 11);
                
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            if (this.notaFinal != -1)
            {
                return "Alumno " + this.nombre + " " + this.apellido + " con legajo numero: " + this.legajo + ". Nota 1: " + this.nota1 + ". Nota 2: " + this.nota2 + ". Nota final: " + this.notaFinal + ".";
            }
            else
            {
                return "Alumno " + this.nombre + " " + this.apellido + " con legajo numero: " + this.legajo + ". Nota 1: " + this.nota1 + ". Nota 2: " + this.nota2 + ". Alumno desaprobado";
            }
        }


        #endregion

    }
}
