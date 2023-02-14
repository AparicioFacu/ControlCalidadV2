using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidadV2
{
    public class Alerta
    {
        public int? Id { get; set; }
        public int? IdOrdenProduccion { get; set; }
        public DateTime? FechaHoraDetine { get; set; }
        public DateTime? FechaHoraReinicio { get; set; }
        public TipoDefecto TipoDefecto { get; set; }
        public Semaforo Semaforo { get; set; }
    }
}
