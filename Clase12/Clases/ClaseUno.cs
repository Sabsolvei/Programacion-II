using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClaseUno
    {
        protected string _atributoClaseUno;

        public ClaseUno(string atrib)
        {
            this._atributoClaseUno = atrib;
        }

        public virtual string Tipo 
        {
            get
            {
                return "Clase Uno: ";
            }  
        }

        //public string MostrarClaseUno ()
        //{
        //    return this._atributoClaseUno;
        //}
        public virtual string Mostrar()
        {
            return "Clase1: " +this._atributoClaseUno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
