using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Alumno
    {
        #region Variables

        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        #endregion

        #region Propiedades

        public string Apellido
        {
            get { return this.apellido; }
        }

        public ETipoExamen Examen
        {
            get { return this.examen; }
        }

        public int Legajo
        {
            get { return this.legajo; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        #endregion

        #region Constructor

        public Alumno(string nombre,string apellido,int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }

        

        #endregion


        #region Sobrecargas

        public static bool operator ==(Alumno a, Alumno b)
        {
            if (a.legajo == b.legajo )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }

        #endregion

        #region Metodos

        public static string Mostrar(Alumno a)
        {
            return "Alumno: " + a.nombre + " " + a.apellido + " \nLegajo: " + a.legajo.ToString() + " \nExamen: " + a.examen.ToString();
            
        }

        public override string ToString()
        {
            return Alumno.Mostrar(this);
        }

        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            return a.apellido.CompareTo(b.apellido);
        }

        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return -1 * OrdenarPorApellidoAsc(a, b);
        }

        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            return a.legajo.CompareTo(b.legajo);
        }

        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            return -1 * OrdenarPorLegajoAsc(a, b);
        }

        #endregion

    }
}
