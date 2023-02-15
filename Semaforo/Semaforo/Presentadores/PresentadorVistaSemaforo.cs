using AccesoExterno.Adaptador;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo.Presentadores
{
    class PresentadorVistaSemaforo
    {
        public void GetDefectos(int idJornada,DataGridView tabla,string horaReinicio,Label totalDefectos)
        {            
            List<string> IntervaloHoras;   
            Get<Turno> getTurno = new Get<Turno>();
            Turno _turno = getTurno.GetTurnoPorJornadaLaboral(idJornada);
            IntervaloHoras = GeneraIntervaloHoras((DateTime)_turno.HoraInicio, (DateTime)_turno.HoraFin);
            
            Get<Registro> getRegistro = new Get<Registro>();
            List<Registro> listRegistro = getRegistro.GetRegistrosPorJornada(idJornada);
            List<Registro> listRegistroUltimaHora = new List<Registro>();
            DateTime fechaActual = new DateTime();
            
            //DateTime horaDateTime = new DateTime();
            string horaInicio;
            string horaFinal;
            if(horaReinicio != "")
            {
                foreach (var reg in listRegistro)
                {
                    DateTime regHora = reg.Hora;
                    int regHoras = int.Parse(regHora.ToString("HH"));
                    int regMinutos = int.Parse(regHora.ToString("mm"));
                    int regSegundos = int.Parse(regHora.ToString("ss"));
                    DateTime hora = DateTime.Parse(horaReinicio);
                    if (hora.TimeOfDay <= new TimeSpan(regHoras, regMinutos, regSegundos))
                    {
                        listRegistroUltimaHora.Add(reg);
                    }
                }
            }
            else
            {
                foreach (var reg in listRegistro)
                {
                    foreach (var inter in IntervaloHoras)
                    {
                        fechaActual = reg.Hora;
                        string horaActual = fechaActual.ToShortTimeString();
                        horaInicio = inter.Substring(0, 5);
                        horaFinal = inter.Remove(0, 8);
                        if (EstaEntreLaHora(horaActual, horaInicio, horaFinal))
                        {
                            listRegistroUltimaHora.Add(reg);
                        }
                    }

                }
            }           
            tabla.DataSource = (from registro in listRegistroUltimaHora
                                group registro by new
                                {
                                    registro.Defecto.Descripcion,
                                }
                                into g
                                orderby g.Count() descending
                                //orderby g.Key.Descripcion ascending
                                select new
                                {
                                    Defecto = g.Key.Descripcion,
                                    Total = g.Count()
                                }
                ).ToList();
            CalcularTotalDefectos(idJornada,totalDefectos);
        }
        public void ObtenerOrden(int idJornada,Label lblLimitesInferiorObservado, Label lblLimitesInferiorReproceso, Label lblLimitesSuperiorObservado, Label lblLimitesSuperiorReproceso)
        {
            Get<OrdenProduccion> getOrden = new Get<OrdenProduccion>();
            Get<JornadaLaboral> getJornada = new Get<JornadaLaboral>();
            OrdenProduccion orden = getOrden.GetOrdenPorJornadaLaboral((int)getJornada.GetjornadaLaboralPorId(idJornada).IdOrdenProduccion);
            lblLimitesInferiorObservado.Text = orden.Modelo.LimiteInferiorO.ToString();
            lblLimitesInferiorReproceso.Text = orden.Modelo.LimiteInferiorR.ToString();
            lblLimitesSuperiorObservado.Text = orden.Modelo.LimiteSuperiorO.ToString();
            lblLimitesSuperiorReproceso.Text = orden.Modelo.LimiteSuperiorR.ToString();

        }
        public static bool EstaEntreLaHora(string hActual, string hInicio, string hFinal)
        {

            var horaActual = DateTime.Parse(hActual);
            var horaInicio = DateTime.Parse(hInicio);
            var horaFinal = DateTime.Parse(hFinal);

            if ((horaActual <= horaFinal) && (horaActual >= horaInicio))
            {
                return true;
            }

            return false;
        }
        public List<string> GeneraIntervaloHoras(DateTime _horainicio, DateTime _horafin)
        {
            string _minutosHoraInicio = _horainicio.ToString("mm");
            string _segundosHoraInicio = _horainicio.ToString("ss");
            string _minutosHoraFin = _horainicio.ToString("mm");
            string _segundosHoraFin = _horainicio.ToString("ss");
            List<string> resultado = new List<string>();
            DateTime _horaactual = _horainicio;
            _horaactual = _horaactual.AddMinutes(-double.Parse(_minutosHoraInicio));
            _horaactual = _horaactual.AddSeconds(-double.Parse(_segundosHoraInicio));
            _horafin = _horafin.AddHours(1);
            _horafin = _horafin.AddMinutes(-double.Parse(_minutosHoraFin));
            _horafin = _horafin.AddSeconds(-double.Parse(_segundosHoraFin));

            while (_horaactual < _horafin)
            {
                resultado.Add(
                    _horaactual.ToShortTimeString() + " - " +
                    _horaactual.AddHours(1).ToShortTimeString());

                _horaactual = _horaactual.AddHours(1);
            }

            return resultado;
        }
        public void CalcularTotalDefectos(int idJornada, Label totalDefectos)
        {
            Get<Registro> getRegistro = new Get<Registro>();
            List<Registro> listRegistroIzquierdo = getRegistro.GetRegistrosPorOrdenProduccionPie(idJornada, 1);
            List<Registro> listRegistroDerecho = getRegistro.GetRegistrosPorOrdenProduccionPie(idJornada, 2);
            int total = listRegistroDerecho.Count() + listRegistroIzquierdo.Count();
            totalDefectos.Text = total.ToString();
        }
    }
}
