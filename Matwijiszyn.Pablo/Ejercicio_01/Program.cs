using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            /*
            string nombre;
            string apellido;

            Console.Title = "Ejercicio Bienvenida";
            Console.WriteLine("Hola mundo Cs");   


            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();


            Console.WriteLine("Ingrese apellido: "); 
            apellido = Console.ReadLine();

            Console.WriteLine("Su nombre es {0} {1}", nombre, apellido);
            Console.ReadLine();
            */

            int numero;
            int acumulador = 0;
            float promedio;
            int maximo = 0;
            int minimo = 0;

            int i;

            for(i=0;i<5;i++)
            {
                Console.Write("Numero {0}: ", (i + 1));
                numero = int.Parse(Console.ReadLine());
                if(i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else if(numero > maximo)
                {
                    maximo = numero;
                }
                else if(numero < minimo)
                {
                    minimo = numero;
                }

                acumulador = acumulador + numero;
            }

            promedio = (float) acumulador / i;

            Console.WriteLine("Promedio {0} , Minimo {1} , Maximo {2}", promedio, minimo, maximo);


            Console.ReadLine();
        }
    }
}
