using Presentador.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador.Vistas
{
    public partial class VistaColor : Form
    {
        PresentadorColor _presentador = new PresentadorColor();
        public VistaColor()
        {
            InitializeComponent();
            btnModificar.Visible = false;
        }

        private void VistaColor_Load(object sender, EventArgs e)
        {
            _presentador.CargarTabla(dgvColor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presentador.CargarTabla(dgvColor);
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _presentador.EliminarColor(dgvColor, txtCodigo.Text);
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _presentador.ModificarColor(dgvColor, txtCodigo.Text, txtDescripcion.Text);
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _presentador.CrearColor(txtCodigo.Text, txtDescripcion.Text, dgvColor);
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _presentador.BuscarColor(dgvColor, txtCodigo.Text, txtDescripcion);
            if (txtCodigo.Text.Length == 0)
            {
                btnGuardar.Visible = true;
                btnModificar.Visible = false;
            }
            if (txtCodigo.Text.Length != 0)
            {
                btnGuardar.Visible = false;
                btnModificar.Visible = true;
            }
        }
    }
}
