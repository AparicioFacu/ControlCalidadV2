using ServicioVistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioModelo.Entidades
{
    public partial class Linea
    {
        public List<LineaVM> ObtenerLineasDisponibles(List<OrdenProduccion> oOrdenes, List<LineaVM> lineas,int idEmpleado)
        {
            int _id;
            List<OrdenProduccion> ordenes = oOrdenes;
            List<OrdenProduccion> ordenesEmpleado = new List<OrdenProduccion>();          
            foreach (var ord in ordenes)
            {
                if (ord.IdEmpleado == idEmpleado)
                {
                    ordenesEmpleado.Add(ord);
                }
            }
            if(ordenesEmpleado != null)
            {
                foreach (var ordEmp in ordenesEmpleado)
                {
                    if (ordEmp.EstadoOrden.Estado.Equals("Iniciada"))
                    {
                        _id = ordEmp.Linea.IdLinea;
                        _id--;
                        lineas.RemoveAt((int)_id);
                        return lineas;
                    }
                }
            }
            return lineas;
        }
    }
}
