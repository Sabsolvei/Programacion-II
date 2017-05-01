using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero2016
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        # region CONSTRUCTORES
        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float pAuto, float pCamion, float pMoto)
            : this()
        {
            this._precioAuto = pAuto;
            this._precioCamion = pCamion;
            this._precioMoto = pMoto;
        }
        # endregion CONSTRUCTORES

        # region PROPIEDADES
        public string LavaderoDatos
        {
            get
            {
                StringBuilder datoLavadero = new StringBuilder();
                datoLavadero.AppendLine("Precio auto: " + this._precioAuto.ToString() + "\nPrecio camion: " + this._precioCamion.ToString() + "\nPrecio Moto: " +
                    this._precioMoto.ToString());
                foreach (Vehiculo ve in _vehiculos)
                {
                    if (typeof(Moto) == ve.GetType())
                    {
                        datoLavadero.AppendLine(((Moto)ve).MostrarMoto());
                    }

                    if (typeof(Camion) == ve.GetType())
                    {
                        datoLavadero.AppendLine(((Camion)ve).MostrarCamion());
                    }

                    if (typeof(Auto) == ve.GetType())
                    {
                        datoLavadero.AppendLine(((Auto)ve).MostrarAuto());
                    }
                }
                return datoLavadero.ToString();
            }
        }

        public List<Vehiculo> Vehiculos
        {
            get
            {
                return _vehiculos;
            }
        }
        # endregion PROPIEDADES

        # region MOSTRAR TOTAL FACTURADO
        public double MostrarTotalFacturado()
        {
            double total = 0;
            foreach (Vehiculo ve in _vehiculos)
            {
                if (ve.GetType() == typeof(Moto))
                {
                    total += _precioMoto;
                }

                if (ve.GetType() == typeof(Auto))
                {
                    total += _precioAuto;
                }

                if (ve.GetType() == typeof(Camion))
                {
                    total += _precioCamion;
                }
            }
            return total;
        }
        # endregion MOSTRAR TOTAL FACTURADO

        # region MOSTRAR FACTURADO POR TIPO VEHICULO
        public double MostrarTotalFacturado(Enumeraciones.EVehiculo tipo)
        {
            double valor = 0;
            switch (tipo)
            {
                case Enumeraciones.EVehiculo.Auto:

                    foreach (Vehiculo ve in _vehiculos)
                    {
                        if (ve.GetType() == typeof(Auto))
                        {
                            valor += _precioAuto;
                        }
                    }
                    break;

                case Enumeraciones.EVehiculo.Camion:
                    foreach (Vehiculo ve in _vehiculos)
                    {
                        if (ve.GetType() == typeof(Camion))
                        {
                            valor += _precioCamion;
                        }
                    }
                    break;

                case Enumeraciones.EVehiculo.Moto:
                    foreach (Vehiculo ve in _vehiculos)
                    {
                        if (ve.GetType() == typeof(Moto))
                        {
                            valor += _precioMoto;
                        }
                    }
                    break;
            }
            return valor;
        }
        # endregion MOSTRAR FACTURADO POR TIPO VEHICULO

        # region SOBRECARGA == (VEHICULO DENTRO DE LAVADERO)
        public static bool operator ==(Lavadero lav, Vehiculo vehiculo)
        {
            bool retorno = false;
            if (lav._vehiculos != null)
            {
                foreach (Vehiculo veh in lav._vehiculos)
                {
                    if (vehiculo == veh)
                    {
                        retorno = true;
                    }
                }
            }
            //if (lav._vehiculos.Contains(veh))

            return retorno;
        }
        # endregion SOBRECARGA == (VEHICULO DENTRO DE LAVADERO)

        # region SOBRECARGA != (VEHICULO DENTRO DE LAVADERO)
        public static bool operator !=(Lavadero lav, Vehiculo vehiculo)
        {
            return !(lav == vehiculo);
        }
        # endregion SOBRECARGA != (VEHICULO DENTRO DE LAVADERO)


        # region SOBRECARGA + (AGREGAR VEHICULO AL LAVADERO)
        public static Lavadero operator +(Lavadero lav, Vehiculo vehiculo)
        {
            lav._vehiculos.Add(vehiculo);
            return lav;
        }
        # endregion SOBRECARGA + (AGREGAR VEHICULO AL LAVADERO)

        # region SOBRECARGA - (QUITAR VEHICULO AL LAVADERO)
        /// <summary>
        /// Quitar el vehiculo del lavadero
        /// </summary>
        /// <param name="lav"></param>
        /// <param name="vehiculo"></param>
        /// <returns>Lavadero</returns>
        public static Lavadero operator -(Lavadero lav, Vehiculo vehiculo)
        {
            lav._vehiculos.Remove(vehiculo);
            return lav;
        }

        # endregion SOBRECARGA - (QUITAR VEHICULO AL LAVADERO)

        #region SORT PATENTE
        public static int CompararPatente(Vehiculo vehUno, Vehiculo vehDos)
        {
            int retorno = 0;

            if (string.Compare(vehUno.Patente, vehDos.Patente) > 0) //primera mayor que segunda
                retorno = 1;

            if (string.Compare(vehUno.Patente, vehDos.Patente) < 0) //primera menor que segunda
                retorno = -1;

            return retorno;
        }
        #endregion SORT MARCA

        #region SORT MARCA
        public static int CompararMarca(Vehiculo vehUno, Vehiculo vehDos)
        {
            int retorno = 0;

            if ((string.Compare(vehUno.Marca.ToString(), vehDos.Marca.ToString())) > 0) //primera mayor que segunda
                retorno = 1;

            if ((string.Compare(vehUno.Marca.ToString(), vehDos.Marca.ToString())) < 0) //primera menor que segunda
                retorno = -1;

            return retorno;
        }


        #endregion SORT MARCA

    }
}
