using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio 15";

            double numeroA = 0;
            double numeroB = 0;
            char operacion = ' ';
            double resultado = 0;
            char input;

            do
            {
                Console.Write("Ingrese el primer numero: ");
                numeroA = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                numeroB = double.Parse(Console.ReadLine());
                Console.Write("Que operacion desea realizar? ( + , - , * , / ) ");
                operacion = (Console.ReadKey().KeyChar);
                resultado = Calculadora.Calcular(numeroA, numeroB, operacion);
                Console.Write("¿Continuar? (S/N) ");
                input = char.Parse(Console.ReadLine());
            } while (Calculadora.ValidaS_N(input) == true);

            Console.WriteLine("Gracias por utilizar la calculadora");
            Console.ReadKey();
            
        }
    }
}
