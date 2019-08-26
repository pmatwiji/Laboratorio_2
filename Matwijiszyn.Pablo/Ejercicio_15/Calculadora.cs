using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular (double numeroA, double numeroB, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = numeroA + numeroB;
                    Console.WriteLine("\nEl resultado es: {0}", resultado);
                    Console.ReadKey();
                    break;
                case '-':
                    resultado = numeroA - numeroB;
                    Console.WriteLine("\nEl resultado es: {0}", resultado);
                    Console.ReadKey();
                    break;
                case '*':
                    resultado = numeroA * numeroB;
                    Console.WriteLine("\nEl resultado es: {0}", resultado);
                    Console.ReadKey();
                    break;
                case '/':
                    if(Calculadora.Validar(numeroB) == true)
                    {
                        resultado = numeroA / numeroB;
                        Console.WriteLine("\nEl resultado es: {0}", resultado);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nImposible hacer la operacion");
                        Console.ReadKey();
                    }
                    break;
                default:
                    Console.WriteLine("\nIngrese una opearcion valida");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

            return resultado;
        }

        private static bool Validar (double segundoNum)
        {
            bool validacion = false;
            if(segundoNum != 0)
            {
                validacion = true;
            }
            return validacion;
        }

        public static bool ValidaS_N(char c)
        {
            bool validacion = false;

            if (c == 's' || c == 'S')
            {
                validacion = true;
                Console.Clear();
            }

            return validacion;
        }
    }
}
