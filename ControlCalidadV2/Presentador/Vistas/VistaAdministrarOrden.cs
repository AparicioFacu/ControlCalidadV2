using AccesoExterno.Adaptadores;
using Presentador.Presentadores;
using Presentador.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador.Vistas
{
    public partial class VistaAdministrarOrden : Form
    {
        PresentadorAdministrarOrden _presentador = new PresentadorAdministrarOrden();
        string _color;
        int _tipoDefecto;
        string controlCalidad;
        int idEmpleado;
        ConexionSocket con;
        Dictionary<string, VistaAdministrarOrden> di;
        public VistaAdministrarOrden(string controlCalidad, Dictionary<string, VistaAdministrarOrden> di, ConexionSocket con,int idEmpleado)
        {            
            InitializeComponent();           
            btnPausarOP.Visible = false;
            btnRenaudarOP.Visible = false;
            btnFinalizarOP.Visible = false;
            btnDesvincularEmpleado.Visible = false;
            btnVincularEmpleado.Visible = false;
            this.controlCalidad = controlCalidad;
            this.di = di;
            this.con = con;
            this.idEmpleado = idEmpleado;
        }
        //Socket  
        public void Agregar(string mensaje)
        {
            string remove = mensaje.Remove(0, 10);
            this._color = remove.Substring(0, remove.Length - 1);//recibo color
            this._tipoDefecto = int.Parse(mensaje.Remove(0, mensaje.Length - 1));
        }
        private void btnConsultarSemaforo_Click(object sender, EventArgs e)
        {
            string texto = _presentador.ConectarSocket();
            this.con.Send("Monitor1" + "-" + texto); // enviar id           
        }
        //
        private void VistaAdministrarOrden_Load(object sender, EventArgs e)
        {            
            
            _presentador.CargarTablaOrdenProduccion(dgvOrdenProducciones);            
            _presentador.GetTipoPie(cbxPie);          

            DataGridViewButtonColumn btnEliminarIzquieda = new DataGridViewButtonColumn();
            btnEliminarIzquieda.Name = "X";
            dgvPieIzquierdo.Columns.Add(btnEliminarIzquieda);

            DataGridViewButtonColumn btnEliminarDerecha = new DataGridViewButtonColumn();
            btnEliminarDerecha.Name = "X";
            dgvPieDerecho.Columns.Add(btnEliminarDerecha);

        }

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            _presentador.BuscarOrdenProduccion(dgvOrdenProducciones,txtBuscarOrden.Text);
        }
        private void dgvOrdenProducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                DateTime fecha;
                DataGridViewRow fila = dgvOrdenProducciones.SelectedRows[0] as DataGridViewRow;
                fecha = DateTime.Parse(fila.Cells["InicioJornada"].Value.ToString());             
                _presentador.GetTipoDefectos(cbxTipoDefecto);
                _presentador.GetTurnos(cbxTurno, fecha,lblTotalPrimera);               
            }
            catch (Exception)
            {

            }
            VisibleBotonEstado();
            VisibleBotonEmpleado();
        }

        private void cbxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoDefecto.Text == "Observado")
            {
                _presentador.GetDefectos(dgvPieIzquierdo, dgvPieDerecho, cbxTurno.Text, cbxTipoDefecto.Text);
                _presentador.CalcularTotalDefectosPorHora(cbxTurno.Text, lblTotalIzquierdoPorHora, lblTotalDerechoPorHora);
                _presentador.CalcularTotalDefectos(lblTotalIzquierda, lblTotalDerecho);
                _presentador.CalcularTotalPrimera(lblTotalPrimera);
            }
            else if (cbxTipoDefecto.Text == "Reproceso")
            {
                _presentador.GetDefectos(dgvPieIzquierdo, dgvPieDerecho, cbxTurno.Text, cbxTipoDefecto.Text);
                _presentador.CalcularTotalDefectosPorHora(cbxTurno.Text, lblTotalIzquierdoPorHora, lblTotalDerechoPorHora);
                _presentador.CalcularTotalDefectos(lblTotalIzquierda, lblTotalDerecho);
                _presentador.CalcularTotalPrimera(lblTotalPrimera);
            }
        }

        private void dgvPieIzquierdo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPieIzquierdo.Columns[e.ColumnIndex].Name == "X" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPieIzquierdo.Rows[e.RowIndex].Cells["X"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Delete.ico");/////Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvPieIzquierdo.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvPieIzquierdo.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }            
        }

        private void dgvPieDerecho_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvPieDerecho.Columns[e.ColumnIndex].Name == "X" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvPieDerecho.Rows[e.RowIndex].Cells["X"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Delete.ico");/////Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dgvPieDerecho.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.dgvPieDerecho.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
        }

        private void cbxTipoDefecto_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presentador.GetDefectoCbx(cbxDefecto, cbxTipoDefecto.Text,dgvPieIzquierdo, dgvPieDerecho,cbxTurno.Text);
        }

        private void btnAgregarDefecto_Click(object sender, EventArgs e)
        {           
            _presentador.AgregarDefecto(cbxTurno.Text,cbxDefecto.Text,cbxPie.Text,cbxTipoDefecto.Text,dgvPieIzquierdo,dgvPieDerecho);
            _presentador.CalcularTotalDefectosPorHora(cbxTurno.Text,lblTotalIzquierdoPorHora,lblTotalDerechoPorHora);
            _presentador.CalcularTotalDefectos(lblTotalIzquierda, lblTotalDerecho);
            _presentador.CalcularTotalPrimera(lblTotalPrimera);
            string texto = _presentador.ConectarSocket();
            this.con.Send("Monitor1" + "-" + texto); // enviar id   
        }

        private void dgvPieIzquierdo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPieIzquierdo.Columns[e.ColumnIndex].Name == "X")
            {
                string _defecto;
                _defecto = dgvPieIzquierdo.CurrentRow.Cells[1].Value?.ToString();
                _presentador.EliminarDefectoIzquierdo(cbxTurno.Text,_defecto,cbxTipoDefecto.Text, dgvPieIzquierdo, dgvPieDerecho);
                _presentador.CalcularTotalDefectosPorHora(cbxTurno.Text, lblTotalIzquierdoPorHora, lblTotalDerechoPorHora);
                _presentador.CalcularTotalDefectos(lblTotalIzquierda, lblTotalDerecho);
                _presentador.CalcularTotalPrimera(lblTotalPrimera);
            }
        }
        private void dgvPieDerecho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPieDerecho.Columns[e.ColumnIndex].Name == "X")
            {
                string _defecto;
                _defecto = dgvPieDerecho.CurrentRow.Cells[1].Value?.ToString();
                _presentador.EliminarDefectoDerecho(cbxTurno.Text, _defecto, cbxTipoDefecto.Text, dgvPieIzquierdo, dgvPieDerecho);
                _presentador.CalcularTotalDefectosPorHora(cbxTurno.Text, lblTotalIzquierdoPorHora, lblTotalDerechoPorHora);
                _presentador.CalcularTotalDefectos(lblTotalIzquierda, lblTotalDerecho);
                _presentador.CalcularTotalPrimera(lblTotalPrimera);
            }
        }
        private void btnMasPrimera_Click(object sender, EventArgs e)
        {            
            _presentador.SumarParPrimera();
            _presentador.CalcularTotalPrimera(lblTotalPrimera);
        }

        private void btnMenosPrimera_Click(object sender, EventArgs e)
        {           
            _presentador.RestarParPrimera(lblTotalPrimera);
            _presentador.CalcularTotalPrimera(lblTotalPrimera);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string numero;
                DataGridViewRow fila = dgvOrdenProducciones.SelectedRows[0] as DataGridViewRow;
                numero = fila.Cells["Numero"].Value.ToString();
                _presentador.PausarOP(numero, dgvOrdenProducciones, _color, _tipoDefecto);
            }
            catch (Exception)
            {


            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string numero;
                DataGridViewRow fila = dgvOrdenProducciones.SelectedRows[0] as DataGridViewRow;
                numero = fila.Cells["Numero"].Value.ToString();
                _presentador.FinalizarOP(numero, dgvOrdenProducciones);
            }
            catch (Exception)
            {

            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string numero;
                DataGridViewRow fila = dgvOrdenProducciones.SelectedRows[0] as DataGridViewRow;
                numero = fila.Cells["Numero"].Value.ToString();
                _presentador.RenaudarOP(numero, dgvOrdenProducciones);
                string texto = _presentador.ConectarSocket();
                this.con.Send("Monitor1" + "-" + texto); // enviar id y fecha de reinicio   
            }
            catch (Exception)
            {

            }
            
        }
        private void btnDesvincularEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string numero;
                string estado;
                DataGridViewRow fila = dgvOrdenProducciones.SelectedRows[0] as DataGridViewRow;
                estado = fila.Cells["Estado"].Value.ToString();
                _presentador.DesvincularEmpleado(estado, dgvOrdenProducciones);
            }
            catch (Exception)
            {

            }
            
        }
        public void VisibleBotonEstado()
        {
            try
            {
                string estado;
                DataGridViewRow fila1 = dgvOrdenProducciones.SelectedRows[0] as DataGridViewRow;
                estado = fila1.Cells["Estado"].Value.ToString();
                if (estado == "Iniciada")
                {
                    btnPausarOP.Visible = true;
                    btnFinalizarOP.Visible = true;
                    btnRenaudarOP.Visible = false;
                }
                if (estado == "Pausada")
                {
                    btnRenaudarOP.Visible = true;
                    btnFinalizarOP.Visible = true;
                    btnPausarOP.Visible = false;
                }
                if (estado == "Finalizada")
                {
                    btnRenaudarOP.Visible = true;
                    btnFinalizarOP.Visible = false;
                    btnPausarOP.Visible = false;
                }
            }
            catch (Exception)
            {

            }
            
        }
        public void VisibleBotonEmpleado()
        {
            try
            {
                string empleado;
                DataGridViewRow fila1 = dgvOrdenProducciones.SelectedRows[0] as DataGridViewRow;
                empleado = fila1.Cells["Empleado"].Value.ToString();
                if (empleado == "Sin Empleado")
                {
                    btnVincularEmpleado.Visible = true;
                    btnDesvincularEmpleado.Visible = false;
                }
                else
                {
                    btnDesvincularEmpleado.Visible = true;
                    btnVincularEmpleado.Visible = false;
                }
            }
            catch (Exception)
            {

            }
                   
        }
        private void btnVincularEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string estado;
                DataGridViewRow fila = dgvOrdenProducciones.SelectedRows[0] as DataGridViewRow;
                estado = fila.Cells["Estado"].Value.ToString();
                _presentador.VincularEmpleado(estado, idEmpleado, dgvOrdenProducciones);
            }
            catch (Exception)
            {

            }

        }
    }
}
