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
    public partial class VistaModelos : Form
    {
        PresentadorModelo _presentador = new PresentadorModelo();
        public VistaModelos()
        {
            InitializeComponent();
            btnModificar.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.CrearModelo(txtSKU.Text,txtDenominacion.Text,txtInferiorObservado.Text,txtInferiorReproceso.Text,txtSuperiorObservado.Text,txtSuperiorReproceso.Text,dgvModelos);
            txtSKU.Text = "";
            txtDenominacion.Text = "";
            txtInferiorObservado.Text = "";
            txtInferiorReproceso.Text = "";
            txtSuperiorObservado.Text = "";
            txtSuperiorReproceso.Text = "";
        }

        private void VistaModelos_Load(object sender, EventArgs e)
        {
            _presentador.CargarTabla(dgvModelos);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _presentador.BuscarModelo(dgvModelos, txtSKU.Text, txtDenominacion,txtInferiorObservado,txtInferiorReproceso,txtSuperiorObservado,txtSuperiorReproceso);
            if(txtSKU.Text.Length == 0)
            {
                btnGuardar.Visible = true;
                btnModificar.Visible = false;
            }
            if(txtSKU.Text.Length != 0)
            {
                btnGuardar.Visible = false;
                btnModificar.Visible = true;               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presentador.CargarTabla(dgvModelos);
            txtSKU.Text = "";
            txtDenominacion.Text = "";
            txtInferiorObservado.Text = "";
            txtInferiorReproceso.Text = "";
            txtSuperiorObservado.Text = "";
            txtSuperiorReproceso.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _presentador.EliminarModelo(dgvModelos,txtSKU.Text);
            txtSKU.Text = "";
            txtDenominacion.Text = "";
            txtInferiorObservado.Text = "";
            txtInferiorReproceso.Text = "";
            txtSuperiorObservado.Text = "";
            txtSuperiorReproceso.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _presentador.ModificarModelo(dgvModelos,txtSKU.Text ,txtDenominacion.Text,
            txtInferiorObservado.Text,
            txtInferiorReproceso.Text,
            txtSuperiorObservado.Text,
            txtSuperiorReproceso.Text);
            txtSKU.Text = "";
            txtDenominacion.Text = "";
            txtInferiorObservado.Text = "";
            txtInferiorReproceso.Text = "";
            txtSuperiorObservado.Text = "";
            txtSuperiorReproceso.Text = "";
        }
    }
}
