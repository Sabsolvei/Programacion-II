using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ClaseDos : ClaseUno
    {
        protected string _atributoClaseDos;

        public ClaseDos(string atributoClase1, string atributoClase2) : base (atributoClase1)
        {
            this._atributoClaseDos = atributoClase2;
        }

        public override string Tipo
        {
            get
            {
                return " clase dos que hereda de..." + base.Tipo;
            }
        }
        
        //public string MostrarClaseUnoDos()
        //{
        //    return "Clase uno: " + base.MostrarClaseUno() + "\nClase dos: " + this._atributoClaseDos;
        //}
        public override string Mostrar()
        {
            base.Mostrar();
            return "Clase 2: " + this._atributoClaseDos;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
