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
    public class RegistroController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetRegistroPorPieHoraTipoDefecto(int idJornada,int idPie,string hora,string tipoDefecto)
        {
            List<RegistroVM> listRegistro = new List<RegistroVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listRegistro = (from reg in db.Registro
                                where reg.IdJornadaLaboral == idJornada
                                where reg.IdPie == idPie
                                //where reg.Hora == hora
                                where reg.Defecto.TipoDefecto.Defecto == tipoDefecto
                                select new RegistroVM                                
                                {
                                    Id = reg.IdRegistro,
                                    Hora = reg.Hora, 
                                    Defecto = new DefectoVM
                                    {
                                        Id = reg.Defecto.IdDefecto,
                                        Descripcion = reg.Defecto.Descripcion,
                                        TipoDefecto = new TipoDefectoVM
                                        {
                                            Id = reg.Defecto.TipoDefecto.IdTipoDefecto,
                                            Descripcion = reg.Defecto.TipoDefecto.Defecto,
                                        }
                                    },
                                    TipoPie = new TipoPieVM
                                    {
                                        Id = reg.Pie.IdPie,
                                        Descripcion = reg.Pie.Pie1
                                    }
                                }).ToList();
            }
            Registro registro = new Registro();
            List<RegistroVM> listRegistroPorHora = registro.RegistrosPorHora(listRegistro, hora);
            return Ok(listRegistroPorHora);
        }
        [HttpGet]
        public IHttpActionResult GetRegistroPorDefectoHoraPie(int idJornada, int idPie, string hora, string defecto)
        {
            List<RegistroVM> listRegistro = new List<RegistroVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listRegistro = (from reg in db.Registro
                                where reg.IdJornadaLaboral == idJornada
                                where reg.IdPie == idPie
                                //where reg.Hora == hora
                                where reg.Defecto.Descripcion == defecto
                                select new RegistroVM
                                {
                                    Id = reg.IdRegistro,
                                    Hora = reg.Hora,
                                    Defecto = new DefectoVM
                                    {
                                        Id = reg.Defecto.IdDefecto,
                                        Descripcion = reg.Defecto.Descripcion,
                                        TipoDefecto = new TipoDefectoVM
                                        {
                                            Id = reg.Defecto.TipoDefecto.IdTipoDefecto,
                                            Descripcion = reg.Defecto.TipoDefecto.Defecto,
                                        }
                                    },
                                    TipoPie = new TipoPieVM
                                    {
                                        Id = reg.Pie.IdPie,
                                        Descripcion = reg.Pie.Pie1
                                    }
                                }).ToList();
            }
            Registro registro = new Registro();
            List<RegistroVM> listRegistroPorHora = registro.RegistrosPorHora(listRegistro, hora);
            return Ok(listRegistroPorHora[0]);
        }
        [HttpGet]
        public IHttpActionResult GetRegistroPorHora(string hora,int pie)
        {
            List<RegistroVM> listRegistro = new List<RegistroVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listRegistro = (from reg in db.Registro                                
                                //where reg.Hora == hora
                                where reg.Pie.IdPie == pie
                                select new RegistroVM
                                {
                                    Id = reg.IdRegistro,
                                    Hora = reg.Hora,
                                    Defecto = new DefectoVM
                                    {
                                        Id = reg.Defecto.IdDefecto,
                                        Descripcion = reg.Defecto.Descripcion,
                                        TipoDefecto = new TipoDefectoVM
                                        {
                                            Id = reg.Defecto.TipoDefecto.IdTipoDefecto,
                                            Descripcion = reg.Defecto.TipoDefecto.Defecto,
                                        }
                                    },
                                    TipoPie = new TipoPieVM
                                    {
                                        Id = reg.Pie.IdPie,
                                        Descripcion = reg.Pie.Pie1
                                    }
                                }).ToList();
            }
            Registro registro = new Registro();
            List<RegistroVM> listRegistroPorHora = registro.RegistrosPorHora(listRegistro, hora);
            return Ok(listRegistroPorHora);
        }
        [HttpGet]
        public IHttpActionResult GetRegistroPorOrdenProduccionPie(int idOrden, int pie)
        {
            List<RegistroVM> listRegistro = new List<RegistroVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listRegistro = (from reg in db.Registro
                                where reg.JornadaLaboral.IdJornadaLaboral == idOrden
                                where reg.Pie.IdPie == pie
                                select new RegistroVM
                                {
                                    Id = reg.IdRegistro,
                                    Hora = reg.Hora,
                                    Defecto = new DefectoVM
                                    {
                                        Id = reg.Defecto.IdDefecto,
                                        Descripcion = reg.Defecto.Descripcion,
                                        TipoDefecto = new TipoDefectoVM
                                        {
                                            Id = reg.Defecto.TipoDefecto.IdTipoDefecto,
                                            Descripcion = reg.Defecto.TipoDefecto.Defecto,
                                        }
                                    },
                                    TipoPie = new TipoPieVM
                                    {
                                        Id = reg.Pie.IdPie,
                                        Descripcion = reg.Pie.Pie1
                                    }
                                }).ToList();
            }
            return Ok(listRegistro);
        }
        [HttpGet]
        public IHttpActionResult GetRegistroPorJornada(int idJornada)
        {
            List<RegistroVM> listRegistro = new List<RegistroVM>();
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                listRegistro = (from reg in db.Registro
                                where reg.JornadaLaboral.IdJornadaLaboral == idJornada
                                select new RegistroVM
                                {
                                    Id = reg.IdRegistro,
                                    Hora = reg.Hora,
                                    Defecto = new DefectoVM
                                    {
                                        Id = reg.Defecto.IdDefecto,
                                        Descripcion = reg.Defecto.Descripcion,
                                        TipoDefecto = new TipoDefectoVM
                                        {
                                            Id = reg.Defecto.TipoDefecto.IdTipoDefecto,
                                            Descripcion = reg.Defecto.TipoDefecto.Defecto,
                                        }
                                    },
                                    TipoPie = new TipoPieVM
                                    {
                                        Id = reg.Pie.IdPie,
                                        Descripcion = reg.Pie.Pie1
                                    }
                                }).ToList();
            }
            return Ok(listRegistro);
        }
        [HttpPost]
        public IHttpActionResult AddRegistro(RegistroVM registro)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oRegistro = new Registro();
                oRegistro.Hora = registro.Hora;
                oRegistro.IdDefecto = registro.Defecto.Id;
                oRegistro.IdPie = registro.TipoPie.Id;
                oRegistro.IdJornadaLaboral = registro.IdJornadaLaboral;
                db.Registro.Add(oRegistro);
                db.SaveChanges();
            }
            return Ok("Creacion Exitosa");
        }
        [HttpDelete]
        public IHttpActionResult DeleteRegistro(RegistroVM reg)
        {
            using (ControlCalidadEntities1 db = new ControlCalidadEntities1())
            {
                var oRegistro = db.Registro.Find(reg.Id);
                db.Registro.Remove(oRegistro);
                db.SaveChanges();
            }
            return Ok("Eliminacion Exitosa");
        }
    }
}
