using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 18";

            string impresionAzul;
            string impresionRojo;
            ConsoleColor actual = Console.ForegroundColor;

            Boligrafo azul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);

            if (azul.Pintar(30, out impresionAzul) == true)
            {
                Console.ForegroundColor = azul.GetColor();
                Console.WriteLine("Gasto de tinta azul: {0}", impresionAzul);
                Console.WriteLine($"Gasto de tinta azul: {impresionAzul}");
                Console.ForegroundColor = actual;
            }

            if (rojo.Pintar(20, out impresionRojo) == true)
            {
                Console.ForegroundColor = rojo.GetColor();
                Console.WriteLine("Gasto de tinta roja: {0}", impresionRojo);
                Console.WriteLine($"Gasto de tinta roja: {impresionRojo}");
                
                Console.ForegroundColor = actual;
            }

            Console.ReadLine();
        }

    }
}
