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
    [Route("api/modelo")]
    public class ModeloController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetModelo()
        {
            List<ModeloVM> listModelo = new List<ModeloVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listModelo = (from mod in db.Modelo
                             select new ModeloVM
                             {
                                 Id = mod.IdModelo,
                                 Denominacion = mod.Denominacion,
                                 LimiteInferiorO = mod.LimiteInferiorO,
                                 LimiteInferiorR = mod.LimiteInferiorR,
                                 LimiteSuperiorO = mod.LimiteSuperiorO,
                                 LimiteSuperiorR = mod.LimiteSuperiorR,
                                 Sku = mod.SKU                               
                             }).ToList();
            }
            return Ok(listModelo);
        }
        [HttpGet]
        public IHttpActionResult GetModeloPorSKU(string sku)
        {
            List<ModeloVM> listModelo = new List<ModeloVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listModelo = (from mod in db.Modelo
                              where mod.SKU == sku
                              select new ModeloVM
                              {
                                  Id = mod.IdModelo,
                                  Denominacion = mod.Denominacion,
                                  LimiteInferiorO = mod.LimiteInferiorO,
                                  LimiteInferiorR = mod.LimiteInferiorR,
                                  LimiteSuperiorO = mod.LimiteSuperiorO,
                                  LimiteSuperiorR = mod.LimiteSuperiorR,
                                  Sku = mod.SKU
                              }).ToList();
            }
            return Ok(listModelo[0]);
        }
        [HttpPost]
        public IHttpActionResult AddModelo(ModeloVM mod)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oModelo = new Modelo();
                oModelo.Denominacion = mod.Denominacion;
                oModelo.LimiteInferiorO = mod.LimiteInferiorO;
                oModelo.LimiteInferiorR = mod.LimiteInferiorR;
                oModelo.LimiteSuperiorO = mod.LimiteSuperiorO;
                oModelo.LimiteSuperiorR = mod.LimiteSuperiorR;
                oModelo.SKU = mod.Sku;
                db.Modelo.Add(oModelo);
                db.SaveChanges();
            }
            return Ok("Creacion Exitosa");
        }
        [HttpPut]
        public IHttpActionResult PutModelo(ModeloVM mod)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oModelo = db.Modelo.Find(mod.Id);
                oModelo.Denominacion = mod.Denominacion;
                oModelo.LimiteInferiorO = mod.LimiteInferiorO;
                oModelo.LimiteInferiorR = mod.LimiteInferiorR;
                oModelo.LimiteSuperiorO = mod.LimiteSuperiorO;
                oModelo.LimiteSuperiorR = mod.LimiteSuperiorR;
                oModelo.SKU = mod.Sku;
                db.Entry(oModelo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok("Modificacion Exitosa");
        }
        [HttpDelete]
        public IHttpActionResult DeleteModelo(ModeloVM mod)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oModelo = db.Modelo.Find(mod.Id);
                db.Modelo.Remove(oModelo);
                db.SaveChanges();
            }
            return Ok("Eliminacion Exitosa");
        }
    }
}
