using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio 11";
            int numero = 0;
            int acumulador = 0;
            int maximo = 0;
            int minimo = 0;
            int limiteMinimo = -100;
            int limiteMaximo = 100;
            float promedio;

            int i;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Numero {0}: ", (i + 1));
                numero = int.Parse(Console.ReadLine());
                while(Validacion.Validar(numero,limiteMinimo,limiteMaximo)==false)
                {
                    //Console.WriteLine("Error, numero fuera de rango. El numero debe estar entre {0} y {1}",limiteMinimo, limiteMaximo);
                    Console.Write("Numero {0}: ", (i + 1));
                    numero = int.Parse(Console.ReadLine());
                }
                if (i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }

                acumulador = acumulador + numero;
            }

            promedio = (float)acumulador / i;

            Console.WriteLine("Promedio {0} , Minimo {1} , Maximo {2}", promedio, minimo, maximo);

            Console.ReadKey();
        }
    }
}
