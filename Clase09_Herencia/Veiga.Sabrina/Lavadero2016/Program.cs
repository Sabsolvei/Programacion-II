using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero2016
{
    class Program
    {
        //La aplicación debe poder ingresar vehículos de distintos tipos y marcas al lavadero, quitarlos,
        //obtener las ganancias totales o por tipo de vehículo y mostrar los vehículos ingresados al lavadero
        //ordenado por los distintos criterios.

        #region RETIRAR VEHICULO
        static Vehiculo RetirarVehiculo()
        {
            Vehiculo vehiculo;
            string patente;
            Enumeraciones.EMarca marca;
            bool verifica = false;

            Console.WriteLine("Patente: ");
            patente = Console.ReadLine();

            do
            {
                Console.WriteLine("1. Honda | 2. Ford | 3. Zanella | 4. Scania | 5. Iveco | 6. Fiat");
                Console.WriteLine("Ingrese Marca: ");
                verifica = Enumeraciones.EMarca.TryParse(Console.ReadLine(), out marca);
            } while (verifica == false);

            vehiculo = new Vehiculo(patente, 1, marca);

            return vehiculo;
        }
        #endregion RETIRAR VEHICULO

        #region PEDIR DATOS VEHICULO
        static Vehiculo PedirDatos(Enumeraciones.EVehiculo tipo)
        {
            Vehiculo vehiculo;
            int cantAsientos;
            float tara;
            float cilindrada;
            string patente;
            byte cantRuedas;
            Enumeraciones.EMarca marca;
            bool verifica = false;
            do
            {
                Console.WriteLine("Cantidad asientos: ");
                verifica = int.TryParse(Console.ReadLine(), out cantAsientos);
            } while (verifica == false);

            do
            {
                Console.WriteLine("Tara: ");
                verifica = float.TryParse(Console.ReadLine(), out tara);
            } while (verifica == false);

            do
            {
                Console.WriteLine("Cilindrada: ");
                verifica = float.TryParse(Console.ReadLine(), out cilindrada);
            } while (verifica == false);


            Console.WriteLine("Patente: ");
            patente = Console.ReadLine();

            do
            {
                Console.WriteLine("Cantidad de Ruedas: ");
                verifica = byte.TryParse(Console.ReadLine(), out cantRuedas);
            } while (verifica == false);

            do
            {
                Console.WriteLine("1. Honda | 2. Ford | 3. Zanella | 4. Scania | 5. Iveco | 6. Fiat");
                Console.WriteLine("Ingrese Marca: ");
                verifica = Enumeraciones.EMarca.TryParse(Console.ReadLine(), out marca);
            } while (verifica == false);

            switch (tipo)
            {
                case Enumeraciones.EVehiculo.Auto:
                    vehiculo = new Auto(cantAsientos, tara, cilindrada, patente, cantRuedas, marca);
                    break;

                case Enumeraciones.EVehiculo.Camion:
                    vehiculo = new Camion(cantAsientos, tara, cilindrada, patente, cantRuedas, marca);
                    break;

                case Enumeraciones.EVehiculo.Moto:
                    vehiculo = new Moto(cantAsientos, tara, cilindrada, patente, cantRuedas, marca);
                    break;

                default:
                    vehiculo = new Auto(cantAsientos, tara, cilindrada, patente, cantRuedas, marca);
                    break;
            }
            return vehiculo;
        }
        #endregion PEDIR DATOS VEHICULO

        static Lavadero OrdenarLista(Lavadero lavadero)
        {
            Vehiculo aux;
            for (int i = 0; i < (lavadero.Vehiculos.Count) - 1; i++)
            {
                for (int j = i + 1; (j < lavadero.Vehiculos.Count); j++)
                {
                    if ((Lavadero.CompararMarca(lavadero.Vehiculos[i], lavadero.Vehiculos[j]) == 1))
                    {
                        aux = lavadero.Vehiculos[i];
                        lavadero.Vehiculos[i] = lavadero.Vehiculos[j];
                        lavadero.Vehiculos[j] = aux;
                    }
                    else if ((Lavadero.CompararMarca(lavadero.Vehiculos[i], lavadero.Vehiculos[j]) == 0))
                    {
                        if ((Lavadero.CompararPatente(lavadero.Vehiculos[i], lavadero.Vehiculos[j]) == 1))
                        {
                            aux = lavadero.Vehiculos[i];
                            lavadero.Vehiculos[i] = lavadero.Vehiculos[j];
                            lavadero.Vehiculos[j] = aux;
                        }
                    }
                }
            }
            return lavadero;
        }

        static void Main(string[] args)
        {
            
            Enumeraciones.EVehiculo tipo;
            bool continuar = true;
            int option = 0;
            Lavadero lavadero = new Lavadero(10000, 20000, 5000);

            #region HARDCODEO
            Auto auto1 = new Auto(5, 3, 2, "ABC123", 4, Enumeraciones.EMarca.Fiat);
            Auto auto2 = new Auto(5, 2, 3, "REW456", 4, Enumeraciones.EMarca.Ford);
            Auto auto3 = new Auto(5, 2, 3, "TRE654", 4, Enumeraciones.EMarca.Fiat);
            Moto moto1 = new Moto(1, 3, 4, "FDS654", 2, Enumeraciones.EMarca.Honda);
            Moto moto2 = new Moto(1, 2, 4, "GFD753", 2, Enumeraciones.EMarca.Zanella);
            Moto moto3 = new Moto(1, 2, 3, "UIO098", 2, Enumeraciones.EMarca.Honda);
            Camion camion1 = new Camion(3, 5, 6, "TRE456", 8, Enumeraciones.EMarca.Honda);
            Camion camion2 = new Camion(3, 5, 5, "TRE456", 12, Enumeraciones.EMarca.Iveco);
            Camion camion3 = new Camion(3, 5, 6, "TRE456", 8, Enumeraciones.EMarca.Scania);

            lavadero = lavadero + auto1;
            lavadero = lavadero + auto2;
            lavadero = lavadero + auto3;
            lavadero = lavadero + moto1;
            lavadero = lavadero + moto2;
            lavadero = lavadero + moto3;
            lavadero = lavadero + camion1;
            lavadero = lavadero + camion2;
            lavadero = lavadero + camion3;
            #endregion HARDCODEO

            do
            {
                Console.WriteLine("****************************");
                // Menú
                Console.WriteLine("1 - Ingresar vehiculo");
                Console.WriteLine("2 - Retirar vehiculo");
                Console.WriteLine("3 - Ver ganancias totales");
                Console.WriteLine("4 - Ver ganancias por tipo de vehiculo");
                Console.WriteLine("5 - Ver vehiculos ingresados al lavadero");
                Console.WriteLine("0 - Salir");
                Console.Write("\nIngrese una opcion: ");

                if (!(int.TryParse(Console.ReadLine(), out option)))
                    continue;

                switch (option)
                {
                    case 1:
                        Console.Write("\n1. Auto.\n2. Moto.\n3. Camion.\nInresar tipo de vehiculo: ");
                        if (!(Enumeraciones.EVehiculo.TryParse(Console.ReadLine(), out tipo)))
                            continue;
                        Vehiculo vehiculo = PedirDatos(tipo);

                        if (!(lavadero == vehiculo))
                        {
                            lavadero = lavadero + vehiculo;
                        }
                        else
                        {
                            Console.WriteLine("El auto ya se encuentra ingresado");
                            Console.ReadLine();
                        }
                        break;

                    case 2:
                        vehiculo = RetirarVehiculo();

                        if (lavadero == vehiculo)
                        {
                            lavadero = lavadero - vehiculo;
                        }

                        else
                        {
                            Console.WriteLine("El auto ya fue retirado o nunca se ingresó.");
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("Total facturado: " + lavadero.MostrarTotalFacturado());
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Ingrese tipo de vehiculo: ");
                        if (!(Enumeraciones.EVehiculo.TryParse(Console.ReadLine(), out tipo)))
                            continue;
                        Console.WriteLine(lavadero.MostrarTotalFacturado(tipo));
                        Console.ReadKey();
                        break;
                    case 5:
                        lavadero = OrdenarLista(lavadero);
                        Console.WriteLine(lavadero.LavaderoDatos);
                        Console.ReadKey();
                        break;

                    case 0:
                        continuar = false;
                        break;
                }
                Console.Clear();
            } while (continuar);

        }
    }
}
