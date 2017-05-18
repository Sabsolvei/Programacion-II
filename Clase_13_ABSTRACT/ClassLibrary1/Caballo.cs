using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : VehiculoTerrestre
    {
        private string _raza;

        public Caballo(string raza, EVelocidad velMax, int cantPasajeros)
            : base(cantPasajeros, velMax)
        {
            this._raza = raza;
        }

        public override string Detalle 
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("- Cantidad Pasajeros: {0} - Velocidad Maxima: {1}", base._cantidadPasajeros, base.Acelerar());
                sb.AppendFormat("\nRaza: {0}", this._raza);

                return sb.ToString(); 
            }
        }

        public override string Frenar()
        {
            return "\nEl Caballo esta frenando";
        }

        public override string Acelerar()
        {
            return "El Caballo esta acelerando: " + base.Acelerar();
        }
    }
}
