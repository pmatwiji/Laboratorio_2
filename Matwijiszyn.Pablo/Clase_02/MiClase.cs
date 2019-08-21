using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Clase_02
{
    public class MiClase
    {
        public static string nombre;
        public static int edad;

        public static void MostrarEdad()
        {
            Console.WriteLine(MiClase.edad);
            //Console.ReadLine();
        }

        public static string RetornarNombre()
        {
            Console.Write("Ingrese su nombre: ");
            MiClase.nombre = Console.ReadLine();
            return MiClase.nombre;
        }

        public static bool CompararNombres (string nombre)
        {
            bool comprobacion = false;
            if(nombre == MiClase.nombre)
            {
                comprobacion = true;
            }
            return comprobacion;
        }
    }
}
