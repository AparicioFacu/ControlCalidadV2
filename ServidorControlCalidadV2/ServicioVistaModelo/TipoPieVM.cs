using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVistaModelo
{
    public enum TipoPie
    {
        DERECHO,
        IZQUIERDO
    }
    public partial class TipoPieVM
    {
        public int? Id { get; set; }
        public string Descripcion { get; set; }
    }

}
