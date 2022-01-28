﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
     public class Estados
    {
        public int EstadosID { get; set; }
        public string NombreEstado { get; set; }
        public string Descripcion { get; set; }

        public List<Configuracion> configuraciones { get; set; }
        public List<Pagos> pagos { get; set; }
        public Penalizacion penalizacion { get; set; }
    }
}
