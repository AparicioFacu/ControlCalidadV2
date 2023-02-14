using ServicioVistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioModelo.Entidades
{
    public partial class OrdenProduccion
    {
        public void AgregarJornadaLaborales(List<JornadaLaboralVM> jornadas, OrdenProduccion orden)
        {
            foreach (var jor in jornadas)
            {
                var oJornada = new JornadaLaboral();
                oJornada.FechaInicio = jor.FechaInicio;
                oJornada.FechaFinal = jor.FechaFin;
                oJornada.CantParPrimera = jor.CParPrimera;
                oJornada.CantParSegunda = jor.CParSegunda;
                oJornada.Empleado = new Empleado
                {
                    IdEmpleado = (int)jor.Empleado.Id,
                    ApeYNom = jor.Empleado.ApeYNom,
                    Email = jor.Empleado.Email,
                    DNI = jor.Empleado.Dni,
                    Rol = jor.Empleado.Rol
                };
                //oJornada.Registro = new Registro
                //{
                //    IdRegistro = (int)jor.Registro.Id,
                //    Hora = jor.Registro.Hora,
                //    Defecto = new Defecto
                //    {
                //        Descripcion = jor.Registro.Defecto.Descripcion,
                //        IdDefecto = (int)jor.Registro.Defecto.Id,
                //        TipoDefecto = new TipoDefecto
                //        {
                //            IdTipoDefecto = (int)jor.Registro.Defecto.TipoDefecto.Id,
                //            Defecto = jor.Registro.Defecto.TipoDefecto.Descripcion
                //        }
                //    },                    
                //    Pie = new Pie
                //    {
                //        IdPie = (int)jor.Registro.TipoPie.Id,
                //        Pie1 = jor.Registro.TipoPie.Descripcion
                //    }
                //};
                //oJornada.Turno = new Turno
                //{
                //    Descripcion = jor.Turno.Descripcion,
                //    HorarioFin = jor.Turno.HoraFin,
                //    HorarioInicio = jor.Turno.HoraInicio,
                //    IdTurno = (int)jor.Turno.Id
                //};
                //oJornada.IdTurno = jor.Turnos
                oJornada.IdOrdenProduccion = orden.IdOrdenProduccion;
                JornadaLaboral.Add(oJornada);
            }
        }
        public List<LineaVM> ConsultarLineaDisponible(List<OrdenProduccion> ordenes,List<LineaVM> lineas)
        {
            foreach (var orden in ordenes)
            {
                foreach (var lin in lineas)
                {
                    if(orden.IdLinea == lin.Id)
                    {
                        List<LineaVM> lineas2 = new List<LineaVM>();
                        lineas2 = (from linea in lineas
                                    where orden.IdLinea != lin.Id
                                   select new LineaVM
                                     {
                                         Id = (int)linea.Id,
                                         Numero = linea.Numero
                                     }).ToList();
                        return lineas2;
                    }
                }
            }
            return null;
        }
        public int CambiarEstado(string estadoDescripcion)
        {
            if(estadoDescripcion== "Iniciada")
            {
                return 1;
            }
            if (estadoDescripcion == "Pausada")
            {
                return 2;
            }
            if (estadoDescripcion == "Finalizada")
            {
                return 3;
            }
            return 0;
        }
    }
}
