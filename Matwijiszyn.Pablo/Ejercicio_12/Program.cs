using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            int numero = 0;
            int acumulador = 0;
            char input;

            do
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;
                Console.Write("¿Continuar? (S/N)");
                input = char.Parse(Console.ReadLine());

            } while (ValidarRespuesta.ValidaS_N(input)==true);

            Console.WriteLine("Total acumulado: {0}", acumulador);
            Console.ReadKey();
        }
    }
}
