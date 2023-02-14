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
    public class DefectoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetDefectoPorTipoDefecto(string TipoDefecto)
        {
            List<DefectoVM> listDefecto = new List<DefectoVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listDefecto = (from def in db.Defecto
                               where def.TipoDefecto.Defecto == TipoDefecto
                             select new DefectoVM
                             {
                                 Id = def.IdDefecto,
                                 Descripcion = def.Descripcion,
                                 TipoDefecto = new TipoDefectoVM
                                 {
                                     Id = def.TipoDefecto.IdTipoDefecto,
                                     Descripcion = def.TipoDefecto.Defecto
                                 }
                                 
                             }).ToList();
            }
            return Ok(listDefecto);
        }
        [HttpGet]
        public IHttpActionResult GetDefectoP(string descripcion)
        {
            List<DefectoVM> listDefecto = new List<DefectoVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listDefecto = (from def in db.Defecto
                               where def.Descripcion == descripcion
                               select new DefectoVM
                               {
                                   Id = def.IdDefecto,
                                   Descripcion = def.Descripcion,
                                   TipoDefecto = new TipoDefectoVM
                                   {
                                       Id = def.TipoDefecto.IdTipoDefecto,
                                       Descripcion = def.TipoDefecto.Defecto
                                   }

                               }).ToList();
            }
            return Ok(listDefecto[0]);
        }
    }
}
