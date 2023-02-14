using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Modelo
    {
        public int Id { get; set; }
        public int SKU { get; set; }
        public string Denominacion { get; set; }
        public int LimiteInferiorR { get; set; }
        public int LimiteSuperiorR { get; set; }
        public int LimiteInferiorO { get; set; }
        public int LimiteSuperiorO { get; set; }
    }
}
