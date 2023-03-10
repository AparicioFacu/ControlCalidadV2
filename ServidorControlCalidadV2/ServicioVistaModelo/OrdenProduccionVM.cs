using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVistaModelo
{
    public class OrdenProduccionVM
    {
        public int? Id { get; set; }
        public int? IdJornadaLaboral { get; set; }
        public string Numero { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public EstadoOrdenVM EstadoOrden { get; set; }
        public List<JornadaLaboralVM> JornadaLaborales { get; set; }
        public EmpleadoVM Empleado { get; set; }
        public ColorVM Color { get; set; }
        public ModeloVM Modelo { get; set; }
        public LineaVM Linea { get; set; }
        public AlertaVM Alerta { get; set; }

        public string EmpleadoV2 { get; set; }
        public string ColorV2 { get; set; }
        public string ModeloV2 { get; set; }
        public string LineaV2 { get; set; }
        public string AlertaV2 { get; set; }
    }
}
