using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        private Franja _franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public override float CostoLlamada 
        { 
            get
            {
                return this.CalcularCosto;
            }
        }

        private float CalcularCosto 
        {
            get
            {
                float costo;
                switch (this._franjaHoraria)
                {
                    case Franja.Franja_1:
                        costo = (float)(base._duracion * 0.99);
                        break;
                    case Franja.Franja_2:
                        costo = (float)(base._duracion * 1.25);
                        break;
                    case Franja.Franja_3:
                        costo = (float)(base._duracion * 0.66);
                        break;
                    default:
                        costo = 0;
                        break;
                }
                return costo;
            }
        }


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("\nFranja horaria: " + this._franjaHoraria);
            sb.AppendLine("\nCosto de llamada: " + this.CostoLlamada);

            return sb.ToString();
        }
        
    }
}
