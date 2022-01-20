using Modelo.Colegio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Periodo 
    {

        public int PeriodoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<Ciclo> Ciclos { get; set; }
        public List<Pago> Pagos { get; set; }
    }
}
