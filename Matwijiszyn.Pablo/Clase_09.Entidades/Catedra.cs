﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Catedra
    {
        #region Variables

        private List<Alumno> alumnos;

        #endregion

        #region Propiedades

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
        }

        #endregion

        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }

        public Alumno this[int Index]
        {
            get { return this.Alumnos[Index]; }
            set { this.Alumnos[Index] = value; }
        }

        #region Sobrecargas

        public static bool operator ==(Catedra c, Alumno a)
        {
            bool retorno = false;
            if (Object.Equals(c, null) == false && Object.Equals(a, null) == false)
            {
                if (c.alumnos.Contains(a))
                    retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);
        }

        public static bool operator +(Catedra c, Alumno a)
        {
            bool retorno = false;
            if (Object.Equals(c, null) == false && Object.Equals(a, null) == false)
            {
                if (c != a)
                {
                    c.alumnos.Add(a);
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator -(Catedra c, Alumno a)
        {
            bool retorno = false;
            if (Object.Equals(c, null) == false && Object.Equals(a, null) == false)
            {
                if (c == a)
                {
                    c.alumnos.Remove(a);
                    retorno = true;
                }
            }
            return retorno;
        }

        #endregion

    }
}
