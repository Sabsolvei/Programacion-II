using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class VehiculoTerrestre : Vehiculo
    {
        public VehiculoTerrestre(int cantPasajeros, EVelocidad velMax)
            : base(cantPasajeros, velMax)
        {

        }
    }
}
