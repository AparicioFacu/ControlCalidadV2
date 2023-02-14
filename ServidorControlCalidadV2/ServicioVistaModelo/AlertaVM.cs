using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVistaModelo
{
    public class AlertaVM
    {
        public int? Id { get; set; }
        public int? IdOrdenProduccion { get; set; }
        public DateTime? FechaHoraDetine { get; set; }
        public DateTime? FechaHoraReinicio { get; set; }
        public TipoDefectoVM TipoDefecto { get; set; }
        public SemaforoVM Semaforo { get; set; }
    }
}
