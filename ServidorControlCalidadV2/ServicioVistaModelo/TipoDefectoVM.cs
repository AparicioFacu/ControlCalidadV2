using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVistaModelo
{
    public enum TipoDefecto
    {
        OBSERVADO,
        REPROCESO
    }
    public partial class TipoDefectoVM
    {
        public int? Id { get; set; }
        public string Descripcion { get; set; }
    }
}
