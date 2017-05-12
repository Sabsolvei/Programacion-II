using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Novela : Libro
    {
        protected EGenero _EGenero;

        # region CONSTRUCTORES
        public Novela(string titulo, float precio, Autor autor, EGenero genero)
            : base()
        {
            this._EGenero = genero;
        }
        # endregion CONSTRUCTORES

        # region MOSTRAR
        public string Mostrar()
        {
            string datosNovela = ((Libro)this).ToString() + "\nGenero: " + this._EGenero;

            return datosNovela;
        }
        # endregion MOSTRAR

        #region SOBRECARGA OPERADORES
        public static bool operator ==(Novela n1, Novela n2)
        {
            bool retorno = false;
            if (((Libro)n1) == ((Libro)n2))
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Novela n1, Novela n2)
        {
            return !(n1 == n2);
        }


        public static implicit operator float(Novela novela)
        {
            return novela._precio;
        }
        #endregion SOBRECARGA OPERADORES
    }
}
