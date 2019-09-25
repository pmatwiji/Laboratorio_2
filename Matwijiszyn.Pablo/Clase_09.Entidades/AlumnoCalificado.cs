using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class AlumnoCalificado : Alumno
    {
        #region Variables

        protected double nota;

        #endregion

        #region Propiedades

        public double Nota
        {
            get { return this.nota; }
        }

        #endregion

        #region Constructores

        public AlumnoCalificado(Alumno a, double nota):base(a.Nombre,a.Apellido,a.Legajo,a.Examen)
        {
            this.nota = nota;
        }

        public AlumnoCalificado(string nombre,string apellido, int legajo, ETipoExamen examen,double nota): this(new Alumno (nombre,apellido,legajo,examen), nota)
        {

        }

        #endregion

        #region Metodos

        public string Mostrar()
        {
            return Alumno.Mostrar(this) + " Nota: " + this.nota.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
