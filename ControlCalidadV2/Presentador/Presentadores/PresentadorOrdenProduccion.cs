using AccesoExterno.Adaptadores;
using ControlCalidadV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador.Presentadores
{
    public class PresentadorOrdenProduccion
    {
        public static string nombreEmpleado;
        public static int idEmpleado;
        public PresentadorOrdenProduccion()
        {

        }
        public PresentadorOrdenProduccion(string nombre,int id)
        {
            PresentadorOrdenProduccion.nombreEmpleado = nombre;
            PresentadorOrdenProduccion.idEmpleado = id;
        }

        public void CrearOrden(string numero, string color, string linea, string modelo)
        {
            Post post = new Post();
            OrdenProduccion ordenProduccion = new OrdenProduccion();
            ordenProduccion.Numero = numero;
            ordenProduccion.FechaInicio = DateTime.Now;
            ordenProduccion.Color = new Color
            {
                Id = GetColor(color)
            };
            ordenProduccion.Modelo = new Modelo
            {
                Id = GetModelo(modelo)
            };
            ordenProduccion.Linea = new Linea
            {
                Id = GetLinea(linea)
            };
            ordenProduccion.Empleado = new Empleado
            {
                Id = GetEmpleado(nombreEmpleado)
            };                                 
            ////Jornadas
            //JornadaLaboral jornadaLaboral = new JornadaLaboral();
            //jornadaLaboral.FechaInicio = DateTime.Now;
            //jornadaLaboral.Empleado = new Empleado
            //{
            //    Id = GetEmpleado(nombreEmpleado)
            //};
            //ordenProduccion.JornadasLaborales = new List<JornadaLaboral>();
            //ordenProduccion.JornadasLaborales.Add(jornadaLaboral);

            post.PostOrdenProduccion(ordenProduccion);
            AgregarJornadaLaborales(ordenProduccion);
        }
        public void AgregarJornadaLaborales(OrdenProduccion orden)
        {
            Post post = new Post();
            //JornadaLaboral
            JornadaLaboral jornadaLaboral = new JornadaLaboral();
            jornadaLaboral.FechaInicio = DateTime.Now;
            jornadaLaboral.Empleado = new Empleado
            {
                Id = GetEmpleado(nombreEmpleado)
            };
            //Turno
            Turno turno = new Turno();
            turno.HoraInicio = DateTime.Now;
            DateTime today = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 6, 0, 0);
            turno.HoraFin = today.Add(duration);
            jornadaLaboral.Turnos = new List<Turno>();
            jornadaLaboral.Turnos.Add(turno);

            //Asignar a la orden las jornada            
            Get<OrdenProduccion> getOrdenProduccion = new Get<OrdenProduccion>();
            OrdenProduccion oOrden = getOrdenProduccion.GetOrden(orden.Numero);
            jornadaLaboral.IdOrdenProduccion = oOrden.Id;

            List<JornadaLaboral> listJornada = new List<JornadaLaboral>();
            listJornada.Add(jornadaLaboral);
            orden.JornadasLaborales = listJornada;
            foreach (var jor in orden.JornadasLaborales)
            {
                post.PostJornadaLaboral(jor);
            }
        }
        public void GetColores(ComboBox cbxColor)
        {
            Get<Color> _colores = new Get<Color>();
            cbxColor.DataSource = _colores.GetColores();
            cbxColor.ValueMember = "Id";
            cbxColor.DisplayMember = "Descripcion";
        }
        public void GetModelos(ComboBox cbxModelo)
        {
            Get<Modelo> _modelos = new Get<Modelo>();
            cbxModelo.DataSource = _modelos.GetModelos();
            cbxModelo.ValueMember = "Id";
            cbxModelo.DisplayMember = "Denominacion";
        }
        public void GetLineas(ComboBox cbxLinea)
        {
            Get<Linea> _lineas = new Get<Linea>();
            cbxLinea.DataSource = _lineas.GetLineas(idEmpleado);
            cbxLinea.ValueMember = "Id";
            cbxLinea.DisplayMember = "Numero";
        }
        public int GetEmpleado(string empleado)
        {
            Get<Empleado> _empleados = new Get<Empleado>();
            foreach (var emp in _empleados.GetEmpleados())
            {
                if (emp.ApeYNom.Equals(empleado))
                {
                    return emp.Id;
                }
            }
            return 0;
        }
        public int GetColor(string color)
        {
            Get<Color> _colores = new Get<Color>();
            foreach (var col in _colores.GetColores())
            {
                if (col.Descripcion.Equals(color))
                {
                    return col.Id;
                }
            }
            return 0;
        }
        public int GetModelo(string modelo)
        {
            Get<Modelo> _modelos = new Get<Modelo>();
            foreach (var mod in _modelos.GetModelos())
            {
                if (mod.Denominacion.Equals(modelo))
                {
                    return mod.Id;

                }
            }
            return 0;
        }
        public int GetLinea(string linea)
        {
            Get<Linea> _lineas = new Get<Linea>();
            foreach (var lin in _lineas.GetLineas(idEmpleado))
            {
                if (lin.Numero.Equals(int.Parse(linea)))
                {
                    return lin.Id;

                }
            }
            return 0;
        }

    }
}
