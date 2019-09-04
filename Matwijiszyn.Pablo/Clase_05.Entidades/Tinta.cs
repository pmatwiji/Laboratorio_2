using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo; //Enumerado propio

        #region Constructores

        public Tinta() 
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color):this()
        {
            this._color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo):this(color)
        {
            this._color = color;
            this._tipo = tipo;
        }

        #endregion

        private string Mostrar()
        {
            return "Color: " + this._color.ToString() + ", Tipo: " + this._tipo.ToString();
        }

        public static string Mostrar(Tinta ver)
        {
            return ver.Mostrar();
        }

        public static bool operator == (Tinta primerElemento, Tinta segundoElemento)
        {
            //bool comparacion = false;

            //if(primerElemento._color == segundoElemento._color && primerElemento._tipo == segundoElemento._tipo)
            //{
            //    comparacion = true;
            //}

            //return comparacion; 
            if(!Object.Equals(primerElemento,null) && !Object.Equals(segundoElemento,null))
            {
                return (primerElemento._color == segundoElemento._color && primerElemento._tipo == segundoElemento._tipo);
            }
            else
            {
                if(Object.Equals(primerElemento,null) && Object.Equals(segundoElemento,null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool operator !=(Tinta primerElemento, Tinta segundoElemento)
        {
            return !(primerElemento == segundoElemento);
        }

        public static bool operator ==(Tinta primerElemento,ConsoleColor color)
        {
            bool comparacion = false;

            if (primerElemento._color == color)
            {
                comparacion = true;
            }

            return comparacion;
        }

        public static bool operator !=(Tinta primerElemento, ConsoleColor color)
        {
            return !(primerElemento == color);
        }

        public static explicit operator string (Tinta tinta)
        {
            return tinta.Mostrar();
        }


    }
}
