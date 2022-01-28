﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Estudiante
    {
        public int EstudianteID { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public List<Pagos> Pagos { get; set; }
    }
}
