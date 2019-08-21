using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int numero;
            int i = 1;
            int j = 1;
            int contador = 0;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            while (i++ < numero)
            {
                while (j++ < i)
                {
                    if (i % j == 0 && contador < 2)
                    {
                        if (j == i)
                        {
                            Console.WriteLine("{0} es numero primo", i);
                        }

                        contador++;
                    }
                }

                contador = 0;
                j = 0;
            }

            Console.ReadLine();
        }
    }
}
