using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personas;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace Clase_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Persona personita = new Persona("Tomas", "Perez", 30, ESexo.Masculino);
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nEdad: {2}\nSexo: {3}\n", personita.Nombre, personita.Apellido, personita.Edad, personita.Sexo);
            Console.WriteLine("--------------------------------------------------------------------------------");
            
            personita.ObtenerInfo();
            
            Console.WriteLine("--------------------------------------------------------------------------------");
            Entidades.Externa.Sellada.PersonaExternaSellada pExS = new Entidades.Externa.Sellada.PersonaExternaSellada("Tomas", "Perez", 30, Entidades.Externa.Sellada.ESexo.Femenino);
            pExS.ObtenerInfo();
            Console.WriteLine("--------------------------------------------------------------------------------");
            
            string hola = "hola";
            Console.WriteLine("Cantidad de letras de la palabra 'Hola' = {0}\n", hola.Cantidad());
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadKey();


            


        }
    }
}
