﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidadV2
{
    public class Defecto
    {
        public int? Id { get; set; }
        public string Descripcion { get; set; }
        public TipoDefecto TipoDefecto { get; set; }
    }
}
