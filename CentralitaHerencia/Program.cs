using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita listaLlamadas = new Centralita("Telefonica");
            Local ll1 = new Local("BS01", "BS12", 30, 2.65f);
            Provincial ll2 = new Provincial("BS01", Franja.Franja_1, 21, "BS04");
            Local ll3 = new Local("BS01", "BS12", 45, 1.99f);
            Provincial ll4 = new Provincial(ll1.NroOrigen, Franja.Franja_3, ll1.Duracion, ll1.NroDestino);
        }
    }
}
