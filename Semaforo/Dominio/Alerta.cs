using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Alerta
    {
        public int? Id { get; set; }
        public DateTime? FechaHoraDetine { get; set; }
        public DateTime? FechaHoraReinicio { get; set; }
    }
}
