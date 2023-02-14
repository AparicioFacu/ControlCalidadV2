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
    public class PieController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetPie()
        {
            List<TipoPieVM> listPie = new List<TipoPieVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listPie = (from pie in db.Pie
                             select new TipoPieVM
                             {
                                 Id = pie.IdPie,
                                 Descripcion = pie.Pie1
                             }).ToList();
            }
            return Ok(listPie);
        }
        [HttpGet]
        public IHttpActionResult GetPiePorDescripcion(string descripcion)
        {
            List<TipoPieVM> listPie = new List<TipoPieVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listPie = (from pie in db.Pie
                           where pie.Pie1 == descripcion
                           select new TipoPieVM
                           {
                               Id = pie.IdPie,
                               Descripcion = pie.Pie1
                           }).ToList();
            }
            return Ok(listPie[0]);
        }
    }
}
