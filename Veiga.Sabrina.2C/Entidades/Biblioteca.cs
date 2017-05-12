using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales 
        { 
            get
            {                
               return 
            }     
        }

        public double PrecioDeNovelas 
        { 
            get
            {                
               return 
            }     
        }

        public double PrecioTotal 
        { 
            get
            {                
               return 
            }     
        }

        private Biblioteca() 
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        #region MOSTRAR
        public static string Mostrar(Biblioteca biblioteca)
        {
            StringBuilder datoLavadero = new StringBuilder();
           
            foreach (Libro libro in biblioteca._libros)
            {
                if (libro is Manual)
                {
                    datoLavadero.AppendLine(((Manual)libro).Mostrar());
                }

                if (libro is Novela)
                {
                    datoLavadero.AppendLine(((Novela)libro).Mostrar());
                }
            }
            return datoLavadero.ToString();
        }
        #endregion MOSTRAR

        #region SOBRECARGA OPERADORES
        public static bool operator ==(Biblioteca biblio, Libro libro1)
        {
            bool retorno = false;
            if (biblio._libros != null)
            {
                foreach (Libro libro2 in biblio._libros)
                {
                    if (libro1 == libro2)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Biblioteca biblio, Libro libro1)
        {
            return !(biblio == libro1);
        }

        public static Biblioteca operator +(Biblioteca biblio, Libro libro1)
        {
            if ((biblio._capacidad <= 580) && !(biblio == libro1))
            {
                biblio._libros.Add(libro1);
            }
            else 
            {
                Console.WriteLine(Biblioteca.Mostrar(biblio));
            }
            return biblio;
        }
        private double ObtenerPrecio(ELibro tipoLibro)
        {

            return precioTotal;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca biblioteca = new Biblioteca(capacidad);
            
            return biblioteca;
        }
        #endregion SOBRECARGA OPERADORES



    }
}
