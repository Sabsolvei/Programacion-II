using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        #region CONSTRUCTORES
        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
            //this._listaDeLlamadas.Capacity = 5;
        }

        public Centralita(string razonSocial) 
            : this()
        {
            this._razonSocial = razonSocial;
        }
        #endregion

        #region PROPIEDADES
        public float GananciaPorLocal 
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial 
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
            
        }

        public float GananciaTotal 
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> ListaDeLlamadas 
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }
        #endregion

        #region METODOS
        private float CalcularGanancia(TipoLlamada tipo)
        {
                float cost = 0;
                foreach (Llamada llamada in this._listaDeLlamadas)
                {
                    switch (tipo)
                    {
                        case TipoLlamada.Local:
                            if (llamada is Local)
                            {
                                cost += llamada.CostoLlamada;
                            }
                            break;
                        case TipoLlamada.Provincial:
                            if (llamada is Provincial)
                            {
                                cost += llamada.CostoLlamada;
                            }
                            break;
                        default:
                            cost += llamada.CostoLlamada;
                            break;
                    }  
                }
                return cost;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Empresa: ¨{0}", this._razonSocial);
            sb.AppendFormat("Ganancia Total: {0}\nGanancia Local: {1}\nGanancia Provincial: {3}", this.GananciaTotal, this.GananciaPorLocal, this.GananciaPorProvincial);
            foreach (Llamada llamada in ListaDeLlamadas)
            {
                sb.AppendLine(llamada.Mostrar());
            }
            return sb.ToString();
        }
        #endregion

    }
}
