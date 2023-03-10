using ServicioAplicacion;
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
            AdministrarEmpleado administrar = new AdministrarEmpleado();
            administrar.PostEmpleado(emp);
            return Ok("Creacion Exitosa");
        }
        [HttpPut]
        public IHttpActionResult PutEmpleadoo(EmpleadoVM emp)
        {
            AdministrarEmpleado administrar = new AdministrarEmpleado();
            administrar.PutEmpleado(emp);
            return Ok("Modificacion Exitosa");
        }
        [HttpDelete]
        public IHttpActionResult DeleteEmpleadoo(EmpleadoVM emp)
        {
            AdministrarEmpleado administrar = new AdministrarEmpleado();
            administrar.DeleteEmpleado(emp);
            return Ok("Eliminacion Exitosa");
        }
    }
}
