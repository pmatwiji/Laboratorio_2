using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo (short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;

            if (this.tinta < 0)
                this.tinta = 0;

            if (this.tinta > cantidadTintaMaxima)
                this.tinta = cantidadTintaMaxima;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(int gasto, out string indicador)
        {
            bool retorno = false;
            indicador = "";
            int porcentaje;
            porcentaje = ((this.tinta - gasto) * 100) / this.tinta;
            porcentaje = 100 - porcentaje;
            porcentaje = porcentaje / 10;

            if (this.tinta - gasto > 0)
            {
                retorno = true;
                for (int i = 0; i < porcentaje; i++)
                {
                    indicador = indicador + '*';
                }
                SetTinta((short)gasto);
            }
            return retorno;
        }



        
    }
}
