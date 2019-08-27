using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 03";

            Persona miPersona = new Persona("Pablo","Matwijiszyn",35630715);

            //miPersona.nombre = "Pablo";
            //miPersona.apellido = "Matwijiszyn";
            //miPersona.dni = 35630715;

            Console.Write(miPersona.Mostrar());

            Persona otraPersona = new Persona("Adrian","Brizuela",36084952);

            //otraPersona.nombre = "Adrian";
            //otraPersona.apellido = "Brizuela";
            //otraPersona.dni = 36084952;
            

            Console.Write(otraPersona.Mostrar());
            Console.ReadKey();
        }
    }
}
