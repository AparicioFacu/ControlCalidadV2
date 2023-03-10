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
            AdministrarModelo administrar = new AdministrarModelo();
            administrar.PostModelo(mod);           
            return Ok("Creacion Exitosa");
        }
        [HttpPut]
        public IHttpActionResult PutModeloo(ModeloVM mod)
        {

            AdministrarModelo administrar = new AdministrarModelo();
            administrar.PutModelo(mod);            
            return Ok("Modificacion Exitosa");
        }
        [HttpDelete]
        public IHttpActionResult DeleteModeloo(ModeloVM mod)
        {
            AdministrarModelo administrar = new AdministrarModelo();
            administrar.DeleteModelo(mod);           
            return Ok("Eliminacion Exitosa");
        }
    }
}
