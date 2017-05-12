using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Test_Clase12
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseUno clase1 = new ClaseUno("Hola");
            ClaseDos clase2 = new ClaseDos("Como","Estas");
            ClaseTres clase3 = new ClaseTres("Juancito", "Pepito", "Pedrito");
            //Console.WriteLine(clase1.MostrarClaseUno());
            //Console.WriteLine(clase3.TipoClaseTres);
            //Console.WriteLine(clase2.MostrarClaseUnoDos());
            //Console.WriteLine(clase3.MostrarClaseUnoDosTres());
            //Console.ReadKey();

            List<ClaseUno> listaClases = new List<ClaseUno>();
            listaClases.Add(clase1);
            listaClases.Add(clase2);
            listaClases.Add(clase3);

            foreach (ClaseUno clase_1 in listaClases)
            {
                Console.WriteLine(clase_1.Tipo);
                Console.WriteLine(clase_1);//se puede poner clase_1.ToString() o solo clase_1 ya que por default invoca al ToString() del object que reciba.
                Console.ReadKey();
                //if (clase_1 is ClaseTres)
                //{
                //    Console.WriteLine(((ClaseTres)clase_1).MostrarClaseUnoDosTres());
                //    Console.ReadKey();
                //}
                //
                //else if (clase_1 is ClaseDos)
                //{
                //    Console.WriteLine(((ClaseDos)clase_1).MostrarClaseUnoDos());
                //    Console.ReadKey();
                //}
                //
                //else if (clase_1 is ClaseUno)
                //{
                //    Console.WriteLine(clase_1.MostrarClaseUno());
                //    Console.ReadKey();
                //}
            }

        }
    }
}
