using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVistaModelo
{
    public class TurnoVM
    {
        public int? Id { get; set; }
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFin { get; set; }
        public String Descripcion { get; set; }
        public int? IdJornadaLaboral { get; set; }
    }
}
