using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            int entero = 0;
            int resto;

            entero = (int)numero;
            

            while (entero > 0)
            {
                resto = (entero % 2);

                if (resto == 0)
                {
                    binario = 0 + binario;
                }
                else
                {
                    binario = 1 + binario;
                }

                entero = entero / 2;
            }
            return binario;
        }
        public static double BinarioDecimal(string binario)
        {
            double numero = 0;
            int multiplicador = 2;
            int i;

            if (binario[0] == '1')
            {
                numero = numero + 1;
            }

            for (i=1 ; i < binario.Length; i++)
            {
                if (binario[i] == '1')
                {
                    numero = numero + multiplicador;
                }
                multiplicador = (int)Math.Pow(2, i+1);
            }

            multiplicador = 2;
            return numero;
        }
    }
}
