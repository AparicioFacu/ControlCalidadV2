using ServicioDatos;
using ServicioVistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServidorControlCalidadV2._1.Controllers
{
    [Route("api/tipodefecto")]
    public class TipoDefectoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetTipoDefecto()
        {
            List<TipoDefectoVM> listTipoDefecto = new List<TipoDefectoVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listTipoDefecto = (from def in db.TipoDefecto
                              select new TipoDefectoVM
                              {
                                  Id = def.IdTipoDefecto,
                                  Descripcion = def.Defecto
                              }).ToList();
            }
            return Ok(listTipoDefecto);
        }
    }
}
