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
            string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            OrdenProduccion ordenProduccion = new OrdenProduccion();
            ordenProduccion.Numero = numero;
            ordenProduccion.FechaInicio = DateTime.Parse(fechaHoy);
            ordenProduccion.ColorV2 = color;
            ordenProduccion.ModeloV2 = modelo;
            ordenProduccion.LineaV2 = linea;
            ordenProduccion.EmpleadoV2 = nombreEmpleado;
            post.PostOrdenProduccion(ordenProduccion);
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
    }
}
