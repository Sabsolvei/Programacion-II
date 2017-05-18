using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo 
    {                                           
        protected int _cantidadPasajeros;
        protected EVelocidad _velocidadMaxima;

        public Vehiculo(int cantPasajeros, EVelocidad velMax)
        {
            this._cantidadPasajeros = cantPasajeros;
            this._velocidadMaxima = velMax;
        }

        public abstract string Detalle { get; }

        public abstract string Frenar();

        public virtual string Acelerar()
        {
            return ((int)this._velocidadMaxima).ToString();
        }
    }
}
//Metodo o prop abstracto solo dentro de clases abstractas - permite darle estructura a las clases que se deriven. 
//Además, no tienen que tener implementaciones. se cierra con llaves.
//Metodo virtual: los hijos pueden sobrescribir parcial o totalmente el mismo metodo. Pueden modificarlos o no.
//Metodo abstracto: es obligatorio que los hijos lo implementen.