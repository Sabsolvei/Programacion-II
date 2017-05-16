﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }

        protected Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nro Origen: "+this.NroOrigen);
            sb.Append("Nro Destino: " + this.NroDestino);
            sb.Append("Duración: " + this.Duracion);

            return sb.ToString();
           
        }

        static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return 5;
        }
    }
}