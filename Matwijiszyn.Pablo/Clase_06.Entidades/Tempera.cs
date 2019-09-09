using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Tempera
    {
        #region Variable

        private ConsoleColor color;
        private string marca;
        private int cantidad;

        #endregion

        #region Constructor

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        #endregion

        private string Mostrar()
        {
            return "Color: " + this.color.ToString() + "\nMArca: " + this.marca + "\nCantidad: " + this.cantidad.ToString();
        }


        public static implicit operator string (Tempera tempera)
        {
            return tempera.Mostrar();
        }

        public static bool operator ==(Tempera marca, Tempera color)
        {
            if(!Object.Equals(marca,null) && !Object.Equals(color,null))
            {
                return true;
            }
            else
            {
                if (Object.Equals(marca, null) && Object.Equals(color, null))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public static bool operator !=(Tempera marca, Tempera color)
        {
            return !(marca == color);
        }

        public static Tempera operator +(Tempera tempera, int cantidad)
        {
            if (tempera.cantidad == cantidad)
            {
                tempera.cantidad = tempera.cantidad + cantidad;
            }
            return tempera;
        }

        public static Tempera operator +(Tempera temperaUno, Tempera temperaDos)
        {
            if(temperaUno == temperaDos)
            {
                temperaUno = temperaUno + temperaDos.cantidad;
            }

            return temperaUno;
        }



    }
}
