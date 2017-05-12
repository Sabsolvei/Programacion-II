using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Libro
    {
        protected Autor _autor;
        protected int _cantidadDePaginas;
        protected Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;
        protected HashSet<int> _paginas = new HashSet<int>();
   

        # region CONSTRUCTORES
        public Libro()
        { }

        public Libro(float precio, string titulo, string nombre, string apellido)
            : this()
        {
            this._precio = precio;
            this._titulo = titulo;
            _autor = new Autor(nombre, apellido);
        }


        public Libro(string titulo, Autor autor, float precio, string nombre, string apellido)
            : this(precio, titulo, nombre, apellido)
        {
            this._titulo = titulo;
        }
        # endregion CONSTRUCTORES
   

        # region PROPIEDADES
        public int CantidadDePaginas
        {
            get
            {
                this._generadorDePaginas = new Random();
                int random = _generadorDePaginas.Next(10, 580);
                
                if (this._cantidadDePaginas == 0)
                {
                    while(_paginas.Contains(random))
                    {
                        random = this._generadorDePaginas.Next(10, 580);
                    }

                    this._paginas.Add(random);

                    this._cantidadDePaginas = random;
                }
                return _cantidadDePaginas;
            }
        }
        # endregion PROPIEDADES

        
        private string Mostrar()
        {
            return "Autor: " + this._autor + "Cantidad de paginas:" + this._cantidadDePaginas + "\nPrecio: " + this._precio + "\nTitulo: " + this._titulo;
        }

         # region SOBRECARGA OPERADORES
        public static bool operator ==(Libro libro1, Libro libro2)
        {
            bool retorno = false;
            if (libro1._titulo == libro2._titulo && libro1._autor == libro2._autor)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Libro libro1, Libro libro2)
        {
            return (libro1 == libro2);
        }

         public static explicit operator string (Libro libro)
        {
            return libro.Mostrar();
        }
        # endregion SOBRECARGA OPERADORES
    }

}


