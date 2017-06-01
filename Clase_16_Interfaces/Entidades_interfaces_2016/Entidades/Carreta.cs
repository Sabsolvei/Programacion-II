using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carreta: Vehiculo, IArba
    {
        public Carreta(double precio)
            : base(precio)
        { }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + base._precio);
        }


        double IArba.CalcularImpuesto()
        {
            //carreta 18 // deportivo 23 // comercial 25
            double impuesto = 0;
            impuesto = base._precio * 18 / 100;
            return impuesto;
        }
        

    }
}
