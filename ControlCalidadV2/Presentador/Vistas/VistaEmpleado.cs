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
    public partial class VistaEmpleado : Form
    {
        PresentadorEmpleado _presentador = new PresentadorEmpleado();
        public VistaEmpleado()
        {
            InitializeComponent();
            btnModificar.Visible = false;
        }

        private void VistaEmpleado_Load(object sender, EventArgs e)
        {
            _presentador.CargarTabla(dgvEmpleado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presentador.CargarTabla(dgvEmpleado);
            txtDNI.Text = "";
            txtApeYNom.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            cbxRol.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            _presentador.EliminarEmpleado(dgvEmpleado, txtDNI.Text);
            txtDNI.Text = "";
            txtApeYNom.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            cbxRol.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            _presentador.ModificarEmpleado(dgvEmpleado, txtDNI.Text, txtApeYNom.Text,txtEmail.Text,txtContraseña.Text,cbxRol.Text);
            txtDNI.Text = "";
            txtApeYNom.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            cbxRol.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _presentador.CrearEmpleado(txtDNI.Text, txtApeYNom.Text, txtEmail.Text, cbxRol.Text,txtContraseña.Text,dgvEmpleado);
            txtDNI.Text = "";
            txtApeYNom.Text = "";
            txtEmail.Text = "";
            txtContraseña.Text = "";
            cbxRol.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _presentador.BuscarEmpleado(dgvEmpleado, txtDNI.Text, txtApeYNom, txtEmail, cbxRol,txtContraseña);
            if (txtDNI.Text.Length == 0)
            {
                btnGuardar.Visible = true;
                btnModificar.Visible = false;
            }
            if (txtDNI.Text.Length != 0)
            {
                btnGuardar.Visible = false;
                btnModificar.Visible = true;
            }
        }
    }
}
