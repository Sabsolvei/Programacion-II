﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._edad = edad;
            this._sexo = sexo;
        }

        public string Nombre 
        {
            get
            {
                return this._nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
        }

        public int Edad
        {
            get
            {
                return this._edad;
            }
        }

        public ESexo Sexo
        {
            get
            {
                return this._sexo;
            }
        }

        public void ObtenerInfo()
        {
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nEdad: {2}\nSexo: {3}\n", this.Nombre, this.Apellido, this.Edad, this.Sexo);
        }




    }
}
