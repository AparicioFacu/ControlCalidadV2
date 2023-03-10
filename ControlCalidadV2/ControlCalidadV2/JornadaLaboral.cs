using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidadV2
{
    public class JornadaLaboral
    {
        public int? Id { get; set; }
        public int? IdOrdenProduccion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? CParPrimera { get; set; }
        public int? CParSegunda { get; set; }
        public Empleado Empleado { get; set; }
        public List<Turno> Turnos { get; set; }
        public List<Registro> Registros { get; set; }

        public string EmpleadoV2  { get; set; }

    }
}
