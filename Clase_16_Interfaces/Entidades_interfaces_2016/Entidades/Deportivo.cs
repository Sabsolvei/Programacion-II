using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP, IArba
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp)
            :base (precio, patente)
        {
            this._caballosFuerza = hp;
        }

        public double CalcularImpuesto()
        {
            //33 avion 28 deportivo
            double impuesto = 0;
            impuesto = base._precio * 28 / 100;
            return impuesto;
        }
        double IArba.CalcularImpuesto()
        {
            double impuesto = 0;
            impuesto = base._precio * 23 / 100;
            return impuesto;
        }
        //carreta 18 // deportivo 23 // comercial 25

        public override void MostrarPatente()
        {
            Console.WriteLine("Patente: " + base._patente);
        }

        

    }
}
