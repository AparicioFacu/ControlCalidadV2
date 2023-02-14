using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVistaModelo
{
    public enum EstadoOrden
    {
        INICIADA ,
        PAUSADA ,
        FINALIZADA
    }
    public partial class EstadoOrdenVM
    {
        public int? Id { get; set; }
        public string Descripcion { get; set; }
    }

}
