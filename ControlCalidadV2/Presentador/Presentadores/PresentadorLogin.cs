using AccesoExterno.Adaptadores;
using ControlCalidadV2;
using Presentador.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentador.Presentadores
{
    public class PresentadorLogin
    {
        Get<Empleado> AdaptadorEmpelados = new Get<Empleado>();
        List<Empleado> _empleados;
        public void iniciarSesion(string nombre, string contraseña)
        {
            _empleados = AdaptadorEmpelados.GetEmpleados();
            foreach (var emp in _empleados)
            {
                if (nombre.Equals(emp.Email) && contraseña.Equals(emp.Contraseña))
                {
                    MenuInicio menu = new MenuInicio(emp.ApeYNom,emp.Rol,emp.Id);                
                    menu.Show();                   
                }
                else
                {
                    //MessageBox.Show("Legajo o contraseña incorrectos");
                }
            }
        }
    }
}
