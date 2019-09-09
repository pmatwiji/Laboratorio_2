using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06.Entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        private Paleta() :this(5)
        {
            
        }

        private Paleta (int cantidadElementos)
        {
            this.colores = new Tempera[cantidadElementos];
            this.cantidadMaximaColores = cantidadElementos;
        }

        public static implicit operator Paleta (int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string Mostrar()
        {
            string Mensaje = "Cantidad: " + this.cantidadMaximaColores + "\n";

            for(int i = 0; i<cantidadMaximaColores; i++)
            {
                Mensaje = Mensaje + this.colores[i].ToString() + "\n";
            }
            return Mensaje;
        }


        public static explicit operator string (Paleta paleta)
        {
            return paleta.Mostrar();
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            if(!Object.Equals(paleta,null) && !Object.Equals(tempera,null))
            {
                for(int i = 0; i<paleta.colores.Length; i++)
                {
                    if(paleta.colores[i] == tempera)
                    {
                        return true;
                        
                    }
                }
                return false;
            }
            else
            {
                return Object.Equals(paleta,tempera);
            }
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        private int ObtenerLugarLibre()
        {
            int posicion = -1;
            for(int i = 0;i<this.colores.Length;i++)
            {
                if(this.colores[i] == null)
                {
                    posicion = i;
                    break;
                }
            }
            return posicion;
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            bool aux = false;
            int posicion = -1;
            int posicionTempera = -1;

            if (paleta == tempera)
            {
                posicionTempera = paleta | tempera;
                paleta.colores[posicionTempera] = paleta.colores[posicionTempera] + tempera;
                aux = true;
            }

            if (aux == false)
            {
                for (int i = 0; i < paleta.colores.Length; i++)
                {
                    posicion = paleta.buscarLibre();
                }
                if (posicion != -1)
                {
                    paleta.colores[posicion] = tempera;
                }
            }
            return paleta;
        }

        private int buscarLibre()
        {
            int posicion = -1;
            for (int i = 0; i < this.colores.Length; i++)
            {
                if (Object.Equals(this.colores[i], null))
                {
                    posicion = i;
                    break;
                }
            }
            return posicion;
        }

        public static int operator |(Paleta paleta, Tempera tempera)
        {
            int posicion = -1;
            for (int i = 0; i < paleta.colores.Length; i++)
            {
                if (paleta.colores[i] == tempera)
                {
                    posicion = i;
                    break;
                }
            }
            return posicion;
        }
    }
}
