using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : VehiculoTerrestre
    {
        private int _cantRuedas;

        public Auto(int cantPasajeros, EVelocidad velMax, int cantRuedas)
            : base(cantPasajeros, velMax)
        {
            this._cantRuedas = cantRuedas;
        }

        public override string Detalle 
        { 
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("- Cantidad Pasajeros: {0} - Velocidad Maxima: {1}", base._cantidadPasajeros, base.Acelerar());
                sb.AppendFormat("\nCantidad de Ruedas: {0}", this._cantRuedas);

                return sb.ToString();
            } 
        }

        public override string Frenar()
        {
            return "\nEl auto esta frenando";
        }

        public override string Acelerar()
        {
            return "El auto esta acelerando: " + base.Acelerar();
        }

    }
}
