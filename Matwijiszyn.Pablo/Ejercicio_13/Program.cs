using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            double numero = 0;
            int opcion = 0;
            string binario = "";
            string reverseBinario = "";
            int largo;

            do
            {
                Console.WriteLine("MENU: \n" +
                                  " 1 - Decimal a Binario \n" +
                                  " 2 - Binario a Decimal \n" +
                                  " 3 - Salir \n");
                Console.Write("Ingrese una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese un numero: ");
                        numero = double.Parse(Console.ReadLine());
                        binario = Conversor.DecimalBinario(numero);
                        Console.WriteLine("El numero {0} en binario es {1}", numero, binario);
                        Console.ReadKey();
                        binario = "";
                        reverseBinario = "";
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Ingrese un numero binario: ");
                        binario = Console.ReadLine();
                        largo = binario.Length - 1;
                        while (largo >= 0)
                        {
                            reverseBinario = reverseBinario + binario[largo];
                            largo--;
                        }

                        numero = Conversor.BinarioDecimal(reverseBinario);
                        Console.WriteLine("El numero {0} en decimal es {1}",binario , numero);
                        Console.ReadKey();
                        binario = "";
                        reverseBinario = "";
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Gracias por utilizar el programa");
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != 3);




            Console.ReadLine();
        }
    }
}
