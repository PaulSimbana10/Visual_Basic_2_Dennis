using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Configuracion
    {
        public int ConfiguracionID { get; set; }
        public TiposPago TiposPago { get; set; }
        public int TipoID { get; set; }
        public Estados Estados { get; set; }
        public int EstadoID { get; set; }
    }
}
