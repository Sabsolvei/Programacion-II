using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero2016
{
    class Auto : Vehiculo
    {
        protected int _cantidadAsientos;
        protected float _tara;
        protected float _cilindrada;

        public Auto(int cantAsientos, float tara, float cilindrada, string patente, byte cantRuedas, Enumeraciones.EMarca marca)
            : base(patente, cantRuedas, marca)
        {
            this._cantidadAsientos = cantAsientos;
            this._tara = tara;
            this._cilindrada = cilindrada;
        }

        public string MostrarAuto()
        {
            return "\nAUTO: " + base.Mostrar() + "\nCantidad Asientos: " + this._cantidadAsientos.ToString() + "\nTara: " + this._tara.ToString() + "\nCilindrada: " + this._cilindrada.ToString();
        }

    }
}
