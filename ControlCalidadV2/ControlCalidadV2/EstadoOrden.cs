using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidadV2
{
    public enum EstadoOrdenEnum
    {
        Iniciada,
        Pausada,
        Finalizada

    }
    public partial class EstadoOrden
    {
        public int? Id { get; set; }
        public string Descripcion { get; set; }
    }
}
