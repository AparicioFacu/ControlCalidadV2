using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioVistaModelo
{
    public enum SemaforoVMEnum
    {
        Verde,
        Amarillo,
        Rojo
    }
    public partial class SemaforoVM
    {
        public int? Id { get; set; }
        public string Descripcion { get; set; }
    }
}
