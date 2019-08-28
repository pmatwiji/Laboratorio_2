using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase__04.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public string Mostrar()
        {
            return this.entero.ToString() + "\n " + this.cadena + "\n " + this.fecha.ToString();
        }

        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Cosa()
        {
            this.entero = -1;
            this.cadena = "";
            this.fecha = DateTime.Now;
        }
        #region forma basica
        //public Cosa(string cadena)
        //{
        //    this.entero = -1;
        //    this.cadena = cadena;
        //    this.fecha = DateTime.Now;
        //}

        //public Cosa(string cadena, DateTime fecha)
        //{
        //    this.entero = -1;
        //    this.cadena = cadena;
        //    this.fecha = fecha;
        //}

        //public Cosa(string cadena, DateTime fecha, int entero)
        //{
        //    this.entero = entero;
        //    this.cadena = cadena;
        //    this.fecha = fecha;
        //}

        #endregion

        #region sobrecarga

        public Cosa(string cadena):this()
        {
            this.cadena = cadena;
        }

        public Cosa(string cadena, DateTime fecha):this(cadena)
        {
            this.fecha = fecha;
        }

        public Cosa(string cadena, DateTime fecha, int entero):this(cadena,fecha)
        {
            this.entero = entero;
        }
        #endregion
    }
}
