using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            int numero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            while (numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado de su numero es {0}", cuadrado);
            Console.WriteLine("El cubo de su numero es {0}", cubo);

            Console.ReadLine();
        }
    }
}
