using ServicioDatos;
using ServicioModelo.Entidades;
using ServicioVistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServidorControlCalidadV2._1.Controllers
{
    [Route("api/empleado")]
    public class EmpleadoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetEmpleado()
        {
            List<EmpleadoVM> listEmpleado = new List<EmpleadoVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listEmpleado = (from emp in db.Empleado
                             select new EmpleadoVM
                             {
                                 ApeYNom = emp.ApeYNom,
                                 Contraseña = emp.Contraseña,
                                 Dni = emp.DNI,
                                 Email = emp.Email,
                                 Id = emp.IdEmpleado,
                                 Rol = emp.Rol
                             }).ToList();
            }
            return Ok(listEmpleado);
        }
        [HttpGet]
        public IHttpActionResult GetEmpleadoPorDNI(string dni)
        {
            List<EmpleadoVM> listEmpleado = new List<EmpleadoVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listEmpleado = (from emp in db.Empleado
                                where emp.DNI == dni
                             select new EmpleadoVM
                             {
                                 ApeYNom = emp.ApeYNom,
                                 Contraseña = emp.Contraseña,
                                 Dni = emp.DNI,
                                 Email = emp.Email,
                                 Id = emp.IdEmpleado,
                                 Rol = emp.Rol
                             }).ToList();
            }
            return Ok(listEmpleado[0]);
        }
        [HttpPost]
        public IHttpActionResult AddEmpleado(EmpleadoVM emp)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
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
            return Ok("Creacion Exitosa");
        }
        [HttpPut]
        public IHttpActionResult PutEmpleado(EmpleadoVM emp)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
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
            return Ok("Modificacion Exitosa");
        }
        [HttpDelete]
        public IHttpActionResult DeleteEmpleado(EmpleadoVM emp)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oEmpleado = db.Empleado.Find(emp.Id);
                db.Empleado.Remove(oEmpleado);
                db.SaveChanges();
            }
            return Ok("Eliminacion Exitosa");
        }
    }
}
