using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercial : Avion, IArba
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros)
            : base (precio, velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }

        double IArba.CalcularImpuesto()
        {
            double impuesto = 0;
            impuesto = base._precio * 25 / 100;
            return impuesto;
        }

    }
}
