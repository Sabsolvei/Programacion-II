using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion:Vehiculo, IAFIP, IArba
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax)
            :base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public double CalcularImpuesto()
        {
            //33 avion 28 deportivo
            double impuesto = 0;
            impuesto = base._precio * 33 / 100;
            return impuesto;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio Avion: " + base._precio);
        }

    }
}
