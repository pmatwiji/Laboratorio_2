using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase__04.Entidades;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa MiCosa = new Cosa();
            Cosa MiCosa2 = new Cosa("hola");
            Cosa MiCosa3 = new Cosa("hola", DateTime.Now);
            Cosa MiCosa4 = new Cosa("hola", DateTime.Now, 4);

            Console.WriteLine(MiCosa.Mostrar());
            Console.WriteLine(MiCosa2.Mostrar());
            Console.WriteLine(MiCosa3.Mostrar());
            Console.WriteLine(MiCosa4.Mostrar());

            Console.ReadKey();
        }
    }
}
