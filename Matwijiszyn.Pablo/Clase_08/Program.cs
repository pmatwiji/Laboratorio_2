﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_08.Entidades;

namespace Clase_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capitulo c1 = "Primer capitulo";
            //Capitulo c2 = "Segundo capitulo";
            //Capitulo c3 = "Tercer capitulo";

            //Console.WriteLine(c1.MiNumero);
            //Console.WriteLine(c2.MiTitulo);
            //Console.WriteLine(c3.MisPaginas);

            Libro miLibro = new Libro("C# al descubierto", "Joe Mayo");

            miLibro[0] = "Fundamentos Básicos de C#";
            miLibro[1] = "Cómo comenzar con C#";
            miLibro[2] = "Cómo escribir expresiones con C#";

            miLibro[-1] = "Genero un índice erroneo";

            miLibro[5] = "Genero otro índice erroneo";





            Console.WriteLine("Libro:");

            Console.WriteLine("Titulo: {0}", miLibro.MiTitulo);

            Console.WriteLine("Autor: {0}", miLibro.MiAutor);

            Console.WriteLine("Cantidad de páginas: {0}", miLibro.CantidadDePaginas);



            for (int i = 0; i < miLibro.CantidadDeCapitulos; i++)

            {

                Console.WriteLine("Capitulo {0}: {1} {2}", miLibro[i].MiNumero, miLibro[i].MiTitulo, miLibro[i].MisPaginas);

            }

            Console.ReadLine();
        }
    }
}
