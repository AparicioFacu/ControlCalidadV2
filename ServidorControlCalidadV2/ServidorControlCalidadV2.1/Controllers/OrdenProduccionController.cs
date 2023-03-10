using ServicioDatos;
using ServicioVistaModelo;
using ServicioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicioAplicacion;

namespace ServidorControlCalidadV2._1.Controllers
{
    [Route("api/ordenproduccion")]
    public class OrdenProduccionController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetOrdenProducciones()
        {
            //ControlCalidadEntities1 db = new ControlCalidadEntities1();
            //return Ok(db.OrdenProduccion.ToList());
            List<OrdenProduccionVM> listOrdenProduccion = new List<OrdenProduccionVM>();

            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                //db.OrdenProduccion.Select(op=>new OrdenProduccionVM(op))
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
            try
            {
                AdministrarOrden administrar = new AdministrarOrden();
                administrar.PostOrden(orden);
                return Ok("Creacion Exitosa");
            }
            catch (Exception)
            {
                return BadRequest();
            }          
        }
        [HttpPut]
        public IHttpActionResult PutOrdenn(OrdenProduccionVM orden)
        {
            AdministrarOrden administrar = new AdministrarOrden();
            administrar.PutOrden(orden);           
            return Ok("Modificacion Exitosa");
        }
    }
}
