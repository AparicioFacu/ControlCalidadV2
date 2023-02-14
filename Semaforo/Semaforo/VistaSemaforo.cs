using AccesoExterno.Adaptador;
using Dominio;
using Semaforo.Presentadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semaforo
{
    public partial class VistaSemaforo : Form
    {
        string nick;    
        Conexion con;
        string _color;
        string _tipoDefecto;
        Dictionary<string, VistaSemaforo> di;
        PresentadorVistaSemaforo _presentador = new PresentadorVistaSemaforo();
        public VistaSemaforo(string nick, Dictionary<string, VistaSemaforo> di, Conexion con)
        {
            InitializeComponent();
            this.nick = nick;
            this.di = di;
            this.con = con;            
        }
        public void Agregar(string mensaje)//recibe el mensaje
        {
            string id = mensaje[16].ToString();
            string horaReincio = mensaje.Remove(0, 17);
            _presentador.ObtenerOrden(int.Parse(id),lblLimitesInferiorObservado, lblLimitesInferiorReproceso, lblLimitesSuperiorObservado, lblLimitesSuperiorReproceso);
            _presentador.GetDefectos(int.Parse(id),dgvDefectos,horaReincio,lblTotalDefectos);
            CalcularDefectos();
        }

        private void VistaSemaforo_Load(object sender, EventArgs e)
        {
            
        }

        public void CalcularDefectos()
        {
            int sumaObservado = 0;
            int sumaReproceso = 0;
            Get<TipoDefecto> getDefecto = new Get<TipoDefecto>();
            List<TipoDefecto> listDefectoObservado = getDefecto.GetDefecto("Observado");
            List<TipoDefecto> listDefectoReproceso = getDefecto.GetDefecto("Reproceso");
            foreach (DataGridViewRow row in dgvDefectos.Rows)
            {
                foreach (var tipoDefecto in listDefectoObservado)
                {
                    if (row.Cells[0].Value.Equals(tipoDefecto.Descripcion))
                    {
                        if (row.Cells[1].Value != null)
                            sumaObservado += (Int32)row.Cells[1].Value;
                    }                   
                }
                foreach (var tipoDefecto in listDefectoReproceso)
                {
                    if (row.Cells[0].Value.Equals(tipoDefecto.Descripcion))
                    {
                        if (row.Cells[1].Value != null)
                            sumaReproceso += (Int32)row.Cells[1].Value;
                    }
                }
            }
            CambiarColorSemaforo(sumaObservado, sumaReproceso);
            
        }
        public void CambiarColorSemaforo(int sumaObservado, int sumaReproceso)
        {           
            
            if (sumaObservado < int.Parse(lblLimitesInferiorObservado.Text))
            {
                btnSemaforo.BackColor = System.Drawing.Color.Green;
                //this.con.Send("ControlCalidad" + "-" + SemaforoEnum.Verde.ToString() + "1"); // enviar semaforo  ;               
                //return;
            }
            if (sumaObservado >= int.Parse(lblLimitesInferiorObservado.Text) && sumaObservado < int.Parse(lblLimitesSuperiorObservado.Text))
            {
                btnSemaforo.BackColor = System.Drawing.Color.Yellow;
                //this.con.Send("ControlCalidad" + "-" + SemaforoEnum.Amarillo.ToString() + "1"); // enviar semaforo   
                //return;
            }
            if (sumaObservado >= int.Parse(lblLimitesSuperiorObservado.Text))
            {
                btnSemaforo.BackColor = System.Drawing.Color.Red;
                this.con.Send("ControlCalidad" + "-" + SemaforoEnum.Rojo.ToString() + "1"); // enviar semaforo   
                return;
            }
            if (sumaReproceso < int.Parse(lblLimitesInferiorReproceso.Text))
            {
                btnSemaforo.BackColor = System.Drawing.Color.Green;
                //this.con.Send("ControlCalidad" + "-" + SemaforoEnum.Verde.ToString() + "2"); // enviar semaforo   
                //return;
            }
            if (sumaReproceso >= int.Parse(lblLimitesInferiorReproceso.Text) && sumaReproceso < int.Parse(lblLimitesSuperiorReproceso.Text))
            {
                btnSemaforo.BackColor = System.Drawing.Color.Yellow;
                //this.con.Send("ControlCalidad" + "-" + SemaforoEnum.Amarillo.ToString() + "2"); // enviar semaforo   
                //return;
            }
            if (sumaReproceso >= int.Parse(lblLimitesSuperiorReproceso.Text))
            {
                btnSemaforo.BackColor = System.Drawing.Color.Red;
                this.con.Send("ControlCalidad" + "-" + SemaforoEnum.Rojo.ToString() + "2"); // enviar semaforo   
                return;
            }
        }
    }
}
