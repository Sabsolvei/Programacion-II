using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Clase_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto(5, EVelocidad.Alta, 4);
            Cohete cohete1 = new Cohete("Lumia5", 2, EVelocidad.Hiper, 1);
            Caballo caballo1 = new Caballo("Coker", EVelocidad.Media, 1);

            //Vehiculo vehiculo = new Vehiculo(10, EVelocidad.Hiper);

            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            listaVehiculos.Add(auto1);
            listaVehiculos.Add(cohete1);
            listaVehiculos.Add(caballo1);
            //listaVehiculos.Add(vehiculo);

            foreach (Vehiculo veh in listaVehiculos)
            {
                if (veh is Auto)
                {
                    Console.WriteLine("AUTO ");
                    //Console.WriteLine("AUTO " + ((Auto)veh).Detalle);
                }
                if (veh is Cohete)
                {
                    Console.WriteLine("COHETE ");
                    //Console.WriteLine("COHETE " + ((Cohete)veh).Detalle);
                }
                if (veh is Caballo)
                {
                    Console.WriteLine("CABALLO ");
                    //Console.WriteLine("CABALLO " + ((Caballo)veh).Detalle);
                }
                Console.WriteLine(veh.Detalle);
                //else 
                //{
                //    Console.WriteLine("VEHICULO " + veh.Detalle);
       
                //}
                Console.ReadLine();
            }
            
            //Console.WriteLine(auto1.Detalle);
            //Console.ReadLine();
            //Console.WriteLine(cohete1.Detalle);
            //Console.ReadLine();
            //Console.WriteLine(caballo1.Detalle);
            //Console.ReadLine();




        }
    }
}
