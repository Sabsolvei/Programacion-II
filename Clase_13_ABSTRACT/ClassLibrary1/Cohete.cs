using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cohete : Vehiculo
    {
        private string _modelo;
        private int _cantidadVentanas;

        public Cohete(string modelo, int cantVentanas, EVelocidad velMax, int cantPasajeros)
            : base(cantPasajeros, velMax)
        {
            this._modelo = modelo;
            this._cantidadVentanas = cantVentanas;
        }

        public override string Detalle 
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("- Cantidad Pasajeros: {0} - Velocidad Maxima: {1}", base._cantidadPasajeros, base.Acelerar());
                sb.AppendFormat("\nCantidad de Ventanas: {0}- Modelo: {1}", 
                    this._cantidadVentanas, this._modelo);

                return sb.ToString(); 
            }
        }

        public override string Frenar()
        {
            return "\nEl cohete esta frenando";
        }

        public override string Acelerar()
        {
            return "El cohete esta acelerando: " + base.Acelerar();
        }        
    }
}
