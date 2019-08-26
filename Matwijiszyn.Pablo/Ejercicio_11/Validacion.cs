using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool Validar (int valor, int min, int max)
        {
            bool validacion = true;

            if(valor < min || valor > max)
            {
                Console.WriteLine("Error, numero fuera de rango. El numero debe estar dentro de {0} y {1}", min, max);
                validacion = false;
            }

            return validacion;
        }
    }
}
