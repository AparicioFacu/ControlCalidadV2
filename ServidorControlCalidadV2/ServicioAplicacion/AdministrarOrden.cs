using ServicioDatos;
using ServicioModelo.Entidades;
using ServicioVistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioAplicacion
{
    public class AdministrarOrden
    {
        ControlCalidadEntities1 db = new ControlCalidadEntities1();
        public void PostOrden(OrdenProduccionVM orden)
        {
            var ordenProduccion = new OrdenProduccion();
            ordenProduccion.Numero = orden.Numero;
            ordenProduccion.FechaInicio = orden.FechaInicio;
            ordenProduccion.IdEstadoOrden = 1;
            ordenProduccion.IdColor = GetColor(orden.ColorV2);
            ordenProduccion.IdModelo = GetModelo(orden.ModeloV2);
            ordenProduccion.IdLinea = GetLinea(orden.LineaV2);
            ordenProduccion.IdEmpleado = GetEmpleado(orden.EmpleadoV2);
            db.OrdenProduccion.Add(ordenProduccion);
            AgregarJornadaLaborales(orden);
            db.SaveChanges();
        }
        public void PutOrden(OrdenProduccionVM orden)
        {
            var oOrdenProduccion = db.OrdenProduccion.Find(orden.Id);
            oOrdenProduccion.Numero = orden.Numero;
            oOrdenProduccion.FechaInicio = orden.FechaInicio;
            oOrdenProduccion.IdColor = GetColor(orden.ColorV2);
            oOrdenProduccion.IdModelo = GetModelo(orden.ModeloV2);
            oOrdenProduccion.IdLinea = GetLinea(orden.LineaV2);
            oOrdenProduccion.IdEmpleado = GetEmpleado(orden.EmpleadoV2);
            oOrdenProduccion.IdEstadoOrden = oOrdenProduccion.CambiarEstado(orden.EstadoOrden.Descripcion);
            db.Entry(oOrdenProduccion).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void AgregarJornadaLaborales(OrdenProduccionVM orden)
        {
            //JornadaLaboral
            string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            JornadaLaboral jornadaLaboral = new JornadaLaboral();
            jornadaLaboral.FechaInicio = DateTime.Parse(fechaHoy);
            jornadaLaboral.IdEmpleado = GetEmpleado(orden.EmpleadoV2);
            //Turno
            Turno turno = new Turno();
            turno.HorarioInicio = DateTime.Parse(fechaHoy);
            DateTime today = DateTime.Parse(fechaHoy);
            TimeSpan duration = new TimeSpan(0, 6, 0, 0);
            turno.HorarioFin = today.Add(duration);
            jornadaLaboral.Turno = new List<Turno>();
            jornadaLaboral.Turno.Add(turno);

            //Asignar a la orden las jornada
            foreach (var ord in db.OrdenProduccion)
            {
                if (ord.Numero.Equals(orden.Numero))
                {
                    jornadaLaboral.IdOrdenProduccion = ord.IdOrdenProduccion;
                }
            }
            db.JornadaLaboral.Add(jornadaLaboral);
            db.SaveChanges();
        }
        public void AgregarDefecto(RegistroVM registro)
        {
            var oRegistro = new Registro();
            oRegistro.Hora = registro.Hora;
            oRegistro.IdDefecto = registro.Defecto.Id;
            oRegistro.IdPie = registro.TipoPie.Id;
            oRegistro.IdJornadaLaboral = registro.IdJornadaLaboral;
            db.Registro.Add(oRegistro);
            db.SaveChanges();
        }
        public int GetColor(string color)
        {
            //db.Color.Any(c => c.IdColor == color);
            foreach (var col in db.Color)
            {
                if (col.Descripcion.Equals(color))
                {
                    return col.IdColor;
                }
            }
            return 0;
        }
        public int GetModelo(string modelo)
        {
            foreach (var mod in db.Modelo)
            {
                if (mod.Denominacion.Equals(modelo))
                {
                    return mod.IdModelo;

                }
            }
            return 0;
        }
        public int GetLinea(string linea)
        {                         
                foreach (var lin in db.Linea)
                {
                    if (lin.Numero.Equals(int.Parse(linea)))
                    {
                        foreach (var orden in db.OrdenProduccion)
                        {
                            if (orden.IdLinea == lin.IdLinea)
                            {
                                return 0;
                            }
                            else
                            {
                                return lin.IdLinea;
                            }
                        }
                    }
                }
            throw new InvalidOperationException();
        }
        public int GetEmpleado(string empleado)
        {
            foreach (var emp in db.Empleado)
            {
                if (emp.ApeYNom.Equals(empleado))
                {
                    return emp.IdEmpleado;
                }
            }
            return 0;
        }
    }
}
