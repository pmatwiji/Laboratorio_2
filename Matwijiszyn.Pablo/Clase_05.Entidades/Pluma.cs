using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        #region Constructores
        public Pluma()
        {
            this._marca = "Sin marca";
        }

        public Pluma(string marca):this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta):this(marca)
        {
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad):this(marca,tinta)
        {
            this._cantidad = cantidad;
        }
        #endregion


        private string Mostrar ()
        {
            return "Marca: " + this._marca + "\nTinta: " + Tinta.Mostrar(this._tinta) + "\nCantidad: " + this._cantidad.ToString();
        }

        public static implicit operator string (Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return (pluma._tinta == tinta);
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if(pluma._tinta == tinta && pluma._cantidad < 100)
            {
                pluma._cantidad++;
            }
            return pluma;
        }
    }
}
