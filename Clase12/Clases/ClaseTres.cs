using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClaseTres : ClaseDos
    {
        protected string _atributoClaseTres;

        public ClaseTres(string atributoClase1, string atributoClase2, string atributoClase3) : base (atributoClase1, atributoClase2)
        {
            this._atributoClaseTres = atributoClase3;
        }

        public override string Tipo 
        {
            get
            {
                return "Clase tres que hereda de..." + base.Tipo;
            }
        }

        //public string MostrarClaseUnoDosTres()
        //{
        //    return base.MostrarClaseUnoDos() + "\nClase Tres: " + this._atributoClaseTres;
        //}
        public override string Mostrar()
        {
            return "Clase 3: " + this._atributoClaseTres;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
