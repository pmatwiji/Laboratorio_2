using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_08.Entidades
{
    public class Libro
    {
        private string Titulo;

        public string MiTitulo
        {
            get { return Titulo; }
        }

        private string Autor;

        public string MiAutor
        {
            get { return Autor; }
        }

        private List<Capitulo> ListCapitulos;// = new List<Capitulo>();

        public Libro(string titulo,string autor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.ListCapitulos = new List<Capitulo>();
        }




        //Prop s/l CantidadPaginas : int sumar paginas de capitulos

        

        public int CantidadDePaginas
        {
            get
            {
                int total = 0;
                foreach (Capitulo capitulos in ListCapitulos)
                {
                    total += capitulos.MisPaginas;
                }

                return total;
            }
        }

        public int CantidadDeCapitulos
        {
            get
            {
                int total = 0;
                foreach (Capitulo capitulos in ListCapitulos)
                {
                    total ++;
                }

                return total;
            }
        }
        //Indexador de libro

        public Capitulo this[int i]
        {
            get
            {
                if(this.ListCapitulos[i] != null)
                {
                    return this.ListCapitulos[i];
                }
                else
                {
                    return null;
                }
            }
            set { }
        }

        //get si indice excede rango, retorna null
        //get si es valido, retorno capitulo en ese indice

        //set si indice supera rango+1, se agrega como nuevo capitulo
        //indice inferior a 0 no se puede xxxx
        //indice entre 0 y max.indice, reemplazo en ese indice
    }
}
