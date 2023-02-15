using AccesoExterno.Adaptadores;
using ControlCalidadV2;
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
    public partial class VistaOrdenProduccion : Form
    {
        PresentadorOrdenProduccion _presentador = new PresentadorOrdenProduccion();       
        public VistaOrdenProduccion()
        {
            InitializeComponent();           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VistaOrdenProduccion_Load(object sender, EventArgs e)
        {
            _presentador.GetColores(cbxColor);
            _presentador.GetModelos(cbxModelo);
            _presentador.GetLineas(cbxLinea);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _presentador.CrearOrden(txtNumero.Text, cbxColor.Text,cbxLinea.Text,cbxModelo.Text);
            txtNumero.Text = "";
            //cbxColor.Items.Clear();
            //cbxLinea.Items.Clear();
            //cbxModelo.Items.Clear();

        }
    }
}
