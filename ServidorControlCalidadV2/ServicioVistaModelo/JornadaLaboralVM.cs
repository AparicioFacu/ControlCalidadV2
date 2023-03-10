using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVistaModelo
{
    public class JornadaLaboralVM
    {
        public int? Id { get; set; }
        public int? IdOrdenProduccion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? CParPrimera { get; set; }
        public int? CParSegunda { get; set; }
        public EmpleadoVM Empleado { get; set; }
        public List<TurnoVM> Turnos { get; set; }
        public List<RegistroVM> Registros { get; set; }

        public string EmpleadoV2 { get; set; }
    }

}
