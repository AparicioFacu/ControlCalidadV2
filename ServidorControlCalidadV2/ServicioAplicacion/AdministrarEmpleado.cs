using ServicioDatos;
using ServicioModelo.Entidades;
using ServicioVistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioAplicacion
{
    public class AdministrarEmpleado
    {
        ControlCalidadEntities1 db = new ControlCalidadEntities1();
        public void PostEmpleado(EmpleadoVM emp)
        {
            var oEmpleado = new Empleado();
            oEmpleado.DNI = emp.Dni;
            oEmpleado.ApeYNom = emp.ApeYNom;
            oEmpleado.Email = emp.Email;
            oEmpleado.Contraseña = emp.Contraseña;
            oEmpleado.Rol = emp.Rol;
            db.Empleado.Add(oEmpleado);
            db.SaveChanges();
        }
        public void PutEmpleado(EmpleadoVM emp)
        {
            var oEmpleado = db.Empleado.Find(emp.Id);
            oEmpleado.DNI = emp.Dni;
            oEmpleado.ApeYNom = emp.ApeYNom;
            oEmpleado.Email = emp.Email;
            oEmpleado.Contraseña = emp.Contraseña;
            oEmpleado.Rol = emp.Rol;
            db.Entry(oEmpleado).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void DeleteEmpleado(EmpleadoVM emp)
        {
            var oEmpleado = db.Empleado.Find(emp.Id);
            db.Empleado.Remove(oEmpleado);
            db.SaveChanges();
        }
    }
}
