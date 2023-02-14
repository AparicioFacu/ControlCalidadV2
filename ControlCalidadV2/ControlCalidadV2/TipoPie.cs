using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidadV2
{
    public enum TipoPieEnum
    {
        DERECHO,
        IZQUIERDO
    }
    public partial class TipoPie
    {
        public int? Id { get; set; }
        public string Descripcion { get; set; }
    }
}
