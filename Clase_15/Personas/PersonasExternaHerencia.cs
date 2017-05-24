using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace Personas
{
    public class PersonasExternaHerencia : PersonaExterna
    {
        public PersonasExternaHerencia(string nombre, string apellido, int edad, Entidades.Externa.ESexo sexo) : base(nombre, apellido, edad, sexo)
        {
            base._apellido = apellido;
            base._nombre = nombre;
            base._edad = edad;
            base._sexo = sexo;
        }        

        public string Nombre 
        {
            get
            {
                return base._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return base._apellido;
            }
        }

        public int Edad
        {
            get
            {
                return base._edad;
            }
        }

        public Entidades.Externa.ESexo Sexo
        {
            get
            {
                return base._sexo;
            }
        }

        public void ObtenerInfo()
        {
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nEdad: {2}\nSexo: {3}\n", this.Nombre, this.Apellido, this.Edad, this.Sexo);
        }
    }
}
