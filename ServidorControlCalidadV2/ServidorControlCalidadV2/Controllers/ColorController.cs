using ServicioVistaModelo;
using ServicioDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServidorControlCalidadV2.Controllers
{    
    public class ColorController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetColor()
        {
            List<ColorVM> listColor = new List<ColorVM>();
            using(ControlCalidadEntities db = new ControlCalidadEntities())
            {
                listColor = (from col in db.Color
                             select new ColorVM
                             {
                                 Id = col.IdColor,
                                 Codigo = col.Codigo,
                                 Descripcion = col.Descripcion
                             }).ToList();
            }
            return Ok(listColor);
        }
       
    }
}
