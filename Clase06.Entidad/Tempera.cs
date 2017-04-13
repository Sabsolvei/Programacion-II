using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.Entidad
{
    public class Tempera
    {
        //Atributos
        private ConsoleColor _color;
        private string _marca;
        private int _cantidad;

        //Constructor con 3 parametros
        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this._cantidad = cantidad;
            this._marca = marca;
            this._color = color;
        }
        //Metodo Instancia
        private string Mostrar()
        {
            return this._cantidad.ToString() + this._color.ToString() + this._marca;
        }
        //Metodo Clase (Static)
        public static string Mostrar(Tempera objTempera)
        {
            return objTempera._marca + objTempera._color.ToString() + objTempera._cantidad.ToString();
        }

        //sobrecarga
        public static Boolean operator ==(Tempera t1, Tempera t2)
        {
            if ((t1._marca == t2._marca) & (t1._color == t2._color))
                return true;
            else
                return false;
        }

        public static Boolean operator ==(Tempera t1, Tempera t2)
        {
            if ((t1._marca == t2._marca) & (t1._color == t2._color))
                return true;
            else
                return false;
        }

        public static Boolean operator !=(Tempera te1, Tempera te2)
        {
           return !(te1 == te2);
        }

        public static implicit operator int (Tempera t)
        {
            return t._cantidad;
        }

        public static explicit operator string(Tempera t)
        {
            return t.Mostrar();
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if (t1 == t2)
            {
                t1._cantidad = t1 + t2._cantidad;
                //t1._cantidad = t1.cantidad + t2.cantidad 
            }
                return t1;
        }

        public static Tempera operator +(Tempera t1, int cantidad)
        {
            t1._cantidad = t1._cantidad + cantidad;
            return t1;
        }

    }
}
