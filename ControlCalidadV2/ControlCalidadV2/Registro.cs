using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidadV2
{
    public class Registro
    {
        public int? Id { get; set; }
        public int? IdJornadaLaboral { get; set; }
        public DateTime? Hora { get; set; }
        public TipoPie TipoPie { get; set; }
        public Defecto Defecto { get; set; }
    }
}
