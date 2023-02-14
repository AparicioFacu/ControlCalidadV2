using ServicioVistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioModelo.Entidades
{
    public partial class Registro
    {
        public List<RegistroVM> RegistrosPorHora(List<RegistroVM> registros, string hora)
        {
            List<RegistroVM> listRegistroUltimaHora = new List<RegistroVM>();
            //string horaActual = fechaActual.ToShortTimeString();
            DateTime fechaActual = new DateTime();
            
            string horaInicio;
            string horaFinal;
            foreach (var reg in registros)
            {
                horaInicio = hora.Substring(0, 5);
                horaFinal = hora.Remove(0, 8);
                if(reg.Hora != null)
                {
                    fechaActual = (DateTime)reg.Hora;
                    string horaActual = fechaActual.ToShortTimeString();
                    if (EstaEntreLaHora(horaActual, horaInicio, horaFinal))
                    {
                        listRegistroUltimaHora.Add(reg);
                    }
                }               
            }
            return listRegistroUltimaHora;
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
    }
}
