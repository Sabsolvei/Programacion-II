using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Vehiculos_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Comercial avionComercial = new Comercial(5000, 1400, 100);
            Privado avionPrivado = new Privado(50000, 800, 10);
            Familiar autoFamiliar = new Familiar(200000, "123AB456", 5);
            Deportivo autoDeportivo = new Deportivo(500000, "AB123CD", 2);
            Carreta carreta = new Carreta(5000);

            List<IAFIP> listaAfip = new List<IAFIP>();
            List<IArba> listaArba = new List<IArba>();

            listaAfip.Add(avionComercial);
            listaAfip.Add(avionPrivado);
            listaAfip.Add(autoDeportivo);

            listaArba.Add(avionComercial);
            listaArba.Add(carreta);
            listaArba.Add(autoDeportivo);

            //foreach (IAFIP v in listaAfip)
            //{
            //    Console.WriteLine("Impuesto Nacional: " + Gestion.MostrarImpuestoNacional(v));
            //}

            //Console.WriteLine("\n");

            //foreach (IArba v in listaArba)
            //{
            //    Console.WriteLine("Impuesto Provincial: " + Gestion.MostrarImpuestoProvincial(v));
            //}


            foreach (IAFIP v in listaAfip)
            {
                Console.WriteLine("Impuesto Nacional: " + v.MostrarImpuestoNacional());
            }

            Console.WriteLine("\n");

            foreach (IArba v in listaArba)
            {
                Console.WriteLine("Impuesto Provincial: " + v.MostrarImpuestoProvincial());
            }
            
          


            Console.WriteLine("\nMostrar Impuesto Afip y Arba:");
            Console.WriteLine("\nAFIP: " + ((IAFIP)avionComercial).CalcularImpuesto());
            Console.WriteLine("\nARBA: " + ((IArba)avionComercial).CalcularImpuesto());


            //Console.WriteLine("Impuesto avion comercial: " + Gestion.MostrarImpuestoNacional(avionComercial));
            //Console.WriteLine("Impuesto avion privado: " + Gestion.MostrarImpuestoNacional(avionPrivado));
            //Console.WriteLine("Impuesto auto deportivo: " + Gestion.MostrarImpuestoNacional(autoDeportivo));
            Console.WriteLine("\n");
            avionComercial.MostrarPrecio();
            avionPrivado.MostrarPrecio();
            autoFamiliar.MostrarPrecio();
            autoDeportivo.MostrarPrecio();



            Console.ReadKey();
        }
    }
}
