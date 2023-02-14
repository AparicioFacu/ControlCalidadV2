using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVistaModelo
{
    public class RegistroVM
    {
        public int? Id { get; set; }
        public DateTime? Hora { get; set; }
        public TipoPieVM TipoPie { get; set; }
        public DefectoVM Defecto { get; set; }
        public int? IdJornadaLaboral { get; set; }
    }
}
