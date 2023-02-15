using AccesoExterno.Adaptadores;
using Presentador.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador.Vistas
{
    public partial class MenuInicio : Form
    {
        Form activarForm = null;        
        public static string nombreEmpleado;
        public static string rolEmpleado;
        public static int idEmpleado;
        //Socket
        private Thread _rec;
        public Dictionary<string, VistaAdministrarOrden> di = new Dictionary<string, VistaAdministrarOrden>();
        public ConexionSocket _con;
        //
        public MenuInicio(string nombre,string rol,int id)
        {
            InitializeComponent();           
            MenuInicio.nombreEmpleado = nombre;
            MenuInicio.rolEmpleado = rol;
            MenuInicio.idEmpleado = id;
            PersonalizarMenu();
            PresentadorOrdenProduccion _presentador = new PresentadorOrdenProduccion(nombre,id);
            //Socket
            Control.CheckForIllegalCrossThreadCalls = false;
            _con = new ConexionSocket();
            _con.Conectar();
            _rec = new Thread(Recibir);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuProducto);
        }
        private void btnListaProducto_Click_1(object sender, EventArgs e)
        {
            //abriFormulario<ListaProducto>();            
            OcultarSubMenu();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            abriFormulario<VistaOrdenProduccion>();
            //abrirVistar(new VistaProducto(0));
            OcultarSubMenu();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuVenta);
        }

        private void btnListaVenta_Click(object sender, EventArgs e)
        {
            ///Codigo
            abriFormulario<VistaEmpleado>();
            OcultarSubMenu();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            //abriFormulario<VistaVenta>();
            //abrirVistar(new VistaVenta());
            OcultarSubMenu();
        }

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuCliente);
        }

        private void btnListaComprobantes_Click(object sender, EventArgs e)
        {
            ///Codigo
            OcultarSubMenu();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panel1);
        }
        private void btnAddModelos_Click(object sender, EventArgs e)
        {
            abriFormulario<VistaModelos>();
            OcultarSubMenu();           
        }
        private void btnAdministrarOrden_Click(object sender, EventArgs e)
        {
            //Socket
            _con.Send("ControlCalidad");
            string msg = _con.Receive();
            if (msg == "conectado")
            {
                VistaAdministrarOrden form;
                form = panelForm.Controls.OfType<VistaAdministrarOrden>().FirstOrDefault();
                if (form == null)
                {
                    form = new VistaAdministrarOrden("ControlCalidad", di, _con, idEmpleado);
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    panelForm.Controls.Add(form);
                    panelForm.Tag = form;
                    form.Show();
                    di.Add("Monitor1", form);
                    _rec.Start();
                    form.BringToFront();
                }
                else
                {
                    form.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("error conexion");
            }
        }
        //Socket
        private void Recibir()
        {
            while (true)
            {
                string msg = _con.Receive();
                string[] todo = msg.Split('-');
                VistaAdministrarOrden vista = di[todo[0]];
                vista.Agregar(todo[0] + ": " + todo[1]);
            }
        }

        /// <summary>
        /// Edicion Vista
        /// </summary>

        void PersonalizarMenu()
        {
            panelSubMenuProducto.Visible = false;
            panelSubMenuVenta.Visible = false;
            panelSubMenuCliente.Visible = false;
            panel1.Visible = false;

            lblNombreEmepleado.Text = nombreEmpleado;
            lblRolEmpleado.Text = rolEmpleado;
        }
        void OcultarSubMenu()
        {
            if (panelSubMenuProducto.Visible == true)
            {
                panelSubMenuProducto.Visible = false;
            }
            if (panelSubMenuVenta.Visible == true)
            {
                panelSubMenuVenta.Visible = false;
            }
            if (panelSubMenuCliente.Visible == true)
            {
                panelSubMenuCliente.Visible = false;
            }
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
        }
        void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        void abrirVistar(Form formHijo)
        {

            if (activarForm != null)
            {
                activarForm.Close();
            }
            activarForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelForm.Controls.Add(formHijo);
            panelForm.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        void abriFormulario<Miform>() where Miform : Form, new()
        {
            Form formulario;
            formulario = panelForm.Controls.OfType<Miform>().FirstOrDefault();
            if(formulario == null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelForm.Controls.Add(formulario);
                panelForm.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            abriFormulario<VistaColor>();
            OcultarSubMenu();
        }
    }
}
