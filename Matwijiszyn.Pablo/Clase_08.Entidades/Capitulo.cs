using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_08.Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;

        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;



        public int MiNumero
        {
            get { return this.numero; }

        }


        public string MiTitulo
        {
            get { return this.titulo; }
        }

        public int MisPaginas
        {
            get { return this.paginas; }
        }


        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }

        private Capitulo(int numero, string titulo, int paginas)
        {
            this.numero = numero;
            this.titulo = titulo;
            this.paginas = paginas;
        }

        public static implicit operator Capitulo(string capitulo)
        {
            int paginas = Capitulo.generadorDePaginas.Next(15, 233);
            int numeros = Capitulo.generadorDeNumeros.Next(1, 65);

            return new Capitulo(numeros, capitulo, paginas);
        }

        public static bool operator ==(Capitulo capituloUno, Capitulo capituloDos)
        {
            if(capituloUno.numero == capituloDos.numero && capituloUno.titulo == capituloDos.titulo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Capitulo capituloUno, Capitulo capituloDos)
        {
            return !(capituloUno == capituloDos);
        }



    }
}
