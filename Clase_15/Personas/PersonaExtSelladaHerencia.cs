using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace Personas
{
    //En esta clase spodemos generar los MÉTODOS DE EXTENSIÓN que querramos para poder crear metodos que se encuentren en otras clases.
    //Metodos de Extension: Deben estar en una clase estatica. Sirve solo de contenedora de metodos de clase y publicos.
    public static class PersonaExtSelladaHerencia
    {
        public static void ObtenerInfo(this PersonaExternaSellada p) //asocia este metodo como un metodo de instancia de ese tipo de dato
                                                                     //El this significa que es una instancia del objeto que indico
        {
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nEdad: {2}\nSexo: {3}\n", p.Nombre, p.Apellido, p.Edad, p.Sexo);
        }

        public static int Cantidad(this string s)
        {
            return s.Length;
        }

    }
}
