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
    public class TurnoController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetTurno(int idJornada)
        {
            List<TurnoVM> listTurno = new List<TurnoVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listTurno = (from tur in db.Turno
                             where tur.IdJornadaLaboral == idJornada
                             select new TurnoVM
                             {
                                 Id = tur.IdTurno,
                                 HoraInicio = tur.HorarioInicio,
                                 HoraFin = tur.HorarioFin,                                
                             }).ToList();
            }
            return Ok(listTurno.Last());
        }
        [HttpPost]
        public IHttpActionResult AddTurno(TurnoVM turno)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oTurno = new Turno();
                oTurno.HorarioFin = turno.HoraFin;
                oTurno.HorarioInicio = turno.HoraInicio;
                oTurno.IdJornadaLaboral = turno.IdJornadaLaboral;
                db.Turno.Add(oTurno);
                db.SaveChanges();
            }
            return Ok("Creacion Exitosa");
        }
    }
}
