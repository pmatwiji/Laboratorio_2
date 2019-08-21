using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {

            mensaje = Sello.ArmarFormatoMensaje();
            return Sello.mensaje;
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static string ImrpimirEnColor()
        {
            color = ConsoleColor.DarkGreen;
            Console.ForegroundColor = color;
            //Sello.Imprimir();
            return Sello.mensaje;

        }

        static string ArmarFormatoMensaje()
        {
            int largo;
            string borde = "**";
            int i;
            largo = Sello.mensaje.Length;
            for(i=0;i<largo;i++)
            {
                borde = borde + "*";
            }

            Sello.mensaje = borde + "\n" + "*" + Sello.mensaje + "*" + "\n" + borde;

            return Sello.mensaje;
        }

    }
}
