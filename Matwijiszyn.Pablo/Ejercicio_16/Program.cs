using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            Alumno alumnoUno = new Alumno();
            Alumno alumnoDos = new Alumno();
            Alumno alumnoTres = new Alumno();

            Random notaRandom = new Random();

            alumnoUno.nombre = "Pablo";
            alumnoUno.apellido = "Matwijiszyn";
            alumnoUno.legajo = 1;

            alumnoDos.nombre = "Adrian";
            alumnoDos.apellido = "Brizuela";
            alumnoDos.legajo = 2;

            alumnoTres.nombre = "Axel";
            alumnoTres.apellido = "Ghio";
            alumnoTres.legajo = 3;

            alumnoUno.Estudiar(6, 7);
            alumnoUno.CalcularFinal();
            Console.WriteLine(alumnoUno.Mostrar());

            alumnoDos.Estudiar((byte)notaRandom.Next(1, 11),(byte)notaRandom.Next(1,11));
            alumnoDos.CalcularFinal();
            Console.WriteLine(alumnoDos.Mostrar());

            alumnoTres.Estudiar((byte)notaRandom.Next(1, 11), (byte)notaRandom.Next(1, 11));
            alumnoTres.CalcularFinal();
            Console.WriteLine(alumnoTres.Mostrar());
            Console.ReadKey();
        }
    }
}
