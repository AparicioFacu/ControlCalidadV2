using ServicioDatos;
using ServicioVistaModelo;
using ServicioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServidorControlCalidadV2._1.Controllers
{
    [Route("api/ordenproduccion")]
    public class OrdenProduccionController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetOrdenProducciones()
        {
            List<OrdenProduccionVM> listOrdenProduccion = new List<OrdenProduccionVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listOrdenProduccion = (from orden in db.OrdenProduccion
                             select new OrdenProduccionVM
                             {
                                 Id = orden.IdOrdenProduccion,
                                 Numero = orden.Numero,
                                 FechaInicio = orden.FechaInicio,
                                 FechaFin = orden.FechaFin,
                                 Color = new ColorVM
                                 {
                                     Id = orden.Color.IdColor,
                                     Codigo = orden.Color.Codigo,
                                     Descripcion = orden.Color.Descripcion
                                 },
                                 Modelo = new ModeloVM
                                 {
                                     Id = orden.Modelo.IdModelo,                                    
                                     Denominacion = orden.Modelo.Denominacion,
                                     LimiteInferiorO = orden.Modelo.LimiteInferiorO,
                                     LimiteInferiorR = orden.Modelo.LimiteInferiorR,
                                     LimiteSuperiorO = orden.Modelo.LimiteSuperiorO,
                                     LimiteSuperiorR = orden.Modelo.LimiteSuperiorR,
                                     Sku = orden.Modelo.SKU
                                 },
                                 Linea = new LineaVM
                                 {
                                     Id = orden.Linea.IdLinea,
                                     Numero = orden.Linea.Numero
                                 },
                                 EstadoOrden = new EstadoOrdenVM
                                 {
                                     Id = orden.EstadoOrden.IdEstadoOrden,
                                     Descripcion = orden.EstadoOrden.Estado
                                 },                                                               
                                 Empleado = new EmpleadoVM
                                 {
                                     Id = orden.Empleado.IdEmpleado,
                                     ApeYNom = orden.Empleado.ApeYNom,
                                     Email = orden.Empleado.Email,
                                     Dni = orden.Empleado.DNI,
                                     Rol = orden.Empleado.Rol
                                 }
                             }                                                        
                             ).ToList();               
            }          
            return Ok(listOrdenProduccion);
             
        }
        [HttpGet]
        public IHttpActionResult GetOrdenProduccion(string numero)
        {
            List<OrdenProduccionVM> listOrdenProduccion = new List<OrdenProduccionVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listOrdenProduccion = (from orden in db.OrdenProduccion
                                       where orden.Numero == numero
                                       select new OrdenProduccionVM
                                       {
                                           Id = orden.IdOrdenProduccion,
                                           Numero = orden.Numero,
                                           FechaInicio = orden.FechaInicio,
                                           FechaFin = orden.FechaFin,
                                           Color = new ColorVM
                                           {
                                               Id = orden.Color.IdColor,
                                               Codigo = orden.Color.Codigo,
                                               Descripcion = orden.Color.Descripcion
                                           },
                                           Modelo = new ModeloVM
                                           {
                                               Id = orden.Modelo.IdModelo,
                                               Denominacion = orden.Modelo.Denominacion,
                                               LimiteInferiorO = orden.Modelo.LimiteInferiorO,
                                               LimiteInferiorR = orden.Modelo.LimiteInferiorR,
                                               LimiteSuperiorO = orden.Modelo.LimiteSuperiorO,
                                               LimiteSuperiorR = orden.Modelo.LimiteSuperiorR,
                                               Sku = orden.Modelo.SKU
                                           },
                                           Linea = new LineaVM
                                           {
                                               Id = orden.Linea.IdLinea,
                                               Numero = orden.Linea.Numero
                                           },
                                           EstadoOrden = new EstadoOrdenVM
                                           {
                                               Id = orden.EstadoOrden.IdEstadoOrden,
                                               Descripcion = orden.EstadoOrden.Estado
                                           },                                          
                                           Empleado = new EmpleadoVM
                                           {
                                               Id = orden.Empleado.IdEmpleado,
                                               ApeYNom = orden.Empleado.ApeYNom,
                                               Email = orden.Empleado.Email,
                                               Dni = orden.Empleado.DNI,
                                               Rol = orden.Empleado.Rol
                                           }
                                       }
                             ).ToList();
            }
            return Ok(listOrdenProduccion[0]);
        }
        [HttpGet]
        public IHttpActionResult GetOrdenProduccionPorJornadaLaboral(int idOrden)
        {
            List<OrdenProduccionVM> listOrdenProduccion = new List<OrdenProduccionVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listOrdenProduccion = (from orden in db.OrdenProduccion
                                       where orden.IdOrdenProduccion == idOrden
                                       select new OrdenProduccionVM
                                       {
                                           Id = orden.IdOrdenProduccion,
                                           Numero = orden.Numero,
                                           FechaInicio = orden.FechaInicio,
                                           FechaFin = orden.FechaFin,
                                           Color = new ColorVM
                                           {
                                               Id = orden.Color.IdColor,
                                               Codigo = orden.Color.Codigo,
                                               Descripcion = orden.Color.Descripcion
                                           },
                                           Modelo = new ModeloVM
                                           {
                                               Id = orden.Modelo.IdModelo,
                                               Denominacion = orden.Modelo.Denominacion,
                                               LimiteInferiorO = orden.Modelo.LimiteInferiorO,
                                               LimiteInferiorR = orden.Modelo.LimiteInferiorR,
                                               LimiteSuperiorO = orden.Modelo.LimiteSuperiorO,
                                               LimiteSuperiorR = orden.Modelo.LimiteSuperiorR,
                                               Sku = orden.Modelo.SKU
                                           },
                                           Linea = new LineaVM
                                           {
                                               Id = orden.Linea.IdLinea,
                                               Numero = orden.Linea.Numero
                                           },
                                           EstadoOrden = new EstadoOrdenVM
                                           {
                                               Id = orden.EstadoOrden.IdEstadoOrden,
                                               Descripcion = orden.EstadoOrden.Estado
                                           },
                                           Empleado = new EmpleadoVM
                                           {
                                               Id = orden.Empleado.IdEmpleado,
                                               ApeYNom = orden.Empleado.ApeYNom,
                                               Email = orden.Empleado.Email,
                                               Dni = orden.Empleado.DNI,
                                               Rol = orden.Empleado.Rol
                                           }
                                       }
                             ).ToList();
            }
            return Ok(listOrdenProduccion[0]);
        }
        [HttpPost]
        public IHttpActionResult AddOrdenProduccion(OrdenProduccionVM orden)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var ordenProduccion = new OrdenProduccion();
                ordenProduccion.Numero = orden.Numero;
                ordenProduccion.FechaInicio = orden.FechaInicio;
                ordenProduccion.IdEstadoOrden = 1;
                ordenProduccion.IdColor = orden.Color.Id;
                ordenProduccion.IdModelo = orden.Modelo.Id;
                ordenProduccion.IdLinea = orden.Linea.Id;
                ordenProduccion.IdEmpleado = orden.Empleado.Id;                              
                db.OrdenProduccion.Add(ordenProduccion);
                db.SaveChanges();
                //List<OrdenProduccion> ordenEmpleado = new List<OrdenProduccion>();
                //ordenEmpleado = db.OrdenProduccion.ToList();
                //foreach (var ord in ordenEmpleado)
                //{
                //    if (orden.Empleado.Id == ord.Empleado.IdEmpleado)
                //    {
                //        return Ok("El Empleado " + orden.Empleado.ApeYNom + " ya se encuentra en una orden de produccion en este momento");
                //    }
                //    else
                //    {
                        
                //        break;
                //    }
                //}               
                //ordenProduccion.AgregarJornadaLaborales(orden.JornadaLaborales, ordenProduccion);               
            }
            return Ok("Creacion Exitosa");
        }
        [HttpPut]
        public IHttpActionResult PutOrden(OrdenProduccionVM orden)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oOrdenProduccion = db.OrdenProduccion.Find(orden.Id);
                oOrdenProduccion.Numero = orden.Numero;
                oOrdenProduccion.FechaInicio = orden.FechaInicio;                
                oOrdenProduccion.IdColor = orden.Color.Id;
                oOrdenProduccion.IdModelo = orden.Modelo.Id;
                oOrdenProduccion.IdLinea = orden.Linea.Id;
                oOrdenProduccion.IdEmpleado = orden.Empleado.Id;
                oOrdenProduccion.IdEstadoOrden = oOrdenProduccion.CambiarEstado(orden.EstadoOrden.Descripcion);
                db.Entry(oOrdenProduccion).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok("Modificacion Exitosa");
        }
    }
}
