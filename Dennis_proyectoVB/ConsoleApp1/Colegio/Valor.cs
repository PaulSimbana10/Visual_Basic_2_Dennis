using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Colegio
{
    public class Valor 
    {

        public int ValorId { get; set; }
        public int PagoDetId { get; set; }
        public PagoDet PagoDet { get; set; }
        public double valorApagar { get; set; }
        public double valorayuda { get; set; }
        public double valorpagado { get; set; }
        public double valorpendiente { get; set; }

    }
}
