using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Autor
    {

        private string _nombre;
        private string _apellido;

        # region CONSTRUCTORES
        public Autor(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }
        # endregion CONSTRUCTORES

        # region SOBRECARGA OPERADORES
        public static bool operator ==(Autor au1, Autor au2)
        {
            bool retorno = false;
            if (au1._nombre == au2._nombre && au1._apellido == au2._apellido)
                retorno = true;

            return retorno;
        }

       

        public static bool operator !=(Autor au1, Autor au2)
        {
            return !(au1 == au2);
        }

        public static implicit operator string(Autor au1)
        {
            return "Apellido: " + au1._apellido + "\nNombre: " + au1._nombre;
        }
        # endregion SOBRECARGA OPERADORES


    }
}
