using AccesoExterno.Adaptadores;
using ControlCalidadV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador.Presentadores
{
    public class PresentadorEmpleado
    {
        public void CrearEmpleado(string DNI, string ApeYNom,string email,string rol,string contraseña, DataGridView tabla)
        {
            Post postEmpleado = new Post();
            Empleado empleado = new Empleado();
            empleado.Dni = DNI;
            empleado.ApeYNom = ApeYNom;
            empleado.Email = email;
            empleado.Contraseña = contraseña;
            empleado.Rol = rol;
            postEmpleado.PostEmpleado(empleado);
            CargarTabla(tabla);
        }
        public void CargarTabla(DataGridView tabla)
        {
            Get<Empleado> getEmpleado = new Get<Empleado>();
            tabla.DataSource = (from emp in getEmpleado.GetEmpleados()
                                select new
                                {
                                    DNI = emp.Dni,
                                    ApellidoNombre = emp.ApeYNom,
                                    Email = emp.Email,
                                    Rol = emp.Rol
                                }
                ).Distinct().ToList();
        }
        public void BuscarEmpleado(DataGridView tabla, string txtDNI, TextBox txtApeYNom, TextBox txtEmail, ComboBox cbxRol, TextBox txtContraseña)
        {
            if (txtDNI.Length == 0)
            {
                CargarTabla(tabla);
            }
            else
            {
                Get<Empleado> getEmpleado = new Get<Empleado>();
                Empleado empleado = getEmpleado.GetEmpleadoPorDNI(txtDNI);
                tabla.DataSource = (from emp in getEmpleado.GetEmpleados()
                                    where emp.Dni == txtDNI
                                    select new
                                    {
                                        DNI = emp.Dni,
                                        ApellidoNombre = emp.ApeYNom,
                                        Email = emp.Email,
                                        Rol = emp.Rol
                                    }
                    ).Distinct().ToList();
                txtApeYNom.Text = empleado.ApeYNom;
                txtEmail.Text = empleado.Email;
                cbxRol.Text = empleado.Rol;
                txtContraseña.Text = empleado.Contraseña;
            }
        }
        public void EliminarEmpleado(DataGridView tabla, string dni)
        {
            Delete delete = new Delete();
            Get<Empleado> getEmpleado = new Get<Empleado>();
            Empleado empleado = getEmpleado.GetEmpleadoPorDNI(dni);
            delete.DeleteEmpleado(empleado);
            CargarTabla(tabla);
        }
        public void ModificarEmpleado(DataGridView tabla, string txtDNI, string txtApeYNom, string txtEmail,string txtContraseña, string cbxRol)
        {
            Put put = new Put();
            Get<Empleado> getEmpleado = new Get<Empleado>();
            Empleado empleado = getEmpleado.GetEmpleadoPorDNI(txtDNI);
            empleado.Dni = txtDNI;
            empleado.ApeYNom = txtApeYNom;
            empleado.Contraseña = txtContraseña;
            empleado.Email = txtEmail;
            empleado.Rol = cbxRol;
            put.PutEmpleado(empleado);
            CargarTabla(tabla);
        }
    }
}
