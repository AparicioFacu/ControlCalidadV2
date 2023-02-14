using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string ApeYNom { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string Contraseña { get; set; }
    }
}
