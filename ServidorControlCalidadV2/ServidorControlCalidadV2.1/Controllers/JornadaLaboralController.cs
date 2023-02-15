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
    [Route("api/jornadalaboral")]
    public class JornadaLaboralController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetJornadaLaborales()
        {
            List<JornadaLaboralVM> listJornadaLaboral = new List<JornadaLaboralVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listJornadaLaboral = (from jornada in db.JornadaLaboral
                             select new JornadaLaboralVM
                             {
                                 Id = jornada.IdJornadaLaboral,
                                 CParPrimera = jornada.CantParPrimera,
                                 CParSegunda = jornada.CantParSegunda,
                                 Empleado = new EmpleadoVM
                                 {
                                     Id = jornada.Empleado.IdEmpleado,
                                     ApeYNom = jornada.Empleado.ApeYNom,
                                     Email = jornada.Empleado.Email,
                                     Dni = jornada.Empleado.DNI,
                                     Rol = jornada.Empleado.Rol
                                 },
                                 FechaInicio = jornada.FechaInicio,
                                 FechaFin = jornada.FechaFinal,  
                                 IdOrdenProduccion = jornada.IdOrdenProduccion
                                 //OrdenProduccion = new OrdenProduccionVM
                                 //{
                                 //    IdJornadaLaboral = jornada.OrdenProduccion.IdJornadaLaboral
                                 //},
                                 //Registro = new RegistroVM
                                 //{
                                 //    Defecto = new DefectoVM
                                 //    {
                                 //        Descripcion = jornada.Registro.Defecto.Descripcion,
                                 //        Id = jornada.Registro.Defecto.IdDefecto,
                                 //        TipoDefecto = new TipoDefectoVM
                                 //        {
                                 //            Id = jornada.Registro.Defecto.TipoDefecto.IdTipoDefecto,
                                 //            Descripcion = jornada.Registro.Defecto.TipoDefecto.Defecto
                                 //        }                       
                                 //    },
                                 //    Id = jornada.Registro.IdRegistro,
                                 //    Hora = jornada.Registro.Hora,
                                 //    TipoPie = new TipoPieVM
                                 //    {
                                 //        Id = jornada.Registro.Pie.IdPie,
                                 //        Descripcion = jornada.Registro.Pie.Pie1
                                 //    }
                                 //},
                                 //Turno = new TurnoVM
                                 //{
                                 //    Descripcion = jornada.Turno.Descripcion,
                                 //    HoraFin = jornada.Turno.HorarioFin,
                                 //    HoraInicio = jornada.Turno.HorarioInicio,
                                 //    Id = jornada.Turno.IdTurno
                                 //}                                                                                                  
                             }).ToList();
            }
            return Ok(listJornadaLaboral);
        }
        [HttpGet]
        public IHttpActionResult GetJornadaLaboralPorId(int idJornada)
        {
            List<JornadaLaboralVM> listJornadaLaboral = new List<JornadaLaboralVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listJornadaLaboral = (from jornada in db.JornadaLaboral
                                      where jornada.IdJornadaLaboral == idJornada
                                      select new JornadaLaboralVM
                                      {
                                          Id = jornada.IdJornadaLaboral,
                                          CParPrimera = jornada.CantParPrimera,
                                          CParSegunda = jornada.CantParSegunda,
                                          Empleado = new EmpleadoVM
                                          {
                                              Id = jornada.Empleado.IdEmpleado,
                                              ApeYNom = jornada.Empleado.ApeYNom,
                                              Email = jornada.Empleado.Email,
                                              Dni = jornada.Empleado.DNI,
                                              Rol = jornada.Empleado.Rol
                                          },
                                          FechaInicio = jornada.FechaInicio,
                                          FechaFin = jornada.FechaFinal,
                                          IdOrdenProduccion = jornada.IdOrdenProduccion                                                                                                
                                      }).ToList();
            }
            return Ok(listJornadaLaboral[0]);
        }
        [HttpGet]
        public IHttpActionResult GetJornadaLaboral(DateTime fecha)
        {
            List<JornadaLaboralVM> listJornadaLaboral = new List<JornadaLaboralVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listJornadaLaboral = (from jornada in db.JornadaLaboral
                                      where jornada.FechaInicio == fecha
                                      select new JornadaLaboralVM
                                      {
                                          Id = jornada.IdJornadaLaboral,
                                          CParPrimera = jornada.CantParPrimera,
                                          CParSegunda = jornada.CantParSegunda,
                                          Empleado = new EmpleadoVM
                                          {
                                              Id = jornada.Empleado.IdEmpleado,
                                              ApeYNom = jornada.Empleado.ApeYNom,
                                              Email = jornada.Empleado.Email,
                                              Dni = jornada.Empleado.DNI,
                                              Rol = jornada.Empleado.Rol
                                          },
                                          FechaInicio = jornada.FechaInicio,
                                          FechaFin = jornada.FechaFinal,
                                          IdOrdenProduccion = jornada.IdOrdenProduccion                                                                                                                                         
                                      }).ToList();
            }
            return Ok(listJornadaLaboral[0]);
        }
        [HttpPost]
        public IHttpActionResult AddJornadaLaboral(JornadaLaboralVM jornada)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oJornada = new JornadaLaboral();
                oJornada.CantParPrimera = jornada.CParPrimera;
                oJornada.CantParSegunda = jornada.CParSegunda;
                oJornada.FechaInicio = jornada.FechaInicio;
                oJornada.FechaFinal = jornada.FechaFin;
                oJornada.IdEmpleado = jornada.Empleado.Id;
                oJornada.IdOrdenProduccion = jornada.IdOrdenProduccion;
                oJornada.AgregarTurno(jornada.Turnos,oJornada);
                db.JornadaLaboral.Add(oJornada);                
                db.SaveChanges();
            }
            return Ok("Creacion Exitosa");
        }
        [HttpPut]
        public IHttpActionResult PutJornada(JornadaLaboralVM jornada)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oJornada = db.JornadaLaboral.Find(jornada.Id);
                oJornada.CantParPrimera = jornada.CParPrimera;
                oJornada.CantParSegunda = jornada.CParSegunda;
                oJornada.FechaInicio = jornada.FechaInicio;
                oJornada.FechaFinal = jornada.FechaFin;
                oJornada.IdEmpleado = jornada.Empleado.Id;
                oJornada.IdOrdenProduccion = jornada.IdOrdenProduccion;
                db.Entry(oJornada).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return Ok("Modificacion Exitosa");
        }
    }
}
