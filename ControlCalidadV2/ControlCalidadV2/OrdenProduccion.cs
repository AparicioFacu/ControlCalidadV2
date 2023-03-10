using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidadV2
{
    public class OrdenProduccion
    {
        public int? Id { get; set; }
        public int? IdJornadaLaboral { get; set; }
        public string Numero { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public EstadoOrden EstadoOrden { get; set; }
        public List<JornadaLaboral> JornadasLaborales { get; set; }        
        public Empleado Empleado { get; set; }
        public Color Color { get; set; }
        public Modelo Modelo { get; set; }
        public Linea Linea { get; set; }
        public Alerta Alerta { get; set; }

        public string EmpleadoV2 { get; set; }
        public string ColorV2 { get; set; }
        public string ModeloV2 { get; set; }
        public string LineaV2 { get; set; }
        public string AlertaV2 { get; set; }
    }
}
