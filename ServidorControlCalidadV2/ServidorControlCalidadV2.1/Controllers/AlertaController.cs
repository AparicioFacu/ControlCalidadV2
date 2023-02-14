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
    public class AlertaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetAlerta(int idOrden)
        {
            List<AlertaVM> listAlerta = new List<AlertaVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listAlerta = (from alerta in db.Alerta
                              where alerta.IdOrdenProduccion == idOrden
                              select new AlertaVM
                              {
                                 Id = alerta.IdAlerta,
                                 FechaHoraDetine = alerta.FechaHoraDetiene,
                                 FechaHoraReinicio = alerta.FechaHoraReinicio,
                                 Semaforo = new SemaforoVM
                                 {
                                     Id = alerta.Semaforo.IdSemaforo,
                                     Descripcion = alerta.Semaforo.Semaforo1
                                 },
                                 TipoDefecto = new TipoDefectoVM
                                 {
                                     Id = alerta.TipoDefecto.IdTipoDefecto,
                                     Descripcion = alerta.TipoDefecto.Defecto
                                 }

                              }).ToList();
            }
            if(listAlerta.Count == 0)
            {
                return null;
            }
            else
            {
                return Ok(listAlerta.Last());
            }
            
        }
        [HttpPost]
        public IHttpActionResult AddAlerta(AlertaVM alerta)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oAlerta = new Alerta();
                oAlerta.FechaHoraDetiene = alerta.FechaHoraDetine;
                oAlerta.FechaHoraReinicio = alerta.FechaHoraReinicio;
                oAlerta.IdSemaforo = alerta.Semaforo.Id;
                oAlerta.IdTipoDefecto = alerta.TipoDefecto.Id;
                oAlerta.IdOrdenProduccion = alerta.IdOrdenProduccion;
                db.Alerta.Add(oAlerta);
                db.SaveChanges();
            }
            return Ok("Creacion Exitosa");
        }
        [HttpPut]
        public IHttpActionResult PutAlerta(AlertaVM alerta)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oAlerta = db.Alerta.Find(alerta.Id);
                oAlerta.FechaHoraDetiene = alerta.FechaHoraDetine;
                oAlerta.FechaHoraReinicio = alerta.FechaHoraReinicio;
                oAlerta.IdSemaforo = alerta.Semaforo.Id;
                oAlerta.IdTipoDefecto = alerta.TipoDefecto.Id;
                oAlerta.IdOrdenProduccion = alerta.IdOrdenProduccion;
                db.Entry(oAlerta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok("Modificacion Exitosa");
        }
    }
}
