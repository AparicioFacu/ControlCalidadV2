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

namespace Semaforo
{
    public partial class Form1 : Form
    {
        private Thread _rec;
        public Dictionary<string, VistaSemaforo> di = new Dictionary<string, VistaSemaforo>();
        public Conexion _con;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            _con = new Conexion();
            _con.Conectar();
            _rec = new Thread(Recibir);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            _con.Send("Monitor1");
            string msg = _con.Receive();
            if (msg == "conectado")
            {
                VistaSemaforo form = new VistaSemaforo("Monitor1", di, _con);
                form.Show();
                di.Add("ControlCalidad", form);
                _rec.Start();
            }
            else
            {
                MessageBox.Show("error conexion");
            }
           
        }
        private void Recibir()
        {
            while (true)
            {
                string msg = _con.Receive();
                string[] todo = msg.Split('-'); //recibe el mensaje
                VistaSemaforo semaforo = di[todo[0]];
                semaforo.Agregar(todo[0] + ": " + todo[1]);
            }                     
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _con.Send("desconectar");
            _con.Desconectar();
        }
    }
}
