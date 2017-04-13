using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidad
{
    public class Paleta
    {
        private Tempera [] _colores;
        private int _cantidadMaximaColores;
        /*
        private Paleta()
        {
            this._colores = new Tempera[5];
            this._cantidadMaximaColores = _colores.GetLength(0);
        }
        private Paleta(int cantidad)
        {
            this._colores = new Tempera[cantidad];
            this._cantidadMaximaColores = cantidad;
        }
        */
        private Paleta() : this(5)
        {
            
        }
        private Paleta(int cantidad)
        {
            this._colores = new Tempera[cantidad];
            this._cantidadMaximaColores = cantidad;
        }
    }
}
