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
    [Route("api/linea")]
    public class LineaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetLinea(int idEmpleado)
        {
            List<LineaVM> listLinea = new List<LineaVM>();
            List<LineaVM> listLineaEmpleado;
            Linea linea = new Linea();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                List<OrdenProduccion> ordenes = db.OrdenProduccion.ToList();                

                listLinea = (from lin in db.Linea
                             select new LineaVM
                             {
                                 Id = lin.IdLinea,
                                 Numero = lin.Numero
                             }).ToList();
                listLineaEmpleado = linea.ObtenerLineasDisponibles(ordenes, listLinea, idEmpleado);
            }
            return Ok(listLineaEmpleado);
        }
    }
}
