using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero2016
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected Enumeraciones.EMarca _marca;

        #region PROPIEDADES
        public string Patente
        {
            get { return _patente; }
        }

        public Enumeraciones.EMarca Marca
        {
            get { return _marca; }
        }
        #endregion PROPIEDADES

        #region CONSTRUCTORES
        public Vehiculo(string patente, byte cantRuedas, Enumeraciones.EMarca marca)
        {
            this._patente = patente;
            this._cantRuedas = cantRuedas;
            this._marca = marca;
        }
        #endregion CONSTRUCTORES

        #region MOSTRAR
        internal string Mostrar()
        {
            return "\nMarca: " + this._marca + "\nCantidad de ruedas: " + this._cantRuedas + "\nPatente: " + this._patente;
        }
        #endregion MOSTRAR

        #region COMPARAR VEHICULOS
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;
            if (v1._marca == v2._marca && v1._patente == v2._patente)
                retorno = true;
            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion COMPARAR VEHICULOS
    }
}
