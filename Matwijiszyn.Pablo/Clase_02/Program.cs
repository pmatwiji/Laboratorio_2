using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiLibreria;
using Clase_02.Entidades;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02";
            /*
            MiClase.edad = 10;
            MiClase.MostrarEdad();

            MiClase.RetornarNombre();
            Console.WriteLine(MiClase.nombre);

            Console.WriteLine(MiClase.CompararNombres("pablo"));
            */
            Console.Write("Ingrese el mensaje: ");
            Sello.mensaje = Console.ReadLine();
            Console.Write(Sello.Imprimir());
            Console.ReadLine();
            Console.WriteLine(Sello.ImrpimirEnColor());
            Console.ReadLine();
            Sello.Borrar();




            Console.ReadLine();
        }
    }
}
