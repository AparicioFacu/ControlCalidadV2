using ServicioVistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioModelo.Entidades
{
    public partial class JornadaLaboral
    {
        public void AgregarTurno(List<TurnoVM> turnos, JornadaLaboral turno)
        {
            foreach (var tur in turnos)
            {
                var oTurno = new Turno();
                oTurno.HorarioInicio = tur.HoraInicio;
                oTurno.HorarioFin = tur.HoraFin;
                oTurno.IdJornadaLaboral = turno.IdJornadaLaboral;
                Turno.Add(oTurno);
            }
        }
        //public void AgregarRegsitro(List<RegistroVM> registros, JornadaLaboral jornada)
        //{
        //    foreach (var reg in registros)
        //    {
        //        var oRegistro = new Registro();
        //        oRegistro.Hora = reg.Hora;
        //        oRegistro.IdDefecto = reg.Defecto.Id;
        //        oRegistro.IdPie = reg.TipoPie.Id;
        //        oRegistro.IdJornadaLaboral = jornada.IdJornadaLaboral;                
        //        Registro.Add(oRegistro);
        //    }
        //}
    }
}
