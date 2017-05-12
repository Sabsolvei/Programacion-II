using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Manual : Libro
    {
        protected ETipo _tipo;

        # region CONSTRUCTORES
        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo)
            : base(precio, titulo, nombre, apellido)
        {
            this._tipo = tipo;
        }
        # endregion CONSTRUCTORES
        

        # region MOSTRAR
        public string Mostrar()
        {
            string datosManual;
            datosManual = ((Libro)this).ToString() + "\nTipo: " + this._tipo;

            return datosManual;
        }
        # endregion MOSTRAR
       

        #region SOBRECARGA OPERADORES
        public static bool operator ==(Manual m1, Manual m2)
        {
            bool retorno = false;
            if (((Libro)m1) == ((Libro)m2))
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Manual m1, Manual m2)
        {
            return !(m1 == m2);
        }
        

        public static implicit operator float(Manual manual)
        {
            return manual._precio;
        }
        #endregion SOBRECARGA OPERADORES
    }
}
