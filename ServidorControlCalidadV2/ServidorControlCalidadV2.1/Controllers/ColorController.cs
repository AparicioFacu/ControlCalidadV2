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
    [Route("api/color")]
    public class ColorController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetColor()
        {
            List<ColorVM> listColor = new List<ColorVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
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
        [HttpGet]
        public IHttpActionResult GetColorPorCodigo(int codigo)
        {
            List<ColorVM> listColor = new List<ColorVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listColor = (from col in db.Color
                              where col.Codigo == codigo
                              select new ColorVM
                              {
                                  Id = col.IdColor,
                                  Codigo = col.Codigo,
                                  Descripcion = col.Descripcion
                              }).ToList();
            }
            return Ok(listColor[0]);
        }
        [HttpPost]
        public IHttpActionResult AddColor(ColorVM col)
        {
            AdministrarColor administrar = new AdministrarColor();
            administrar.PostColor(col);
            return Ok("Creacion Exitosa");
        }
        [HttpPut]
        public IHttpActionResult PutColorr(ColorVM col)
        {
            AdministrarColor administrar = new AdministrarColor();
            administrar.PutColor(col);
            return Ok("Modificacion Exitosa");
        }
        [HttpDelete]
        public IHttpActionResult DeleteColorr(ColorVM col)
        {
            AdministrarColor administrar = new AdministrarColor();
            administrar.DeleteColor(col);
            return Ok("Eliminacion Exitosa");
        }
    }
}
