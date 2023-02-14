using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCalidadV2
{
    public class Modelo
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string Denominacion { get; set; }
        public int LimiteInferiorR { get; set; }
        public int LimiteSuperiorR { get; set; }
        public int LimiteInferiorO { get; set; }
        public int LimiteSuperiorO { get; set; }
    }
}
